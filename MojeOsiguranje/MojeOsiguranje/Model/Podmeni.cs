using System;
using System.Collections.Generic;
using System.Text;

namespace MojeOsiguranje.Model
{
    public class Podmeni
    {
        public int Id { get; set; }

        public string Poziv { get; set; }

        public string Opis { get; set; }

        public string Image { get; set; }

        public int NadMeni { get; set; }
    }
}
