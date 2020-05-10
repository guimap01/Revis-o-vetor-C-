using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace problema1seção6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quantos quartos serão alugados");
            int quartos = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Hotel[] hotel = new Hotel[quartos];

            for (int i = 0; i < hotel.Length; i++)
            {
                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o e-mail: ");
                string email = Console.ReadLine();
                Console.Write("Informe o quarto desejado (0 a 9): ");
                int quarto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                hotel[i] = new Hotel(nome, email, quarto);
            }

            Console.WriteLine("Quartos alugados:");
            for (int i = 0; i < hotel.Length; i++)
            {
                Console.WriteLine(hotel[i]);
            }
        }
    }
}
