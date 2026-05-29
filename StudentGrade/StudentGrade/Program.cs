namespace StudentGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua nota: ");
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 7)
            {
                Console.WriteLine("Você foi aprovado.");
            }
            else if (grade <= 4)
            {
                Console.WriteLine("Você foi reprovado.");
            }
            else
            {
                Console.WriteLine("Você está de recuperação.");
            }
        }
    }
}
