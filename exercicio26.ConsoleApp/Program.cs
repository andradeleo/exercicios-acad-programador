namespace exercicio26.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = 1; // Inicializa o resultado com 1, não com 0.

            Console.WriteLine("Informe um número para o cálculo fatorial");
            int numero = int.Parse(Console.ReadLine());

            for (int i = numero; i >= 1; i--) // O loop deve decrementar a variável i, não a variável numero.
            {
                Console.Write(i);
                resultado *= i;

                if (i > 1)
                {
                    Console.Write("x");
                }
            }

            Console.Write($" = {resultado}");
            Console.ReadLine();
        }
                
     }
 }