namespace exercicio21.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 21 - Condicional");

            int C;

            Console.WriteLine("Informe o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            if (primeiroNumero == segundoNumero)
            {
                C = primeiroNumero + segundoNumero;
                Console.WriteLine($"Valores iguais, a soma deles é {C}");
            } else
            {
                C = primeiroNumero * segundoNumero;
                Console.WriteLine($"Valores diferentes, a multiplicação é {C}");
            }
        }
    }
}