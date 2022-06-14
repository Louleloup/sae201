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
        private MainWindow premiereFenetre;

        public selectionneAffectation()
        { }

        public selectionneAffectation(MainWindow premiereFenetre)
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
        private void Bouton_Modifier(object sender, RoutedEventArgs e)
        {
            Affectation a = (Affectation)listviewAffectationDivision.SelectedItem;
            Window pageDonneeModifAffectation = new modifierAffectation(premiereFenetre, this, a.NumeroD, a.NumeroM, a.Date, a.Commentaire);
            
            if (listviewAffectationDivision.SelectedItem is null)
            {
                MessageBox.Show("Vous n'avez sélectionné aucune ligne", "Modification", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                pageDonneeModifAffectation.Show();
            }
        }
        private void Bouton_Annuler(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
