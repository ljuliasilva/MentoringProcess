namespace Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra: ");
            string word = Console.ReadLine()!.ToLower();
            int wordQuantity = 0;

            foreach (char letter in word)
            {
                if ("aeiou".Contains(letter))
                {
                    wordQuantity++;
                }
            }
            Console.WriteLine($"A sua palavra possui {wordQuantity} vogais.");
        }
    }
}
