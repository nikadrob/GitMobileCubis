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
                //new Meni(){ Id=1, Image="https://i.imgur.com/DVQlLFl.png", Opis="MOTORNA VOZILA", Poziv="", Rbr=1 },
                //new Meni(){ Id=2, Image="https://i.imgur.com/Zenvawa.png", Opis="PUTNA OSIGURANJA", Poziv="", Rbr=2 },
                //new Meni(){ Id=3, Image="https://i.imgur.com/z0aMcdY.png", Opis="ŽIVOTNO OSIGURANJE", Poziv="", Rbr=3 },
                //new Meni(){ Id=4, Image="https://i.imgur.com/Plvkgzo.png", Opis="IMOVINA", Poziv="", Rbr=4 },
                //new Meni(){ Id=5, Image="https://i.imgur.com/8nTJpd6.png", Opis="POLJOPRIVREDA", Poziv="", Rbr=5 },
                //new Meni(){ Id=6, Image="https://i.imgur.com/ukCzxWq.png", Opis="TRANSPORT", Poziv="", Rbr=6 }

                new Meni(){ Id=1, Image="https://i.ibb.co/6sXDLbn/motorna-vozila.png", Opis="MOTORNA VOZILA", Poziv="", Rbr=1 },
                new Meni(){ Id=2, Image="https://i.ibb.co/c6ThWgt/putna-osiguranja.png", Opis="PUTNA OSIGURANJA", Poziv="", Rbr=2 },
                new Meni(){ Id=3, Image="https://i.ibb.co/C7HkmT6/zivotno-osiguranje.png", Opis="ŽIVOTNO OSIGURANJE", Poziv="", Rbr=3 },
                new Meni(){ Id=4, Image="https://i.ibb.co/r4BY2gh/imovina.png", Opis="IMOVINA", Poziv="", Rbr=4 },
                new Meni(){ Id=5, Image="https://i.ibb.co/frtj6dg/poljoprivreda.png", Opis="POLJOPRIVREDA", Poziv="", Rbr=5 },
                new Meni(){ Id=6, Image="https://i.ibb.co/80r5vG4/trasnport.png", Opis="TRANSPORT", Poziv="", Rbr=6 }
            };
            return menuList;
        }

        public List<Polica> GetPolice(int id)
        {
            List<Polica> policeList = null;
            switch (id)
            {
                case 1:
                    policeList = new List<Polica>()
                    {
                        new Polica(){Broj="2100001545", Proizvod="AO", Opis="Polica autoodgovornosti", pocDate = new DateTime(2018,05,23), istDate = new DateTime(2019,05,23), Premija= 1234.56m},
                        new Polica(){Broj="2100001545", Proizvod="AO", Opis="Polica autoodgovornosti", pocDate = new DateTime(2018,02,28), istDate = new DateTime(2019,02,28), Premija= 950.10m},
                        new Polica(){Broj="2100001545", Proizvod="AK", Opis="Kasko - motorna vozila", pocDate = new DateTime(2018,05,23), istDate = new DateTime(2019,05,23), Premija= 1234.56m}
                    };
                    break;
                case 2:
                    policeList = new List<Polica>()
                    {
                        new Polica(){Broj="1801-00001545", Proizvod="PZ", Opis="Putno zdravstveno osiguranje", pocDate = new DateTime(2018,07,28), istDate = new DateTime(2019,08,13), Premija= 225.00m}
                    };
                    break;
                case 4:
                    policeList = new List<Polica>()
                    {
                        new Polica(){Broj="08-0000451215", Proizvod="08", Opis="Osiguranje imovine - osiguran dom", pocDate = new DateTime(2018,02,01), istDate = new DateTime(2019,02,01), Premija= 456.20m},
                        new Polica(){Broj="0901-12000045", Proizvod="09", Opis="Osiguranje imovine - poslovni objekt", pocDate = new DateTime(2018,02,28), istDate = new DateTime(2019,02,28), Premija=2245.87m}
                    };
                    break;
            }

            return policeList;
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
