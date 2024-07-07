using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyProgram.MPVM.Pages;

namespace MyProgram.MPVM.ViewModels.Pages
{
    public class TestPageViewModel : ObservableRecipient
    {
        private string _pageTitle;

        public string PageTitle
        {
            get { return _pageTitle; }
            set { SetProperty(ref _pageTitle, value); }
        }

        public TestPageViewModel()
        {
            PageTitle = "Это тестовая страница";
            NavigateToMainPageCommand = new RelayCommand(NavigateToMainPage);
        }

        public IRelayCommand NavigateToMainPageCommand { get; }

        private void NavigateToMainPage()
        {
            var mainWindowViewModel = App.Current.MainWindow.DataContext as MainWindowViewModel;
            if (mainWindowViewModel != null)
            {
                mainWindowViewModel.CurrentPage = new MainPage();
            }
            else
            {
                throw new InvalidOperationException("DataContext окна MainWindow установлен неправильно.");
            }
        }
    }
}
