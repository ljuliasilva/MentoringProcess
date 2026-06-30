namespace FactorNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int number = int.Parse(Console.ReadLine()!);

            long factor = 1;

            for (int i = 1; i <= number; i++)
            {
                factor *= i;
            }

            Console.WriteLine($"O resultado de {number}! é {factor}.");
        }
    }
}