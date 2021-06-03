using Application_Graphique.Nos_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;

namespace Application_Graphique
{
    public class Navigator : INotifyPropertyChanged
    {
        private UserControl currentMainUserControl;
        public UserControl CurrentMainUserControl
        {
            get => currentMainUserControl;
            set
            {
                currentMainUserControl = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentMainUserControl"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
