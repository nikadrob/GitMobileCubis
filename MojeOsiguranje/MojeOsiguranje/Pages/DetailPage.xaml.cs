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
    public partial class DetailPage : ContentPage
    {
        public ObservableCollection<Polica> Police;
        //public static bool First = true;

        public DetailPage(int Id, string pKategorija)
        {
            InitializeComponent();
            Police = new ObservableCollection<Polica>();

            //if (First)
            //{
                DisplayPolice(Id, pKategorija);
            //}

            //First = false;

            BusyIndicator.IsVisible = false;
        }

        private void DisplayPolice(int Id, string xKategorija)
        {
            LvDetail.ItemsSource = null;

            ApiMockData apiMock = new ApiMockData();
            var police = apiMock.GetPolice(Id);

            if (police == null)
            {
                mainStack.IsVisible = false;
                noDataStack.IsVisible = true;

                lblNoData.Text = xKategorija;
            }
            else
            {
                mainStack.IsVisible = true;
                noDataStack.IsVisible = false;

                foreach (var p in police)
                {
                    Police.Add(p);
                    
                }

                LvDetail.ItemsSource = Police;
            }
        }
    }
}