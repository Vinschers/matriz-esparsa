using System;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// Classe da matriz que é implementada a partir de uma Lista Ligada.
/// </summary>
class ListaCruzada
{
    Celula primeira, atual, anterior, acima;
    int linhas, colunas;
    public const int dimensaoDefault = 20;



    //Métodos obrigatórios
    /////////////////////////////////////////////////////////////////////////////////////////////
    public override string ToString()
    {
        string ret = "{ ";
        atual = primeira.Abaixo.Direita;
        while (atual.Linha > primeira.Abaixo.Linha)
        {
            while (atual.Coluna > primeira.Coluna)
            {
                ret += atual.Valor + " ";
                atual = atual.Direita;
            }
            ret += "\n";
            atual = atual.Abaixo.Direita;
        }
        return ret + " }";
    }

    public override bool Equals(object obj)
    {
        if (obj == this)
            return true;
        if (obj == null)
            return false;
        ListaCruzada l = obj as ListaCruzada;
        if (l.linhas != linhas)
            return false;
        if (l.colunas != colunas)
            return false;
        var atualThis = primeira.Abaixo.Direita;
        var atualObj = l.primeira.Abaixo.Direita;
        while (atualThis.Linha > primeira.Linha && atualObj.Linha > l.primeira.Linha)
        {
            while (atualThis.Coluna > primeira.Coluna && atualObj.Coluna > l.primeira.Coluna)
            {
                if (!atualThis.Equals(atualObj))
                    return false;
                atualThis = atualThis.Direita;
                atualObj = atualObj.Direita;
            }
            atualThis = atualThis.Abaixo.Direita;
            atualObj = atualObj.Abaixo.Direita;
        }
        return true;
    }

    public override int GetHashCode()
    {
        atual = primeira.Abaixo.Direita;
        int ret = 34;
        ret = ret * 2 + linhas.GetHashCode();
        ret = ret * 2 + linhas.GetHashCode();
        while (atual.Linha > primeira.Linha)
        {
            while (atual.Coluna > primeira.Coluna)
            {
                ret += ret * 3 + atual.GetHashCode();
                atual = atual.Direita;
            }
            atual = atual.Abaixo.Direita;
        }
        return ret;
    }

    public object Clone()
    {
        ListaCruzada l = null;
        try
        {
            l = new ListaCruzada(this);
        }
        catch (Exception e) { }
        return l;
    }



    //Construtores
    /////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Construtor padrão. Inicia a matriz com uma dimensão pré definida de 1000x1000
    /// </summary>
    public ListaCruzada()
    {
        linhas = colunas = dimensaoDefault;
        IniciarMatriz();
    }

    /// <summary>
    /// Construtor de cópia para criar uma matriz identica a passada como parâmetro.
    /// </summary>
    /// <param name="l">Matriz que será copiada para a nova lista.</param>
    public ListaCruzada(ListaCruzada l)
    {
        if (l == null)
            throw new ArgumentNullException();
        this.primeira = l.primeira;
        this.atual = l.atual;
        this.anterior = l.anterior;
        this.acima = l.acima;
        this.linhas = l.linhas;
        this.colunas = l.colunas;
    }

    /// <summary>
    /// Construtor que cria uma matriz vazia, com número de linhas e colunas definido
    /// </summary>
    /// <param name="l">Número de linhas da matriz</param>
    /// <param name="c">Número de colunas da matriz</param>
    public ListaCruzada(int l, int c)
    {
        if (l < 1 || c < 1)
            throw new ArgumentOutOfRangeException();
        linhas = l;
        colunas = c;
        //Celula.posicaoDefault = 3;
        IniciarMatriz();
    }

    /// <summary>
    /// Construtor a partir de um DataGridView da aplicação
    /// </summary>
    /// <param name="dgv">DataGridView usado para construir a matriz</param>
    public ListaCruzada(DataGridView dgv)
    {
        linhas = dgv.RowCount;
        colunas = dgv.ColumnCount;
        IniciarMatriz();
        foreach (DataGridViewRow row in dgv.Rows)
            foreach (DataGridViewCell cell in row.Cells)
                Adicionar(new Celula((double)cell.Value, cell.RowIndex + 1, cell.ColumnIndex + 1));
    }

    public ListaCruzada(StreamReader sr)
    {
        if (sr != null)
        {
            string linhaDimensoes = sr.ReadLine();
            string[] dimensoes = linhaDimensoes.Split(' ');
            linhas = int.Parse(dimensoes[0]);
            colunas = int.Parse(dimensoes[1]);
            IniciarMatriz();
            while (!sr.EndOfStream)
            {
                string linha = sr.ReadLine();
                Adicionar(new Celula(linha));
            }
            sr.Close();
        }
    }



    //Métodos gerais
    /////////////////////////////////////////////////////////////////////////////////////////////

    public double this[int i, int j]
    {
        get
        {
            if (i <= linhas && j <= colunas)
            {
                if (ExisteCelula(i, j))
                    return atual.Valor;
                else
                    return 0;
            }
            else
                return 0;
        }
    }

    protected void IniciarMatriz()
    {
        primeira = atual = anterior = acima = null;
        primeira = new Celula(Celula.posicaoDefault, Celula.posicaoDefault, null, null);
        atual = primeira;
        for (int i = 1; i <= colunas; i++)
        {
            atual.Direita = new Celula(Celula.posicaoDefault, i, null, null);
            atual.Abaixo = atual;
            anterior = atual;
            atual = atual.Direita;
        }
        atual.Direita = primeira;
        atual.Abaixo = atual;
        primeira.Abaixo = new Celula(1, Celula.posicaoDefault, null, null);
        atual = primeira.Abaixo;
        for (int i = 2; i <= linhas; i++)
        {
            atual.Abaixo = new Celula(i, Celula.posicaoDefault, null, null);
            atual.Direita = atual;
            anterior = atual;
            atual = atual.Abaixo;
        }
        atual.Abaixo = primeira;
        atual.Direita = atual;
    }

    public void MudarDimensao(int l, int c)
    {
        if (l > linhas)
        {
            for (atual = primeira; atual.Abaixo != primeira; atual = atual.Abaixo)
            {
                anterior = atual;
            } //quando o for acabar, atual será o nó-cabeca da última linha
            int diffLinhas = l - linhas;
            for (int i = 0; i < diffLinhas; i++)
            {
                atual.Abaixo = new Celula(linhas + i, Celula.posicaoDefault, null, null);
                atual.Direita = atual;
                anterior = atual;
                atual = atual.Abaixo;
            }
            anterior.Abaixo = primeira;
        }
        else if (l < linhas)
        {
            atual = primeira;
            for (int i = 0; i < l; i++)
                atual = atual.Abaixo; //atual é o nó-cabeca da linha nova, que será a última
            Celula noCabecaLinhaAtual = atual;
            atual.Abaixo = primeira;
            atual = atual.Direita;
            while (atual != noCabecaLinhaAtual) //enquanto atual não percorreu todas as células da linha
            {
                Celula noCabecaColunaAtual;
                for (noCabecaColunaAtual = atual; noCabecaColunaAtual.Linha != Celula.posicaoDefault; noCabecaColunaAtual = noCabecaColunaAtual.Abaixo) { }
                //noCabecaColunaAtual ganha o valor esperado depois do for
                if (!atual.Abaixo.Equals(atual))
                    atual.Abaixo = noCabecaColunaAtual; //os ponteiros são desfeitos e, assim, todas as células abaixo da nova última linha são apagadas
                                                        //para nao perder a circularidade da lista, a celula Abaixo nao fica nula, mas aponta para o no cabeca correspondente
                atual = atual.Direita;
            }
        }
        linhas = l;
        if (c > colunas)
        {
            for (atual = primeira; atual.Direita != primeira; atual = atual.Direita) { } //quando o for acabar, atual será o nó-cabeca da última coluna
            int diffColunas = c - colunas;
            for (int i = 0; i < diffColunas; i++)
            {
                atual.Direita = new Celula(Celula.posicaoDefault, colunas + i, null, null);
                atual.Abaixo = atual;
                anterior = atual;
                atual = atual.Direita;
            }
            anterior.Direita = primeira;
        }
        else if (c < colunas)
        {
            //o mesmo processo ao de se l < linhas é aplicado aqui, porém com as colunas
            atual = primeira;
            for (int i = 0; i < c; i++)
                atual = atual.Direita;
            Celula noCabecaColunaAtual = atual;
            atual.Direita = primeira;
            atual = atual.Abaixo;
            while (atual != noCabecaColunaAtual)
            {
                Celula noCabecaLinhaAtual;
                for (noCabecaLinhaAtual = atual; noCabecaLinhaAtual.Linha != Celula.posicaoDefault; noCabecaLinhaAtual = noCabecaLinhaAtual.Abaixo) { }
                if (!atual.Abaixo.Equals(atual))
                    atual.Direita = noCabecaLinhaAtual;
                atual = atual.Abaixo;
            }
        }
        colunas = c;
    }

    public void Exibir(ref DataGridView dgv)
    {
        dgv.RowCount = linhas;
        dgv.ColumnCount = colunas;
        foreach (DataGridViewRow r in dgv.Rows)
            foreach (DataGridViewCell c in r.Cells)
                c.Value = 0;
        atual = primeira.Abaixo.Direita;
        while (atual.Linha != Celula.posicaoDefault)
        {
            while (atual.Coluna != Celula.posicaoDefault)
            {
                DataGridViewRow row = dgv.Rows[atual.Linha - 1];
                DataGridViewCell cell = row.Cells[atual.Coluna - 1];
                cell.Value = atual.Valor;
                atual = atual.Direita;
            }
            atual = atual.Abaixo.Direita;
        }
    }

    public int Contar()
    {
        atual = primeira.Abaixo.Direita;
        int ret = 0;
        while (atual.Abaixo.Linha > primeira.Abaixo.Linha)
        {
            while (atual.Direita.Coluna > primeira.Direita.Coluna)
            {
                ret++;
                atual = atual.Direita;
            }
            atual = atual.Abaixo.Direita;
        }
        return ret;
    }

    public bool EstaVazia
    {
        get => primeira.Abaixo.Direita == primeira.Abaixo;
    }
    public int Linhas { get => linhas; }
    public int Colunas { get => colunas; }

    protected bool ExisteCelula(int l, int c)
    {
        //atual = primeira.Abaixo.Direita;
        //anterior = primeira.Abaixo;
        //acima = primeira.Direita;
        //while (atual.Linha != Celula.posicaoDefault)
        //{
        //    while (atual.Coluna != Celula.posicaoDefault)
        //    {
        //        if (l == atual.Linha && c == atual.Coluna)
        //            return true;
        //        else if (l <= atual.Linha && c < atual.Coluna)
        //            return false;
        //        else
        //        {
        //            anterior = atual;
        //            atual = atual.Direita;
        //            AtualizarAcima();
        //        }
        //    }
        //    if (l < atual.Linha)
        //        return false;
        //    if (atual.Abaixo.Linha == Celula.posicaoDefault)
        //        return false;
        //    anterior = atual.Abaixo;
        //    atual = anterior.Direita;
        //    for (acima = primeira.Direita; acima.Coluna < c; acima = acima.Direita) { }
        //}
        //return false;
        for (acima = primeira; acima.Coluna < c; acima = acima.Direita) { }
        if (acima.Abaixo != acima)
            while (acima.Abaixo.Linha < l && acima.Abaixo.Linha != Celula.posicaoDefault)
                acima = acima.Abaixo;
        //acima agora esta acima da celula desejada
        for (atual = primeira; atual.Linha < l; atual = atual.Abaixo) { }
        anterior = atual;
        atual = atual.Direita;
        while (atual.Coluna < c && atual.Coluna != Celula.posicaoDefault)
        {
            anterior = atual;
            atual = atual.Direita;
        }
        return (atual.Linha == l && atual.Coluna == c);
    }

    protected void AtualizarAcima()
    {
        //if (acima.Direita.Coluna == atual.Coluna) //se a celula a direita da linha acima estiver na mesma coluna que atual
        //    acima = acima.Direita; //acima apenas vai para a direita
        //else //se nao estiver na mesma coluna
        //{
        //    for (acima = atual; acima.Linha != Celula.posicaoDefault; acima = acima.Abaixo) { } //acima eh o no cabeca da coluna atual
        //    if (acima.Abaixo != acima) //se o ultimo termo antes de atual nao for um no cabeca
        //    {
        //        while (acima.Abaixo.Linha < atual.Linha)
        //            acima = acima.Abaixo;
        //        //ao fim do while, acima sera a celula logo acima de atual
        //    }
        //}
        //if (atual.Coluna == Celula.posicaoDefault)
        //    acima = primeira.Direita;

        if (atual.Coluna == Celula.posicaoDefault)
            acima = primeira.Direita;
        else
        {
            for (acima = atual; acima.Linha != Celula.posicaoDefault; acima = acima.Abaixo) { } //acima eh o no cabeca da coluna atual
            if (acima.Abaixo != acima) //se o ultimo termo antes de atual nao for um no cabeca
            {
                while (acima.Abaixo.Linha < atual.Linha)
                    acima = acima.Abaixo;
                //ao fim do while, acima sera a celula logo acima de atual
            }
        }
    }

    public void Adicionar(Celula c)
    {
        if (c == null || c.Linha < 0 || c.Coluna < 0)
            throw new ArgumentException("Célula inválida");
        if (!ExisteCelula(c.Linha, c.Coluna))
        {
            c.Direita = atual;
            anterior.Direita = c;
            if (acima.Linha > Celula.posicaoDefault)
                c.Abaixo = acima.Abaixo;
            else
                c.Abaixo = acima;
            acima.Abaixo = c;
        }
    }

    public void Remover(Celula c)
    {
        if (c == null || c.Linha < 0 || c.Coluna < 0)
            throw new ArgumentException("Célula inválida");
        if (ExisteCelula(c.Linha, c.Coluna))
        {
            acima.Abaixo = atual.Abaixo;
            anterior.Direita = atual.Direita;
        }
    }

    public void Remover(int l, int c)
    {
        if (ExisteCelula(l, c))
        {
            anterior.Direita = atual.Direita;
            acima.Abaixo = atual.Abaixo;
        }
    }

    public void RemoverTudo()
    {
        IniciarMatriz();
    }

    public void Alterar(int l, int c, double v)
    {
        if (ExisteCelula(l, c))
            atual.Valor = v;
    }

    public void Salvar(StreamWriter sw)
    {
        if (sw != null)
        {
            sw.WriteLine(linhas + " " + colunas);
            atual = primeira.Abaixo.Direita;
            while (atual.Linha != Celula.posicaoDefault)
            {
                while (atual.Coluna != Celula.posicaoDefault)
                {
                    sw.WriteLine(atual.ParaArquivo());
                    atual = atual.Direita;
                }
                atual = atual.Abaixo.Direita;
            }
            sw.Close();
        }
    }



    //Operações
    /////////////////////////////////////////////////////////////////////////////////////////////
    public ListaCruzada Somar(ListaCruzada l2)
    {
        if (!Colunas.Equals(l2.Colunas) || !Linhas.Equals(l2.Linhas))  // confere se o número de linhas e colunas é o mesmo da matriz this
            throw new Exception("O tamanho da matriz passada deve ser o mesmo da primeira matriz para somar!");

        ListaCruzada listaSoma = new ListaCruzada(linhas, colunas); // declara e instancia a lista que será retornada

        atual = this.primeira.Abaixo.Direita;
        l2.atual = l2.primeira.Abaixo.Direita;

        for (int l = 1; l <= linhas; l++)
        {
            for(int c = 1; c <= colunas; c++)
            {
                
                Celula add = new Celula((atual.Valor + l2.atual.Valor), l, c);
                if (add.Valor != 0)
                {
                    listaSoma.Adicionar(add);
                }
                atual = atual.Direita;
                l2.atual = l2.atual.Direita;
            }
            atual = atual.Abaixo.Direita;
            l2.atual = l2.atual.Abaixo.Direita;
        }
        return listaSoma;

    }

    public ListaCruzada Multiplicar(ListaCruzada l2)
    {
        if (colunas != l2.linhas)
            throw new Exception("Tamanho da matriz B inválido");
        ListaCruzada listaMultiplicacao = new ListaCruzada(linhas, l2.colunas);
        for (atual = primeira.Abaixo.Direita;
            atual.Linha != Celula.posicaoDefault;
            atual = atual.Abaixo)
        {
            double somaAtual = 0;
            for (l2.atual = l2.primeira.Abaixo.Direita;
                l2.atual.Coluna != Celula.posicaoDefault;
                l2.atual = l2.atual.Direita)
            {
                while (atual.Coluna != Celula.posicaoDefault && l2.atual.Linha != Celula.posicaoDefault)
                {
                    somaAtual += atual.Valor * l2.atual.Valor;
                    atual = atual.Direita;
                    l2.atual = l2.atual.Abaixo;
                }
                listaMultiplicacao.Adicionar(new Celula(somaAtual, atual.Linha, l2.atual.Coluna));
                atual = atual.Direita;
                l2.atual = l2.atual.Abaixo;
            }
        }
        return listaMultiplicacao;
    }
    public ListaCruzada Inverter()
    {
        throw new NotImplementedException();
    }
    public ListaCruzada Transpor()
    {
        throw new NotImplementedException();
    }
}