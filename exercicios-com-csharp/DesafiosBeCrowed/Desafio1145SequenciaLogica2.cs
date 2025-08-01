using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao.Desafios
{
    internal class Desafio1145SequenciaLogica2 : IDesafioComand
    {
        public void Executar()
        {
            string linha;

            while((linha = Console.ReadLine()) != null)
            {
                string[] partes = linha.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                int numeroRepeticoes = int.Parse(partes[0]);
                int limite = int.Parse(partes[1]);

                int contadorDeEscritasAtePularLinha = 0;
                for (int i = 1; i <= limite; i++)
                {
                    Console.Write(i);
                    contadorDeEscritasAtePularLinha++;

                    if (contadorDeEscritasAtePularLinha < numeroRepeticoes)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.WriteLine();
                        contadorDeEscritasAtePularLinha = 0;
                    }
                }
            }
        }
    }
}
