namespace exercicios19.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios 19 - IMC");

            Console.WriteLine("Informe o seu peso: ");
            int peso = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua altura");
            double altura = double.Parse(Console.ReadLine());

            double resultado = calcularIMC(peso, altura);

            if ( resultado < 18.5 )
            {
                Console.WriteLine("Abaixo do peso");
            } 
            else if ( resultado > 18.6 && resultado < 24.9)
            {
                Console.WriteLine("Peso ideal");
            }
            else if (resultado > 18.6 && resultado < 24.9)
            {
                Console.WriteLine("Peso ideal");
            }
            else if (resultado > 25 && resultado < 29.9)
            {
                Console.WriteLine("Levemente em cima do peso");
            }
            else if (resultado > 30 && resultado < 34.9)
            {
                Console.WriteLine("Obesidade grau I");
            }
            else if (resultado > 35 && resultado < 39.9)
            {
                Console.WriteLine("Obesidade grau II (severa)");
            }
            else if (resultado > 40)
            {
                Console.WriteLine("Obesidade grau III (mórbida");
            }

        }

        public static double calcularIMC(int peso, double altura)
        {
            return Convert.ToDouble(peso / (Math.Pow(altura, 2)));
        }
    }
}