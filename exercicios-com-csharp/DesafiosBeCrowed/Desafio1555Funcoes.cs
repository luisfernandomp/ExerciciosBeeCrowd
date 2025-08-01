using System.Text;

namespace Programacao.Desafios
{
    internal class Desafio1555Funcoes : IDesafioComand
    {
        public void Executar()
        {
            StringBuilder sb = new StringBuilder();
            string linha;

            while((linha = Console.ReadLine()) != null)
            {
                int casosDeTeste = int.Parse(linha);
                Console.ReadLine();

                for (int i = 0; i < casosDeTeste; i++)
                {
                    linha = Console.ReadLine();

                    string[] valoresDeXY = linha.Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    int valorDeX = int.Parse(valoresDeXY[0]),
                        valorDeY = int.Parse(valoresDeXY[1]);

                    double valorDeRafael = FuncaoDeRafael(valorDeX, valorDeY);
                    double valorDeBeto = FuncaoDeBeto(valorDeX, valorDeY);
                    double valorDeCarlos = FuncaoDeCarlos(valorDeX, valorDeY);

                    string ganhador;
                    if(valorDeRafael > valorDeBeto && valorDeRafael > valorDeCarlos)
                    {
                        ganhador = "Rafael ganhou";
                    }
                    else if(valorDeBeto > valorDeCarlos && valorDeBeto > valorDeRafael)
                    {
                        ganhador = "Beto ganhou";
                    }
                    else
                    {
                        ganhador = "Carlos ganhou";
                    }

                    sb.AppendLine(ganhador);
                }
            } 

            Console.Write(sb.ToString());
        }

        double FuncaoDeRafael(int x, int y) => Math.Pow((3 * x), 2) + Math.Pow(y, 2);
        double FuncaoDeBeto(int x, int y) => 2 * Math.Pow(x, 2) + Math.Pow(5 * y, 2);
        double FuncaoDeCarlos(int x, int y) => -100 * x + Math.Pow(y, 3);
    }
}