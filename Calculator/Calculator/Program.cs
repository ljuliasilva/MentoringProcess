namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.WriteLine("Digite a operação que deseja realizar: ");
            int operation = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro número: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double number2 = double.Parse(Console.ReadLine());

            double result = 0;

            if (operation == 1)
            {
                result = Sum(number1, number2);
                Console.WriteLine($"O resultado é: {result}");
            }
            else if (operation == 2)
            {
                result = Subtract(number1, number2);
                Console.WriteLine($"O resultado é: {result}");
            }
            else if (operation == 3)
            {
                result = Multiply(number1, number2);
                Console.WriteLine($"O resultado é: {result}");
            }
            else if (operation == 4)
            {
                result = Divide(number1, number2);
                Console.WriteLine($"O resultado é: {result}");
            }
            else
            {
                Console.WriteLine("Saindo...");
            }
        }
        static double Sum(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }
        static double Subtract(double num1, double num2)
        {
            double sub = num1 - num2;
            return sub;
        }
        static double Multiply(double num1, double num2)
        {
            double multiply = num1 * num2;
            return multiply;
        }
        static double Divide(double num1, double num2)
        {
            double divide = num1 / num2;
            return divide;
        }
    }
}
