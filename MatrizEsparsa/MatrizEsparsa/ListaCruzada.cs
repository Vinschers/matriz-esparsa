using System;

/// <summary>
/// Classe da matriz que é implementada a partir de uma Lista Ligada.
/// </summary>
class ListaCruzada
{
    Celula primeira, atual, anterior, acima;
    int linhas, colunas;

    //métodos obrigatórios
    public override string ToString()
    {
        atual = primeira.Abaixo.Direita;
        string ret = "{ ";
        while(atual.Abaixo.Linha > primeira.Abaixo.Linha)
        {
            while(atual.Direita.Coluna > primeira.Direita.Coluna)
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
        while (atualThis.Abaixo.Linha > primeira.Abaixo.Linha && atualObj.Abaixo.Linha > l.primeira.Abaixo.Linha)
        {
            while (atualThis.Direita.Coluna > primeira.Direita.Coluna && atualObj.Direita.Coluna > l.primeira.Direita.Coluna)
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
        while (atual.Abaixo.Linha > primeira.Abaixo.Linha)
        {
            while (atual.Direita.Coluna > primeira.Direita.Coluna)
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

    //construtores
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
    public ListaCruzada(int l, int c)
    {
        if (l < 1 || c < 1)
            throw new ArgumentOutOfRangeException();
        primeira = atual = anterior = acima =  null;
        primeira = new Celula(Celula.posicaoDefault, Celula.posicaoDefault, null, null);
        linhas = l;
        colunas = c;
        atual = primeira;
        //Celula.posicaoDefault = 3;
        for (int i = 0; i < c; i++)
        {
            atual.Direita = new Celula(Celula.posicaoDefault, i, null, null);
            atual = atual.Direita;
        }
        atual = primeira;
        for (int i = 0; i < l; i++)
        {
            atual.Abaixo = new Celula(i, Celula.posicaoDefault, null, null);
            atual = atual.Abaixo;
        }
    }

    //métodos gerais
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
    protected bool ExisteCelula(int l, int c)
    {
        bool achou = false;
        bool fim = false;
        atual = primeira.Abaixo.Direita;
        while (atual.Abaixo.Linha > primeira.Abaixo.Linha && !fim)
        {
            while (atual.Direita.Coluna > primeira.Direita.Coluna && !fim)
            {
                if (atual.Coluna == c && atual.Linha < l)
                {
                    acima = atual;
                }
                else if (atual.Linha == l && atual.Coluna == c)
                {
                    fim = true;
                    achou = true;
                }
                else if (atual.Linha > l && atual.Coluna > c)
                {
                    fim = true;
                }
                else
                    atual = atual.Direita;
            }
            if (!fim)
            {
                anterior = atual;
                atual = atual.Abaixo.Direita;
            }
        }
        return achou;
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

    //operações
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