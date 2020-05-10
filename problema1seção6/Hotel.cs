using System;
using System.Collections.Generic;
using System.Text;

namespace problema1seção6
{
    class Hotel
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public int Quarto { get; set; }
        public Hotel(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return Quarto + ": " + Nome + ", " + Email;
        }
    }
}
