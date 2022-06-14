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
using System.Windows.Shapes;

namespace testBddIHM
{
    /// <summary>
    /// Logique d'interaction pour selectionneAffectation.xaml
    /// </summary>
    public partial class selectionneAffectation : Window
    {
        public selectionneAffectation()
        {
            InitializeComponent();
            listviewAffectationDivision.ItemsSource = ApplicationData.listeAffectation;
            refresh();
        }
        public void refresh()
        {
            ApplicationData.loadApplicationData();
            InitializeComponent();
            listviewAffectationDivision.ItemsSource = ApplicationData.listeAffectation;
        }
        private void Bouton_Modifier(object sender, RoutedEventArgs e)
        {
            Window pageDonneeModifAffectation = new modifierAffectation();
            pageDonneeModifAffectation.Show();
        }
        private void Bouton_Annuler(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
