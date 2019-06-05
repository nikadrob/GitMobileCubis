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
    public partial class MessagePage : ContentPage
    {
        public ObservableCollection<Poruka> Poruke;

        public MessagePage()
        {
            InitializeComponent();
        }

        public MessagePage(int Id, string pAkcija)
        {
            InitializeComponent();

            if(pAkcija != "")
            {
                DisplayPoruka(Id, pAkcija);
            }
            
        }

        private void DisplayPoruka(int Id, string pAkcija)
        {
            ApiMockData apiMock = new ApiMockData();
            var police = apiMock.GetPolice(Id);

            if (police != null)
            {
                var p = police.FirstOrDefault();
                EntName.Text = p.UgoNaz;
                EntEmail.Text = p.UgoEmail;
                EntTema.SelectedIndex = pAkcija.ToUpper() == "IZMJENA" ? 0 : 1;
                StringBuilder sb = new StringBuilder();
                sb.Append(pAkcija.ToUpper() == "IZMJENA" ? "Izmjena police broj " : "Prijava štete po polici broj ");
                sb.Append(p.Broj);
                sb.Append("\n");
                sb.Append("Navedite detalje:");
                sb.Append("\n");
                EntEditor.Text = sb.ToString();
            }
        }

        private void BtnBookTable_OnClicked(object sender, EventArgs e)
        {
            Poruke = new ObservableCollection<Poruka>();
        }
    }
}