using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao.Desafios
{
    internal class Desafio1153FatorialSimples : IDesafioComand
    {
        public void Executar()
        {
            string linha;

            while((linha = Console.ReadLine()) != null)
            {
                int numero = int.Parse(linha.Trim());

                int acumulador = 1;

                for(int i = 0; i < numero; i++)
                {    
                    acumulador *= (numero - i);
                }

                Console.WriteLine(acumulador);
            }
        }
    }
}
