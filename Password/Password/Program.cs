namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string correctPassword = "12345";
            string password;

            do
            {
                Console.Write("Digite o seu usuário: ");
                var user = Console.ReadLine();

                Console.Write("Digite a sua senha: ");
                password = ReadPassword();

                if (password != correctPassword)
                {
                    Console.WriteLine("\nSenha incorreta. Tente novamente.\n");
                }

            } while (password != correctPassword);

            Console.WriteLine("\nSenha correta. Bem-vindo!");

        }
        static string ReadPassword()
        {
            string password = string.Empty;

            while (true)
            {
                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                    break;

                if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password[..^1];
                    Console.Write("\b \b");
                    continue;
                }

                password += key.KeyChar;
                Console.Write("*");
            }

            Console.WriteLine();
            return password;
        }
    }
}
