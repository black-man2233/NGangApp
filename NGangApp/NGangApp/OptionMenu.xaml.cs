using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NGangApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OptionMenu : TabbedPage
    {
        public OptionMenu()
        {
            InitializeComponent();
        }

        private async void SendTilAnsatteListe(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new AnsatteListe()));
        }

        private async void SendTilLommeregner(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Lommeregner()));
        }


    }
}