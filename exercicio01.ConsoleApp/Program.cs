namespace exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 01 - Volume de uma caixa \n\n");

            Console.WriteLine("Informe as dimensões da caixa \n");

            Console.Write("Informe a altura: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe a largura: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe a comprimento: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"\n\n O volume da caixa é {(altura * largura * comprimento)}");
            Console.Read();
        }
    }
}