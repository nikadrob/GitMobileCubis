using MojeOsiguranje.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MojeOsiguranje.Service
{
    class ApiMockData
    {
        public List<Meni> GetMenu()
        {
            List<Meni> menuList = new List<Meni>()
            {
                new Meni(){ Id=1, Image="", Opis="abc", PodmeniId = 1, Poziv="", Rbr=1 },
                new Meni(){ Id=2, Image="", Opis="abc", PodmeniId = 1, Poziv="", Rbr=2 },
                new Meni(){ Id=3, Image="", Opis="abc", PodmeniId = 1, Poziv="", Rbr=3 },
                new Meni(){ Id=4, Image="", Opis="abc", PodmeniId = 1, Poziv="", Rbr=4 }
            };
            return menuList;
        }

        public List<Podmeni> GetPodMenu()
        {
            List<Podmeni> podMenuList = new List<Podmeni>()
            {

            };
            return podMenuList;
        }
    }
}
