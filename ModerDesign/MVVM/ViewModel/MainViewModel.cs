using ModerDesign.Core;

namespace ModerDesign.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewcommand { get; set; }

        public HomeViewModel HomeViewModel { get; set; }
        public DiscoveryViewModel DiscoveryViewModel { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value; 
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeViewModel= new HomeViewModel();
            DiscoveryViewModel= new DiscoveryViewModel();

            CurrentView= HomeViewModel;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeViewModel;
            });

            DiscoveryViewcommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryViewModel;
            });
        }
    }
}
