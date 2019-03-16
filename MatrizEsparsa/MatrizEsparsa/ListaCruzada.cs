using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public bool ExisteCelula(int l, int c)
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
    public void Adicionar(Celula c)
    {
        if (c == null)
            throw new ArgumentNullException();
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
}
