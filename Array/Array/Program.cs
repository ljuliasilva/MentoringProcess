namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarArray();

            MaiorNumero();
        }

        static void MostrarArray()
        {
            int[] numeros = { 5, 10, 15, 20, 25 };

            Console.WriteLine("Números do array: ");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine();
        }

        static void MaiorNumero()
        {
            int[] numeros = { 4, 8, 12, 16, 20 };

            int maior = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }
            Console.WriteLine("O maior número é: " + maior);
        }

    }
}
