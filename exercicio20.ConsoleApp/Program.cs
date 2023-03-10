namespace exercicios20.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 20 - Par e ímpar");

            Console.WriteLine("Informe um número qualquer: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par");
            } else
            {
                Console.WriteLine("O número é ímpar");
            }
        }
    }
}