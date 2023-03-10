namespace exercicio12.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 12 - Dimensão de um terreno");

            Console.WriteLine("Informa a largura do terreno: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informa a comprimento do terreno: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"A dimensão do terrno é {largura * comprimento} m²");
        }
    }
}