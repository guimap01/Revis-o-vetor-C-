﻿using System;
using System.Collections.Generic;
using System.Text;

namespace problema1seção6
{
    class Hotel
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        
        public Hotel(string nome, string email)
        {
            Nome = nome;
            Email = email;
          
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
