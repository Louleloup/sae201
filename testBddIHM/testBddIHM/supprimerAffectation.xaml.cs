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
        private MainWindow premiereFenetre;

        public supprimerAffectation()
        {
        }

        public supprimerAffectation(MainWindow premiereFenetre)
        {
            this.premiereFenetre = premiereFenetre;
            ApplicationData.loadApplicationData();
            InitializeComponent();
            listviewAffectationDivision.ItemsSource = ApplicationData.listeAffectation;
        }
        public void refresh()
        {
            ApplicationData.loadApplicationData();
            InitializeComponent();
            listviewAffectationDivision.ItemsSource = ApplicationData.listeAffectation;
        }

        private void Bouton_Supprimer(object sender, RoutedEventArgs e)
        {
            MessageBoxResult validSuppression = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette affectation ?", "Supression", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (validSuppression == MessageBoxResult.Yes)
            {
                //do the suppr
                if (listviewAffectationDivision.SelectedItem is null)
                {
                    MessageBox.Show("Vous n'avez sélectionné aucune ligne", "Supression", MessageBoxButton.OK, MessageBoxImage.Error);

                }
                else
                {
                    foreach (Affectation lesAffectation in listviewAffectationDivision.SelectedItems)
                    {
                        lesAffectation.Delete();
                    }
                }
            }
            refresh();
            premiereFenetre.refresh();
        }

        private void Bouton_Annuler(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
