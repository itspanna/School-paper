using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel;
using School_paper.Command;
using System.Data;
using System.Runtime.CompilerServices;

namespace School_paper.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private object currentView;

        public object CurrentView
        {
            get { return currentView; }
            set { currentView = value; OnPropertyChanged(); }
        }

        HomeView homeView;
        TaskOneView taskOneView;
        DataView dataView;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Relaycommand openHome { get; }
        public Relaycommand TaskOneView { get; }
        public Relaycommand DataView { get; }

        public MainViewModel()
        {
            homeView = new HomeView();
            taskOneView = new TaskOneView();
            dataView = new DataView();

            openHome = new Relaycommand(X => CurrentView = homeView);
            TaskOneView = new Relaycommand(X => CurrentView = taskOneView);
            DataView = new Relaycommand(X => CurrentView = dataView);

            CurrentView = homeView;
        }
        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
