namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int number = int.Parse(Console.ReadLine());

            bool prime = number >= 2;

            for (int i = 2; i * i <= number && prime; i++) 
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }
            Console.WriteLine(prime 
                ? $"{number} é primo."
                : $"{number} não é primo."); //só com booleanos
        }
    }
}