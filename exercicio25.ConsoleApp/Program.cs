namespace exercicios25.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 25 - Tabuada");

            Console.WriteLine("Informe um número para a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"\n {i} x {numero} = {i * numero}");
            }
        }
    }
}