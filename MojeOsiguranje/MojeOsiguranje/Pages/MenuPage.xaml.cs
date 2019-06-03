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

            if (First)
            {

                ApiMockData apiMock = new ApiMockData();
                var menus = apiMock.GetMenu();

                foreach (var m in menus)
                {
                    Menus.Add(m);
                }

                LvMenu.ItemsSource = Menus;
                BusyIndicator.IsRunning = false;
            }

            First = false;
        }

        private void LvMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenu = (Meni)e.SelectedItem;

            if (selectedMenu != null)
            {
                int iMeni = selectedMenu.Id;
                string xKategorija = selectedMenu.Opis;
                Navigation.PushAsync(new DetailPage(iMeni, xKategorija));
            }

            ((ListView)sender).SelectedItem = null;
        }
    }
}