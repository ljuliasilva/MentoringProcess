namespace AverageGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            double grade1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double grade2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            double grade3 = double.Parse(Console.ReadLine());

            double average = (grade1 + grade2 + grade3) / 3;

            Console.WriteLine($"A média final é {average:F1}.");
        }
    }
}