using MojeOsiguranje.Model;
using MojeOsiguranje.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MojeOsiguranje.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public ObservableCollection<Meni> Menus;
        public static bool First = true;

        public MenuPage()
        {
            InitializeComponent();
            Menus = new ObservableCollection<Meni>();

            //ApiMockData apiData = new ApiMockData();
            //var menus = apiData.GetMenu();
            //foreach(var m in menus)
            //{
            //    Menus.Add(m);
            //}
            //LvMenu.ItemsSource = Menus;
            if (First)
            {
                ApiMockData apiMock = new ApiMockData();
                var menus = apiMock.GetMenu();

                foreach (var m in menus)
                {
                    Menus.Add(m);
                }

                LvMenu.ItemsSource = Menus;
                //BusyIndicator.IsRunning = false;
            }

            First = false;
        }


    }
}