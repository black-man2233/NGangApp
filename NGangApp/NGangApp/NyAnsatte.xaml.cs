using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using NGangApp.Classes;

namespace NGangApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NyAnsatte : ContentPage
    {
        public NyAnsatte()
        {
            InitializeComponent();
        }

        void gemKnap_Clicked(object sender, EventArgs e)
        {
            AnsatteDbClass ansatte = new AnsatteDbClass()
            {
                Navne = navneEntry.Text,
                Efternavne = efternavneEntry.Text,
                Email = emailEntry.Text,
                TlfNummer = tlfNummerEntry.Text,
                Loen = LoenEntry.Text,
            };

            using (SQLiteConnection forb = new SQLiteConnection(App.Filepath))
            {
                forb.CreateTable<AnsatteDbClass>();
                int antAnsatte = forb.Insert(ansatte);
            }



        }
    }
}