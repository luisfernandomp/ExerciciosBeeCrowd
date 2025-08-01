using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao.Desafios
{
    internal class Desafio1029Fibonacci : IDesafioComand
    {
        public void Executar()
        {
            StringBuilder sb = new StringBuilder();
            string linha;
            while ((linha = Console.ReadLine()) != null)
            {
                int quantidadeDeCasos = int.Parse(linha);

                for(int i = 0; i < quantidadeDeCasos; i++)
                {
                    int numero = int.Parse(Console.ReadLine());
                    var fib = CalcularFibonnaci(numero);
                    sb.AppendLine($"fib({numero}) = {fib.chamadas} calls = {fib.resultado}");
                }
            }

            Console.Write(sb.ToString());
        }

        private (int resultado, int chamadas) CalcularFibonnaci(int numero, int chamadasRecursivas = 0)
        {
            if (numero == 0)
            {
                return (0, chamadasRecursivas);
            }
            
            if(numero == 1)
            {
                return (1, chamadasRecursivas);
            }

            var n1 = CalcularFibonnaci(numero - 1, chamadasRecursivas += 1);
            chamadasRecursivas = 0;
            var n2 = CalcularFibonnaci(numero - 2, chamadasRecursivas += 1);

            return (n1.resultado + n2.resultado, n1.chamadas + n2.chamadas);
        }
    }
}
