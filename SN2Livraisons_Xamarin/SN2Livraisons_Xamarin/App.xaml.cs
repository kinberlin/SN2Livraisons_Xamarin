using Models;
using Newtonsoft.Json;
using Repository;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SN2Livraisons_Xamarin
{
    public partial class App : Application
    {
        public static List<Livraison> livraisons = null;
        public LivraisonRepository repo = new LivraisonRepository();
        public App()

        {
            var json = SecureStorage.GetAsync("Livraisons").Result;
            if (!string.IsNullOrEmpty(json)){
                var defaultlivs = JsonConvert.DeserializeObject<List<Livraison>>(json);
                livraisons = defaultlivs.FindAll(x => x.Effectuer == false);
            }
            else{
               //repo ;
                livraisons = LivraisonRepository.Livraisons;
            }
            Xamarin.Forms.DataGrid.DataGridComponent.Init();
            InitializeComponent();
            MainPage = new MainPage();
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
