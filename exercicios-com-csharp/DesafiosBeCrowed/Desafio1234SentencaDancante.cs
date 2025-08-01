namespace Programacao.Desafios
{
    internal class Desafio1234SentencaDancante : IDesafioComand
    {
        public void Executar()
        {

            string linha;
            while((linha = Console.ReadLine()!) != null)
            {
                bool letraMaiuscula = false;
                for(int i = 0; i < linha.Length; i++)
                {
                    string letra = linha[i].ToString();

                    if (letra == " ")
                    {
                        Console.Write(" ");
                        continue;
                    }


                    if (i == 0)
                    {
                        Console.Write(letra.ToUpper());
                        letraMaiuscula = true;
                        continue;
                    }

                    if (letraMaiuscula)
                    {
                        Console.Write(letra.ToLower());
                        letraMaiuscula = false;
                    }
                    else
                    {
                        Console.Write(letra.ToUpper());
                        letraMaiuscula = true;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
