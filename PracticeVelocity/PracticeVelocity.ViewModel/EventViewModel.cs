using GalaSoft.MvvmLight.Command;
using PracticeVelocity.Model;
using System;
using System.ComponentModel;

namespace PracticeVelocity.ViewModel
{
    public class EventViewModel : INotifyPropertyChanged
    {
        // Event to display
        private Event displayEvent;
        public Event DisplayEvent
        {
            get { return displayEvent; }
            set
            {
                displayEvent = value;
                RaisePropertyChanged("DisplayEvent");
            }
        }

        #region RegisterCommand

        private RelayCommand registerCommand;
        public RelayCommand RegisterCommand
        {
            get { return registerCommand ?? (registerCommand = new RelayCommand(Register)); }
        }

        void Register()
        {
            DisplayEvent = new RegisterEvent();
        }

        #endregion

        #region Diagnose Command

        private RelayCommand diagnoseCommand;
        public RelayCommand DiagnoseCommand
        {
            get { return diagnoseCommand ?? (diagnoseCommand = new RelayCommand(Diagnose)); }
        }

        private void Diagnose()
        {
            DisplayEvent = new DiagnoseEvent();
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}