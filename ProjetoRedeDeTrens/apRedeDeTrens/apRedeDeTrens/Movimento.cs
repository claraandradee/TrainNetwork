using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Nome: Clara Andrade Sant'Anna Santos RA:22124
//Nome: Julia Enriquetto de Brito      RA:22139 

namespace apRedeDeTrens
{
     class Movimento : IComparable<Movimento>
     {
        int origem, destino; 

        public Movimento(int origem, int destino)
        {
            Origem = origem; 
            Destino = destino;
        }

        public int Origem { get => origem; set => origem = value; }
        public int Destino { get => destino; set => destino = value; }

        public override string ToString()
        {
            return Origem + " " + Destino;
        }

        public int CompareTo(Movimento outro)
        {
            //compara a partir da origem e o destino
            return (Origem.ToString("000") + Destino.ToString("000")).CompareTo(outro.Origem.ToString("000") + outro.Destino.ToString("000"));
        }

    }
}
