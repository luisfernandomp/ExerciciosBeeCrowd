using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao.Desafios
{
    internal class Desafio1253CifraDeCesar : IDesafioComand
    {
        public void Executar()
        {
            string linha;
            while ((linha = Console.ReadLine()) != null)
            {
                int numerosDeTestes = Convert.ToInt32(linha);

                for (int i = 0; i < numerosDeTestes; i++)
                {
                    string palavraCifrada = Console.ReadLine();
                    int quantidadePosicoesDeslocadas = Convert.ToInt32(Console.ReadLine());

                    for (int j = 0, len = palavraCifrada.Length; j < len; j++)
                    {
                        int pos = (palavraCifrada[j] - 'A' - quantidadePosicoesDeslocadas + 26) % 26;
                        Console.Write((char)('A' + pos));
                    }

                    Console.WriteLine();
                }
            }

        }
    }
}
