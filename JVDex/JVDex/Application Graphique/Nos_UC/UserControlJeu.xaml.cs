﻿using BibliothèqueApplication;
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
    /// Logique d'interaction pour UserControlJeu.xaml
    /// </summary>
    public partial class UserControlJeu : UserControl
    {
        public Manager manager = Stub.Load();
        
        public UserControlJeu()
        {
            InitializeComponent();
            ImageJeu.DataContext = manager.JeuSelected;
        }

        public string ImagePath
        {
            set
            {
                ImageJeu.Source = new BitmapImage(new Uri(value, UriKind.Relative));  //ça sert à quoi?
            }
        }

        public string NomJeu
        {
            set
            {
                NomDuJeu.Text = value;
            }
        }
    }
}
