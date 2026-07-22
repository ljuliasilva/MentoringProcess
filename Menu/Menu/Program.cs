using Microsoft.VisualBasic;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1- Olá! ");
            Console.WriteLine("2- Data atual: ");
            Console.WriteLine("3- Sair");
            Console.WriteLine("Escolha uma opção: ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Olá!");
                    break;

                case 2:
                    Console.WriteLine("Data atual: " + DateAndTime.Now.ToShortDateString());
                    break;

                case 3:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        }
    }
}
