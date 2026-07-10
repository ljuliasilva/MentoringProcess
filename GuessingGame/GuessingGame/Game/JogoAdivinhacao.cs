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
            Console.WriteLine("Dê o seu palpite de 1 a 100: ");

            bool acertou = false;

            while (acertou)
            {
            }
        }
    }
}
