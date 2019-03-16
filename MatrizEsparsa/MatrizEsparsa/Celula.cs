﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Classe Celula que será usada para preencher a Lista duplamente ligada
/// </summary>
class Celula
{
    //declaração de atributos da classe
    protected Celula celulaDireita, celulaAbaixo; //ponteiros para as células que estão à direita e em baixo da célula this
    protected int linha, coluna; //valores que representam a posição da célula na matriz
    protected double valor; //valor que a célula tem

    //propriedades
    /// <summary>
    /// Propriedade da linha da célula com get e set
    /// </summary>
    public int Linha
    {
        get => linha;
        set
        {
            if (value >= -1)
                linha = value;
        }
    }
    /// <summary>
    /// Propriedade da coluna da célula com get e set
    /// </summary>
    public int Coluna
    {
        get => coluna;
        set
        {
            if (value >= -1)
                coluna = value;
        }
    }
    /// <summary>
    /// Propriedade do valor da célula com get e set
    /// </summary>
    public double Valor { get => valor; set => valor = value; }
    /// <summary>
    /// Propriedade da célula à direita desta com get e set
    /// </summary>
    public Celula Direita { get => celulaDireita; set => celulaDireita = value; }
    /// <summary>
    /// Propriedade da célula abaixo desta com get e set
    /// </summary>
    public Celula Abaixo { get => celulaAbaixo; set => celulaAbaixo = value; }

    //construtores
    /// <summary>
    /// Construtor com todos os atributos
    /// </summary>
    /// <param name="v">Valor que a célula terá</param>
    /// <param name="l">Linha que a célula ocupará na matriz (começa em 1)</param>
    /// <param name="c">Coluna que a célula ocupará na matriz (começa em 1)</param>
    /// <param name="a">Objeto da célula abaixo desta na lista ligada</param>
    /// <param name="d">Objeto da célula à direita desta na lista ligada</param>
    public Celula(double v, int l, int c, Celula a, Celula d)
    {
        Valor = v;
        Linha = l;
        Coluna = c;
        Abaixo = a;
        Direita = d;
    }
    /// <summary>
    /// Construtor com o valor e as células adjacentes apenas
    /// </summary>
    /// <param name="v">Valor que a célula terá</param>
    /// <param name="a">Objeto da célula abaixo desta na lista ligada</param>
    /// <param name="d">Objeto da célula à direita desta na lista ligada</param>
    public Celula(double v, Celula a, Celula d)
    {
        Direita = d;
        Abaixo = a;
        Linha = Coluna = -1; //a posição fica com o valor default (-1)
    }
    /// <summary>
    /// Construtor com a posição apenas
    /// </summary>
    /// <param name="v">Valor que a célula terá</param>
    /// <param name="l">Linha que a célula ocupará na matriz (começa em 1)</param>
    /// <param name="c">Coluna que a célula ocupará na matriz (começa em 1)</param>
    public Celula(double v, int l, int c)
    {
        Linha = l;
        Coluna = c;
        Direita = Abaixo = null; //as células adjacentes ficam com o valor default (null)
    }
    /// <summary>
    /// Construtor com apenas o valor da célula
    /// </summary>
    /// <param name="v">Valor que a célula terá</param>
    public Celula(double v)
    {
        Valor = v;
        //os outros atributos ficam com o valor default
        Linha = Coluna = -1;
        Direita = Abaixo = null;
    }

    //métodos obrigatórios
    public override string ToString()
    {
        return $"[{Linha}, {Coluna}] - {Valor}";
    }
                                                     //Duda, verifica esses dois pra mim pq eu n sei se ta certo
    public override bool Equals(object obj)
    {
        if (obj == this)
            return true;
        if (obj == null)
            return false;
        Celula c = obj as Celula;
        if (!c.Valor.Equals(Valor))
            return false;
        if (!c.Linha.Equals(Linha))
            return false;
        if (!c.Coluna.Equals(Coluna))
            return false;
        return true;
    }
    public override int GetHashCode()
    {
        int ret = 43;
        ret = ret * 2 + linha.GetHashCode();
        ret = ret * 3 + coluna.GetHashCode();
        ret = ret * 5 + valor.GetHashCode();
        return ret;
    }
                                                    //sera que precisa considerar as Celular Diretia e Abaixo???
}