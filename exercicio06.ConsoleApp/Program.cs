namespace exercicio06.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 02 - Conversor de Celcius para Farenheit \n\n");

            Console.Write("Informe a temperatura em Celcius: ");
            decimal temperaturaCelcius = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = Convert.ToDecimal(temperaturaCelcius * 1.8m + 32);

            Console.WriteLine($"A temperatura em Fahrenheit é {resultado}");
            Console.ReadLine();
        }
    }
}