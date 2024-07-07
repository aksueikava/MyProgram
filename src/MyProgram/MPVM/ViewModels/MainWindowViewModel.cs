using MyProgram.MPVM.Pages;

namespace MyProgram.MPVM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string? _title; // Nullable поле

        public string? Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private object? _currentPage;

        public object? CurrentPage
        {
            get { return _currentPage; }
            set
            {
                if (_currentPage != value)
                {
                    _currentPage = value;
                    OnPropertyChanged(nameof(CurrentPage));
                }
            }
        }

        public MainWindowViewModel()
        {
            Title = "Main Window Title";
            CurrentPage = new MainPage();
        }
    }
}