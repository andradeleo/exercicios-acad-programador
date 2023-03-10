namespace exercicio10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 10 - Média ponderada");

            Console.Write("Informe a primeira nota:  ");
            decimal primeiraNota = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe a segunda nota:  ");
            decimal segundaNota = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o peso da primeira nota:  ");
            decimal primeiroPeso = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o peso da segunda nota:  ");
            decimal segundoPeso = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = ((primeiraNota * primeiroPeso) + (segundaNota * segundoPeso)) / (primeiroPeso + segundoPeso);

            Console.WriteLine($"A média ponderada do aluno é: {resultado}");
        }
    }
}