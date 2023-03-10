namespace exercicio14.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 14 - Idade em dias");

            Console.Write("Informa sua idade ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Informe o seu nome ");
            string nome = Console.ReadLine();

            Console.WriteLine($"{nome}, VOCÊ JÁ VIVEU {idade * 365} dias");
        }
    }
}