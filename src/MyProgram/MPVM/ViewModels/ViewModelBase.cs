using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyProgram.MPVM.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged; // nullable reference
        //public event PropertyChangedEventHandler PropertyChanged = delegate { }; // избежание null-reference исключений

        //protected void OnPropertyChanged([CallerMemberName] string propertyName = null) // null в месте, где ожидается ненулевое значение
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}