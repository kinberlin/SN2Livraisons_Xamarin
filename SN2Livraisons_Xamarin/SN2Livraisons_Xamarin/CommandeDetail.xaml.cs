using Models;
using Repository;
using SignaturePad.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SN2Livraisons_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommandeDetail : ContentPage
    {

        public Livraison liv = new Livraison();
        public CommandeDetail(Livraison liv)
        {
            InitializeComponent();
            this.liv = liv;
        }
        protected override void OnAppearing()
        {
            Reference.Text = liv.Reference;
            Date.Text = liv.DateHeure.ToString();
            Lieu.Text = liv.Lieu;
            Client.Text = liv.Command.Client;
            Telephone.Text = liv.Command.tel;
            base.OnAppearing();
        }
        private async void BtnEnregistrer_Clicked(object sender, EventArgs e)

        {
            Stream stream = await signature.GetImageStreamAsync(SignatureImageFormat.Jpeg);
            if (stream != null)
            {
                //var Apps = new App();
                liv.Effectuer = true;
                LivraisonRepository.Livraisons.Remove(liv);
                await DisplayAlert("Success", "Save done!", "OK");
                _ = Navigation.PopModalAsync(true);
                //Application.Current.MainPage = new NavigationPage(new MainPage());
            }
        }
        private void BtnAnnuler_Clicked(object sender, EventArgs e){
           Navigation.PopModalAsync(true);
           // Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}