using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Input;
using glitched_out_website_manager.Commands;
using glitched_out_website_manager.Views;

namespace glitched_out_website_manager.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public UserControl? CurrentEditor
        {
            get { return _currentEditor; }
            set { _currentEditor = value;  }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public RelayCommand ShowShowsCommand { get; }

        private UserControl _currentEditor = null;

        public MainWindowViewModel()
        {
            CurrentEditor = null;

            ShowShowsCommand = new RelayCommand(OpenShowsEditor);

        }

        private void OpenShowsEditor()
        {
            CurrentEditor = new ShowsView();
        }


    }
}
