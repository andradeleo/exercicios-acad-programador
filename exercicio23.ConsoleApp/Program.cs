namespace exercicio23.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios 23 - Números Ímpares entre 100 e 200");

            for (int i = 100; i <= 200; i++)
            {   
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}