namespace exercicio29.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 29 - Tabuada");

            for (int i = 1; i <=10 ; i++)
            {
                Console.Write($"\n Tabuada do {i}");
                for (int j = 1; j <=10 ; j++)
                {
                    Console.WriteLine($"\n {i} x {j} = {i * j} ");
                }
            }
            Console.ReadLine();
        }
    }
}