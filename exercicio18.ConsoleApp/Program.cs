namespace exercicio18.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exercíco 18 - Número decrescente");

            int menorValor, medioValor, maiorValor;

            Console.WriteLine("Informe o primero valor: ");
            int primeiroValor = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            int segundoValor = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor: ");
            int terceiroValor = int.Parse(Console.ReadLine());

            if (primeiroValor == segundoValor && primeiroValor == terceiroValor && segundoValor == terceiroValor)
            {
                Console.WriteLine("Todos os valores são iguais");
                return;
            }

   

        }
    }
}