namespace exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 02 - Conversor de Fahrenheit para celcius \n\n");

            Console.Write("Informe a temperatura em Fahrenheit: ");
            decimal temperaturaFahrenheit = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = Convert.ToDecimal((temperaturaFahrenheit - 32) / 1.8m);

            Console.WriteLine($"A temperatura em Celcius é {resultado}");
            Console.ReadLine();
        }
    }
}