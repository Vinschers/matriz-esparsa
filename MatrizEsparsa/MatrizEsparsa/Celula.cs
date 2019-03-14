using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizEsparsa
{
    class Celula
    {
        protected Celula celulaDireita, celulaAbaixo;

        protected int linha, coluna;

        protected double valor;
        public int Linha { get => linha; set =>  linha = value; }
        public int Coluna { get => coluna; set => coluna = value; }
        public double Valor { get => valor; set => valor = value; }
        public Celula CelulaDireita { get => celulaDireita; set => celulaDireita = value; }
        public Celula CelulaAbaixo { get => celulaAbaixo; set => celulaAbaixo = value; }


    }
}
