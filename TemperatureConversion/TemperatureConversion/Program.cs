namespace TemperatureConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * (1.8)) + 32;

            Console.WriteLine($"A temperatura em Fahrenheit é {fahrenheit} °F.");
        }
    }
}
