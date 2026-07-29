namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem-vindo(a) ao sistema bancário!\n");
            Console.Write("Digite o nome do titular da conta: ");

            BankAccount account = new BankAccount(Console.ReadLine());

            bool operation = true;

            while (operation)
            {

                Console.WriteLine("\n1 - Ver saldo");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Sacar");
                Console.WriteLine("4 - Sair\n");
                Console.Write("Escolha uma opção: ");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            double balance = account.GetBalance();
                            Console.WriteLine($"Seu saldo é: R${balance}");
                            break;
                        }

                    case 2:
                        {
                            Console.Write("Digite a quantia que deseja depositar: ");
                            double amount = double.Parse(Console.ReadLine());
                            account.Deposit(amount);
                            Console.WriteLine("Depósito realizado!");
                            break;
                        }

                    case 3:
                        {
                            Console.Write("Digite a quantia que deseja sacar: ");
                            double amount = double.Parse(Console.ReadLine());
                            account.Withdraw(amount);
                            Console.WriteLine("Saque realizado!");
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("\nAté a próxima!");
                            operation = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Opção inválida");
                            break;
                        }
                }

            }
        }
    }
}
