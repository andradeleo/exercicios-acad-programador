namespace exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 03 - Volume de um cilindros \n\n");

            Console.WriteLine("Informe a altura do cilindro ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o raio do cilindro ");
            decimal raio = Convert.ToDecimal(Console.ReadLine());

            decimal pi = 3.14m;

            decimal resultado = pi * (raio * raio) * altura;

            Console.WriteLine($"O volume do cilindro é {resultado}");
        }
    }
}