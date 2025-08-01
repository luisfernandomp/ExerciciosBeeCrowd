using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao.Desafios
{
    internal class Desafio1430ComposicaoJingles : IDesafioComand
    {
        public void Executar()
        {
            StringBuilder sb = new StringBuilder();
            string linha;

            var dict = new Dictionary<char, decimal>
            {
                { 'W', 1 },
                { 'H', 0.5M },
                { 'Q', 0.25M },
                { 'E', 0.125M },
                { 'S', 0.0625M },
                { 'T', 0.03125M },
                { 'X', 0.015625M }
            };

            while((linha = Console.ReadLine()) != null)
            {
                if(linha == "*")
                {
                    break;
                }

                var partesMelodia = linha.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                int numeroCasosCorretos = 0;
                for (int i = 0, len = partesMelodia.Length; i < len; i++)
                {
                    var valor = partesMelodia[i].Select(c =>
                    {
                        if (dict.ContainsKey(c))
                        {
                            return dict[c];
                        }

                        return 0;
                    }).Sum();

                    if (valor == 1.0M)
                    {
                        numeroCasosCorretos++;
                    }
                }

                sb.AppendLine($"{numeroCasosCorretos}");
                numeroCasosCorretos = 0;
            }

            Console.Write(sb.ToString());
        }
    }
}
