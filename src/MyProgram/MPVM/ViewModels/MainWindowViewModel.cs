﻿namespace MyProgram.MPVM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            Title = "Main Window Title";
        }
    }
}