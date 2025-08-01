using System.Collections.ObjectModel;

namespace Programacao.Desafios
{
    internal class Desafio1131Grenais : IDesafioComand
    {
        public void Executar() 
        {
            string linha = null;

            while ((linha = Console.ReadLine()) != null)
            {
                int golsInter = 0,
                    golsGremio = 0,
                    jogosVencidosPeloInter = 0,
                    jogosVencidosPeloGremio = 0;

                var jogos = new Collection<(int golsInter, int golsGremio)>();
                bool novoGrenal = false;

                do
                {
                    string[] pedacosLinha = linha.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    golsInter = Convert.ToInt32(pedacosLinha[0]);
                    golsGremio = Convert.ToInt32(pedacosLinha[1]);

                    jogos.Add((golsInter, golsGremio));

                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    string respostaParaNovoGrenal = Console.ReadLine();

                    int respostaParaNovoGrenalConvertida = Convert.ToInt32(respostaParaNovoGrenal.Trim());

                    novoGrenal = (respostaParaNovoGrenalConvertida == 1) ? true : (respostaParaNovoGrenalConvertida == 2) ? false : false;

                    if (novoGrenal)
                    {
                        linha = Console.ReadLine();
                    }

                } while (novoGrenal);

                Console.WriteLine($"{jogos.Count} grenais");

                foreach (var jogo in jogos)
                {
                    if (jogo.golsInter > jogo.golsGremio)
                    {
                        jogosVencidosPeloInter++;
                    }
                    else if (jogo.golsInter < jogo.golsGremio)
                    {
                        jogosVencidosPeloGremio++;
                    }
                }

                Console.WriteLine($"Inter:{jogosVencidosPeloInter}");
                Console.WriteLine($"Gremio:{jogosVencidosPeloGremio}");
                Console.WriteLine($"Empates:{jogos.Count - (jogosVencidosPeloInter + jogosVencidosPeloGremio)}");

                if (jogosVencidosPeloInter > jogosVencidosPeloGremio)
                {
                    Console.WriteLine("Inter venceu mais");
                }
                else if (jogosVencidosPeloGremio > jogosVencidosPeloInter)
                {
                    Console.WriteLine("Gremio venceu mais");
                }
            }
        }
    }
}
