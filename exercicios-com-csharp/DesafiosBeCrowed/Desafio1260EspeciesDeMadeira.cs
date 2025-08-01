using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Programacao.Desafios
{
    internal class Desafio1260EspeciesDeMadeira : IDesafioComand
    {
        public void Executar()
        {
            StringBuilder sb = new StringBuilder();
            string linha = Console.ReadLine();

            if (string.IsNullOrEmpty(linha))
                return;

            int casosDeTeste = int.Parse(linha);
            Console.ReadLine();

            for (int i = 0; i < casosDeTeste; i++)
            {
                var dict = new Dictionary<string, int>(StringComparer.Ordinal);
                int total = 0;

                while (true)
                {
                    string nomeEspecie = Console.ReadLine();

                    if (string.IsNullOrEmpty(nomeEspecie))
                        break;

                    if (dict.ContainsKey(nomeEspecie))
                    {
                        dict[nomeEspecie]++;
                    }
                    else
                    {
                        dict[nomeEspecie] = 1;
                    }

                    total++;
                }

                foreach (var item in dict.OrderBy(x => x.Key, StringComparer.OrdinalIgnoreCase))
                {
                    double percentual = (double)(item.Value * 100)/total;
                    sb.AppendLine($"{item.Key} {percentual.ToString("F4", CultureInfo.InvariantCulture)}");
                }

                if((i + 1) < casosDeTeste)
                {
                    sb.AppendLine();
                }
            }

            Console.Write(sb.ToString());
        }
    }
}
