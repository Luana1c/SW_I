using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novo
{
    internal class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public float AreaCalculada { get; set; }

        public void Escolha(int opcao)
        {
            if( opcao == 1)
            {
                float quadrado = CalculaAreaQuadrado();
                Console.WriteLine("area do quadrado é :" + quadrado);
            }
            if (opcao == 2)
            {
               float retangulo = CalculaAreaRetangulo();
                Console.WriteLine("area do retangulo é :" + retangulo);
            }
            if (opcao == 3)
            {
               float triangulo = CalculaAreaTriangulo();
                Console.WriteLine("area do triangulo é :" + triangulo);
            }
            
        }
        //Criando metodo para o usuario escolher
        public float CalculaAreaQuadrado()
        {
            return AreaCalculada;
        }
        public float CalculaAreaRetangulo()
        {
            return AreaCalculada;
        }
        public float CalculaAreaTriangulo()
        {
            return AreaCalculada;
        }

    }
}
