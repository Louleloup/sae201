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
    /// Logique d'interaction pour modifierAffectation.xaml
    /// </summary>
    public partial class modifierAffectation : Window
    {
        private MainWindow MainWindow;
        private selectionneAffectation selectionneAffectation;
        private int numD;
        private int numM;
        private DateTime date;
        private string commentaire;

        public modifierAffectation()
        {
            ApplicationData.loadApplicationData();
            InitializeComponent();
            comboBoxDivision.ItemsSource = ApplicationData.listeDivision;
            comboBoxMission.ItemsSource = ApplicationData.listeMission;
        }

        public modifierAffectation(MainWindow MainWindow, selectionneAffectation selectionneAffectation, int numD, int numM, DateTime date, string commentaire)
        {
            ApplicationData.loadApplicationData();
            InitializeComponent();
            comboBoxDivision.ItemsSource = ApplicationData.listeDivision;
            comboBoxMission.ItemsSource = ApplicationData.listeMission;
            this.numD = numD;
            this.numM = numM;
            this.date = date;
            this.commentaire = commentaire;
            this.selectionneAffectation = selectionneAffectation;
            this.MainWindow = MainWindow;
        }

        private void Bouton_Valider_Modification(object sender, RoutedEventArgs e)
        {
            Affectation aze = new Affectation(numD, numM, date, commentaire);       

            if (comboBoxMission.SelectedItem != null && comboBoxDivision.SelectedItem != null && datePickerAffectation.SelectedDate != null)
            {
                aze.Update(((Mission)comboBoxMission.SelectedItem).NumeroMission, ((Division)comboBoxDivision.SelectedItem).NumeroDivision, ((DateTime)datePickerAffectation.SelectedDate).Date, txtBoxCommentaire.Text.ToString());
                Close();
                selectionneAffectation.refresh();
                MainWindow.refresh();
            }
            else
                MessageBox.Show("Veuillez remplir correctement le formulaire de modification !", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void Bouton_Annuler_Modification(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}