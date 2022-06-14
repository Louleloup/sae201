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
    /// Logique d'interaction pour supprimerAffectation.xaml
    /// </summary>
    public partial class supprimerAffectation : Window
    {
        public supprimerAffectation()
        {
            ApplicationData.loadApplicationData();
            InitializeComponent();
            listviewAffectationDivision.ItemsSource = ApplicationData.listeAffectation;
        }

        private void Bouton_Supprimer(object sender, RoutedEventArgs e)
        {
            foreach(Affectation c in this.listviewAffectationDivision.SelectedItems)
            {
                c.Delete();
            }
        }
    }
}
