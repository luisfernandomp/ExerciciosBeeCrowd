using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao.Desafios
{
    internal class Desafio1160CrescimentoPopulacional : IDesafioComand
    {
        public void Executar()
        {
            string linha;

            while((linha = Console.ReadLine()) != null)
            {
                int quantidadeDeCasos = int.Parse(linha);

                for (int i = 0; i < quantidadeDeCasos; i++)
                {
                    string linhaComDadosPopulacionais = Console.ReadLine();

                    string[] partesLinhaComDadosPopulacionais = linhaComDadosPopulacionais.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                    int populacaoCidadeA = int.Parse(partesLinhaComDadosPopulacionais[0]);
                    int populacaoCidadeB = int.Parse(partesLinhaComDadosPopulacionais[1]);
                    double taxaCrescimentoCidadeA = Convert.ToDouble(partesLinhaComDadosPopulacionais[2], CultureInfo.InvariantCulture);
                    double taxaCrescimentoCidadeB = double.Parse(partesLinhaComDadosPopulacionais[3], CultureInfo.InvariantCulture);

                    int quantidadeDeAnosAteIgualarPopulacao = 0;


                    while (populacaoCidadeA <= populacaoCidadeB)
                    {
                        int populacaoCidadeAComTaxaCrescimento = (int)((populacaoCidadeA * (taxaCrescimentoCidadeA/100)));
                        int populacaoCidadeBComTaxaCrescimento = (int)((populacaoCidadeB * (taxaCrescimentoCidadeB/100)));

                        populacaoCidadeA += populacaoCidadeAComTaxaCrescimento;
                        populacaoCidadeB += populacaoCidadeBComTaxaCrescimento;
                        quantidadeDeAnosAteIgualarPopulacao++;

                        if(quantidadeDeAnosAteIgualarPopulacao > 100)
                        {
                            break;
                        }

                    }


                    if(quantidadeDeAnosAteIgualarPopulacao > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                        continue;
                    }

                    Console.WriteLine($"{quantidadeDeAnosAteIgualarPopulacao} anos.");
                }
            }

        }
    }
}
