namespace exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 04 - Consumo de combustível \n\n");

            Console.Write("Informe a quilometragem inicial: ");
            int quilometragemInicial = int.Parse(Console.ReadLine());

            Console.Write("Informe a quilometragem no final do percurso: ");
            int quilometragemFinal = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o consumo de combustível (km/L):");
            decimal consumo = Convert.ToDecimal(Console.ReadLine());

            int distancia = quilometragemFinal - quilometragemInicial;
            decimal totalGasto = distancia / consumo;

            Console.WriteLine("O consumo de combustível por km é de: " + (totalGasto / distancia).ToString("F2") + " litros/km");
        }
    }
}