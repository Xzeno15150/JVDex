﻿using BibliothèqueApplication;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Application_Graphique
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager manager = Stub.Load();
            ListBox_ListeJeu.DataContext = manager;
            TextBoxRecherche.DataContext = manager;
        }

        private void ListBoxListeJeux_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void ButtonRecherche_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBoxRecherche_LostFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
