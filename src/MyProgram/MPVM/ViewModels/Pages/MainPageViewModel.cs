using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyProgram.MPVM.Pages;

namespace MyProgram.MPVM.ViewModels.Pages
{
    public class MainPageViewModel : ObservableRecipient
    {
        private string _pageTitle = string.Empty;

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
            if (App.Current.MainWindow.DataContext is MainWindowViewModel mainWindowViewModel)
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
