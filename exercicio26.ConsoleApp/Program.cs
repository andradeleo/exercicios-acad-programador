namespace exercicio26.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 26 - Fatorial");

            int resultado = 0;;

            Console.WriteLine("Informe um número para o cálculo fatorial");
            int numero = int.Parse(Console.ReadLine());

            for ( int i = numero; i >= 1; numero-- )
            {
                Console.Write(i);
                resultado *= i;

                if (i > 1)
                {
                    Console.Write("x");
                }
            }

            Console.Write($" = {resultado}");
        }
                
     }
 }