namespace exercicio24.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 24 - Imprimir números");

            int numerosImpares = 0;

            for (int i = 1; i<=500; i += 2)
            {
                if( i % 3 == 0  )
                {
                    numerosImpares += i;
                    Console.WriteLine($"{numerosImpares}");
                }
            }
        }
    }
}