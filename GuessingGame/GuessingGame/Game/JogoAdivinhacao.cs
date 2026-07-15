namespace GuessingGame.Game
{
    public class JogoAdivinhacao
    {
        private readonly int numeroSecreto;
        private int tentativas;
        private readonly Random aleatorio;

        public JogoAdivinhacao()
        {
            aleatorio = new Random();
            numeroSecreto = aleatorio.Next(1, 101);
            tentativas = 0;
        }

        public void Iniciar()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("      JOGO DA ADIVINHAÇÃO");
            Console.WriteLine("==================================");
            Console.WriteLine("Dê o seu palpite de 1 a 100");

            bool acertou = false;

            while (!acertou)
            {
                Console.WriteLine("Digite um número: ");
                int palpite = int.Parse(Console.ReadLine());

                tentativas++;

                if (palpite == numeroSecreto)
                {
                    Console.WriteLine("Parabéns!");
                    Console.WriteLine($"O número secreto é {numeroSecreto}");
                    Console.WriteLine($"Seu número de tentativas foi {tentativas}");
                    acertou = true;
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior!");
                }
                else
                {
                    Console.WriteLine("O número secreto é menor!");
                }
            }
        }
    }
}
