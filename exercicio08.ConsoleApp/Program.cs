namespace exercicio08.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 08 - Calcular volume lata de óleo");

            Console.WriteLine("Informe a altura da lata ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o raio da lata ");
            decimal raio = Convert.ToDecimal(Console.ReadLine());

            double pi = 3.14;

            decimal resultado = Convert.ToDecimal(pi) * (raio * raio) * altura;

            Console.WriteLine($"O volume da lata é {resultado.ToString("F2")} cm³");
        }
    }
}