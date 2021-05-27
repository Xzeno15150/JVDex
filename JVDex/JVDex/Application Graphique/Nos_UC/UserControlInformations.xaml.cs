using BibliothèqueApplication;
using Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Application_Graphique.Nos_UC
{
    /// <summary>
    /// Logique d'interaction pour Informations.xaml
    /// </summary>
    public partial class UserControlInformations : UserControl
    {
        public Manager manager = Stub.Load();
        public UserControlInformations()
        {
            InitializeComponent();

            MainGrid.DataContext = manager.JeuSelected;
        }


       //UCinfoNav.UCinfo = "UserControlInformations";
        public string UCinfo
        {
            get { return (string)GetValue(UCinfoProperty); }
            set { SetValue(UCinfoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UCinfo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UCinfoProperty =
            DependencyProperty.Register("UCinfoNav", typeof(string), typeof(UserControl), new PropertyMetadata(0));

    }
    
}
