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
                new Meni(){ Id=1, Image="https://i.imgur.com/DVQlLFl.png", Opis="MOTORNA VOZILA", Poziv="", Rbr=1 },
                new Meni(){ Id=2, Image="https://i.imgur.com/Zenvawa.png", Opis="PUTNA OSIGURANJA", Poziv="", Rbr=2 },
                new Meni(){ Id=3, Image="https://i.imgur.com/z0aMcdY.png", Opis="ŽIVOTNO OSIGURANJE", Poziv="", Rbr=3 },
                new Meni(){ Id=4, Image="https://i.imgur.com/Plvkgzo.png", Opis="IMOVINA", Poziv="", Rbr=4 },
                new Meni(){ Id=5, Image="https://i.imgur.com/8nTJpd6.png", Opis="POLJOPRIVREDA", Poziv="", Rbr=5 },
                new Meni(){ Id=6, Image="https://i.imgur.com/ukCzxWq.png", Opis="TRANSPORT", Poziv="", Rbr=6 }
            };
            return menuList;
        }

        public List<Podmeni> GetPodMenu(int id)
        {
            List<Podmeni> podMenuList = null;
            switch (id)
            {
                case 1:
                    podMenuList = new List<Podmeni>()
                    {
                        new Podmeni(){ Id=1, Image="", NadMeni=1, Opis="", Poziv=""},
                        new Podmeni(){ Id=2, Image="", NadMeni=1, Opis="", Poziv=""},
                        new Podmeni(){ Id=3, Image="", NadMeni=1, Opis="", Poziv=""}
                    };
                    break;
                case 2:
                    podMenuList = new List<Podmeni>()
                    {
                        new Podmeni(){ Id=4, Image="", NadMeni=2, Opis="", Poziv=""},
                        new Podmeni(){ Id=5, Image="", NadMeni=2, Opis="", Poziv=""},
                        new Podmeni(){ Id=6, Image="", NadMeni=2, Opis="", Poziv=""}
                    };
                    break;
                case 3:
                    podMenuList = new List<Podmeni>()
                    {
                        new Podmeni(){ Id=7, Image="", NadMeni=3, Opis="", Poziv=""},
                        new Podmeni(){ Id=8, Image="", NadMeni=3, Opis="", Poziv=""},
                        new Podmeni(){ Id=9, Image="", NadMeni=3, Opis="", Poziv=""}
                    };
                    break;
                case 4:
                    podMenuList = new List<Podmeni>()
                    {
                        new Podmeni(){ Id=10, Image="", NadMeni=4, Opis="", Poziv=""},
                        new Podmeni(){ Id=11, Image="", NadMeni=4, Opis="", Poziv=""},
                        new Podmeni(){ Id=12, Image="", NadMeni=4, Opis="", Poziv=""}
                    };
                    break;
            }


            return podMenuList;
        }
    }
}
