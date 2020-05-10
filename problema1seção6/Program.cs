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

            Hotel[] hotel = new Hotel[10];

            for (int i = 0; i < quartos; i++)
            {
                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o e-mail: ");
                string email = Console.ReadLine();
                Console.Write("Informe o quarto desejado (0 a 9): ");
                int quarto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                hotel[quarto] = new Hotel(nome, email);
            }

            Console.WriteLine("Quartos alugados:");
            for (int i = 0; i < hotel.Length; i++)
            {
                if (hotel[i] != null)
                    Console.WriteLine("Quarto: " + i + " " + hotel[i]);
            }
        }
    }
}
