using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NGangApp.Classes;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NGangApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnsatteListe : ContentPage
    {
        public AnsatteListe()
        {
            InitializeComponent();
        }


        void NyAnsatte_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NyAnsatte());
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection forb = new SQLiteConnection(App.Filepath))
            {
                //opretter en tabel, som skal vises som en liste
                forb.CreateTable<AnsatteDbClass>();
                var ansListe = forb.Table<AnsatteDbClass>().ToList();

                ansatteListView.ItemsSource = ansListe;
            }
        }
    }
}