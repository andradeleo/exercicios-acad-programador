namespace exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 05 - Volume de uma esfera \n\n");

            Console.Write("Informe o raio da esfera ");
            decimal raio = Convert.ToDecimal(Console.ReadLine());

            decimal pi = 3.14159m;

            decimal resultado = Convert.ToDecimal((4.0 / 3.0)) * pi * (raio * raio * raio);

            Console.WriteLine($"O volume da  esfera é {resultado.ToString("F2")}");
        }
    }
}