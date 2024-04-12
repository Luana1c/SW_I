using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_3
{

    public class AlbumDeFotos
    {
        public int numTotalDePags;
        public int numDeFts;
        public AlbumDeFotos(int numTotalDePags)
        {

            this.numTotalDePags = numTotalDePags;
        }

        public int NumTotalDePags { get; set; }
        public int NumTotalDeFts { get { return numTotalDePags * 2; } }
        public int NumeroDeFotos
        {
            get { return numDeFts; }
            set
            {
                if (value > NumTotalDeFts)
                {
                    Console.WriteLine("Erro: O número de fotos excede o máximo permitido.");
                }
                else
                {
                    numDeFts = value;
                }

            }

        }


    }



}
