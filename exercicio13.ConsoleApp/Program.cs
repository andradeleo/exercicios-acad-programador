namespace exercicio13.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 13 - Padaria Hotpão");

            double pao = 0.12;
            double broa = 1.50;
            double poupanca = 0.1;

            Console.WriteLine("Informe a quantidade de pães vendidades");
            double quantidadePao = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de broa vendidades");
            double quantidadeBroa = int.Parse(Console.ReadLine());

            decimal quantidadeArrecadado = Convert.ToDecimal(quantidadePao * pao + quantidadeBroa * broa);

            double quantidadePoupanca = Convert.ToDouble(quantidadeArrecadado) * poupanca;

            Console.WriteLine($" A quantidade arrecadado nas vendas foram {quantidadeArrecadado} reais e para poupança foi {quantidadePoupanca} reais");
        }
    }
}