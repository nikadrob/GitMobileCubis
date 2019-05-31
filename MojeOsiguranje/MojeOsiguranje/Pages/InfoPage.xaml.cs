using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MojeOsiguranje.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private void TapFacebook_OnTapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/dunavinsurance"));
        }

        private void TapTwitter_OnTapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://twitter.com/osigurani"));
        }

        private void TapInstagram_OnTapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.instagram.com/dunavosiguranje/"));
        }

        private void TapLinkedIn_OnTapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.linkedin.com/company/kompanija-dunav-osiguranje-ado"));
        }

        private void TapYoutube_OnTapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.youtube.com/user/DunavInsurance/videos?view=0"));
        }

        private void TapCall_OnTapped(object sender, EventArgs e)
        {
            //PhoneDialer.Open("996545231232");
        }
    }
}
