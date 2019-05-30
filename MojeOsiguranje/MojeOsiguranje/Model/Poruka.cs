using System;
using System.Collections.Generic;
using System.Text;

namespace MojeOsiguranje.Model
{
    public class Poruka
    {
        public int Id { get; set; }

        public string Naziv { get; set; }

        public string Tekst { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }

        public string Datum { get; set; }

        public string Vrijeme { get; set; }
    }
}
