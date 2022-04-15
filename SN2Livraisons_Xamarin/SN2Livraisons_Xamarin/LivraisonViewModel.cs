using Models;
using Repository;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SN2Livraisons_Xamarin
{
   public class LivraisonViewModel : INotifyPropertyChanged
    {
        public List<Livraison> _Livraisons;
        private Livraison _selectedLivraison;
        private bool _isRefreshing;

        public List<Livraison> Livraisons
        {
            get
            {
                _Livraisons = LivraisonRepository.Livraisons.FindAll(x => x.Effectuer == false);
                return _Livraisons;
            }
            set
            {
                _Livraisons = value;
                OnPropertyChanged(nameof(Livraisons));
            }
        }
        public Livraison SelectedProfesstional
        {
            get
            {
                Application.Current.MainPage = new NavigationPage(new CommandeDetail(_selectedLivraison));
                return _selectedLivraison;
            }
            set
            {
                _selectedLivraison = value;
                OnPropertyChanged(nameof(SelectedProfesstional));
            }
        }

        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        public ICommand RefreshCommand { get; set; }

        public LivraisonViewModel()
        {
            LivraisonRepository liv = new LivraisonRepository();
            // Livraisons = liv.Livraisons;
            Livraisons = LivraisonRepository.Livraisons;
            RefreshCommand = new Command(CmdRefresh);
        }

        private async void CmdRefresh()
        {
            IsRefreshing = true;
            await Task.Delay(3000);
            IsRefreshing = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}  
