using System;
using System.Collections.Generic;
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
        public MessagePage()
        {
            InitializeComponent();
        }

        private async void BtnBookTable_OnClicked(object sender, EventArgs e)
        {
        }
    }
}