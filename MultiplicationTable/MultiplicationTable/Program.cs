namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTabuada do {num}: ");

            for (int i = 1; i < 11; i++)
            {
                int result = num * i;
                Console.WriteLine($"{num} x {i} = {result}");
            }
        }
    }
}
