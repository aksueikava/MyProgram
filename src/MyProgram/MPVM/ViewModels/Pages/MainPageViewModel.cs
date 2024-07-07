using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyProgram.MPVM.Pages;

namespace MyProgram.MPVM.ViewModels.Pages
{
    public class MainPageViewModel : ObservableRecipient
    {
        private string _pageTitle;

        public string PageTitle
        {
            get { return _pageTitle; }
            set { SetProperty(ref _pageTitle, value); }
        }

        public MainPageViewModel()
        {
            PageTitle = "Это главная страница";
            NavigateToTestPageCommand = new RelayCommand(NavigateToTestPage);
        }

        public IRelayCommand NavigateToTestPageCommand { get; }

        private void NavigateToTestPage()
        {
            var mainWindowViewModel = App.Current.MainWindow.DataContext as MainWindowViewModel;
            if (mainWindowViewModel != null)
            {
                mainWindowViewModel.CurrentPage = new TestPage();
            }
            else
            {
                throw new InvalidOperationException("DataContext окна MainWindow установлен неправильно.");
            }
        }
    }
}
