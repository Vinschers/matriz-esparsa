﻿using System;
using System.Windows.Forms;

/// <summary>
/// Classe da matriz que é implementada a partir de uma Lista Ligada.
/// </summary>
class ListaCruzada
{
    Celula primeira, atual, anterior, acima;
    int linhas, colunas;
    const int defaultDimensao = 1000;



    //Métodos obrigatórios
    /////////////////////////////////////////////////////////////////////////////////////////////
    public override string ToString()
    {
        string ret = "{ ";
        atual = primeira.Abaixo.Direita;
        while(atual.Linha > primeira.Abaixo.Linha)
        {
            while(atual.Coluna > primeira.Coluna)
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
        linhas = colunas = defaultDimensao;
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
            foreach(DataGridViewCell cell in row.Cells)
                Adicionar(new Celula((double)cell.Value, cell.RowIndex + 1, cell.ColumnIndex + 1));
    }



    //Métodos gerais
    /////////////////////////////////////////////////////////////////////////////////////////////

    private void IniciarMatriz()
    {
        primeira = atual = anterior = acima = null;
        primeira = new Celula(Celula.posicaoDefault, Celula.posicaoDefault, null, null);
        atual = primeira;
        for (int i = 1; i <= colunas; i++)
        {
            atual.Direita = new Celula(Celula.posicaoDefault, i, null, null);
            atual.Abaixo = atual;
            atual = atual.Direita;
        }
        atual.Direita = primeira;
        primeira.Abaixo = new Celula(1, Celula.posicaoDefault, null, null);
        atual = primeira.Abaixo;
        for (int i = 2; i <= linhas; i++)
        {
            atual.Abaixo = new Celula(i, Celula.posicaoDefault, null, null);
            atual.Direita = atual;
            atual = atual.Abaixo;
        }
        atual.Abaixo = primeira;
    }

    public void MudarDimensao(int l, int c)
    {
        if (l > linhas)
        {
            for (atual = primeira; atual.Abaixo != null; atual = atual.Abaixo) { } //quando o for acabar, atual será o nó-cabeca da última linha
            int diffLinhas = l - linhas;
            for (int i = 0; i < diffLinhas; i++)
            {
                atual.Abaixo = new Celula(linhas + i, Celula.posicaoDefault, null, null);
                atual = atual.Abaixo;
            }
        }
        else if (l < linhas)
        {
            atual = primeira;
            for (int i = 0; i < l; i++)
                atual = atual.Abaixo; //atual é o nó-cabeca da linha nova, que será a última
            Celula noCabecaLinhaAtual = atual;
            atual.Abaixo = null;
            atual = atual.Direita;
            while (atual != noCabecaLinhaAtual) //enquanto atual não percorreu todas as células da linha
            {
                if (!atual.Abaixo.Equals(atual))
                    atual.Abaixo = null; //os ponteiros são desfeitos e, assim, todas as células abaixo da nova última linha são apagadas
                atual = atual.Direita;
            }
        }
        linhas = l;
        if (c > colunas)
        {
            for (atual = primeira; atual.Direita != null; atual = atual.Direita) { } //quando o for acabar, atual será o nó-cabeca da última coluna
            int diffColunas = c - colunas;
            for (int i = 0; i < diffColunas; i++)
            {
                atual.Direita = new Celula(Celula.posicaoDefault, colunas + i, null, null);
                atual = atual.Direita;
            }
        }
        else if (c < colunas)
        {
            //o mesmo processo ao de se l < linhas é aplicado aqui, porém com as colunas
            atual = primeira;
            for (int i = 0; i < c; i++)
                atual = atual.Direita;
            Celula noCabecaColunaAtual = atual;
            atual.Direita = null;
            atual = atual.Abaixo;
            while (atual != noCabecaColunaAtual)
            {
                atual.Direita = null;
                atual = atual.Abaixo;
            }
        }
        colunas = c;
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
        get => primeira == null;
    }
    public int Linhas { get => linhas; }
    public int Colunas { get => colunas; }

    protected bool ExisteCelula(int l, int c)
    {
        //bool achou = false;
        //bool fim = false;
        //atual = primeira.Abaixo.Direita;
        //while (atual.Abaixo.Linha > primeira.Abaixo.Linha && !fim)
        //{
        //    while (atual.Direita.Coluna > primeira.Direita.Coluna && !fim)
        //    {
        //        if (atual.Coluna == c && atual.Linha < l)
        //        {
        //            acima = atual;
        //        }
        //        else if (atual.Linha == l && atual.Coluna == c)
        //        {
        //            fim = true;
        //            achou = true;
        //        }
        //        else if (atual.Linha > l && atual.Coluna > c)
        //        {
        //            fim = true;
        //        }
        //        else
        //            atual = atual.Direita;
        //    }
        //    if (!fim)
        //    {
        //        anterior = atual;
        //        atual = atual.Abaixo.Direita;
        //    }
        //}
        //return achou;
        atual = primeira;
        while(atual.Linha != primeira.Linha)
        {
            while(atual.Coluna != primeira.Coluna)
            {
                if (l == atual.Linha && c == atual.Coluna)
                    return true;
                else if (l <= atual.Linha && c < atual.Coluna)
                    return false;
                else
                {
                    anterior = atual;
                    atual = atual.Direita;
                }
            }
            acima = atual;
            atual = atual.Abaixo;
        }
        return false;
    }

    public double Achar(int l, int c)
    {
        if (l > linhas || c > colunas)
            throw new ArgumentOutOfRangeException();
        if (ExisteCelula(l, c))
            return atual.Valor;
        else
            return 0;
    }

    public void Adicionar(Celula c)
    {
        if (c == null || c.Linha < 0 || c.Coluna < 0)
            throw new ArgumentException("Célula inválida");
        if (EstaVazia)
        {
            primeira.Abaixo.Direita = c;
            primeira.Direita.Abaixo = c;
            c.Direita = primeira.Abaixo;
            c.Abaixo = primeira.Direita;
        }
        else if (!ExisteCelula(c.Linha, c.Coluna))
        {
            c.Direita = atual;
            anterior.Direita = c;
            c.Abaixo = acima.Abaixo;
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

    public void Alterar(int l, int c, double v)
    {
        if (ExisteCelula(l, c))
            atual.Valor = v;
    }



    //Operações
    /////////////////////////////////////////////////////////////////////////////////////////////
    public static ListaCruzada Somar(ListaCruzada l1, ListaCruzada l2)
    {
        throw new NotImplementedException();
    }
    public static ListaCruzada Multiplicar(ListaCruzada l1, ListaCruzada l2)
    {
        throw new NotImplementedException();
    }
    public static ListaCruzada Inverter(ListaCruzada l1, ListaCruzada l2)
    {
        throw new NotImplementedException();
    }
    public static ListaCruzada Transpor(ListaCruzada l1, ListaCruzada l2)
    {
        throw new NotImplementedException();
    }
}