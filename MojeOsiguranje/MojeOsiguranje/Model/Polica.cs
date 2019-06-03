using System;
using System.Collections.Generic;
using System.Text;

namespace MojeOsiguranje.Model
{
    public class Polica
    {
        public string Broj { get; set; }

        public string Proizvod { get; set; }

        public string Opis { get; set; }

        public DateTime pocDate { get; set; }

        public DateTime istDate { get; set; }

        public decimal Premija { get; set; }
    }
}
