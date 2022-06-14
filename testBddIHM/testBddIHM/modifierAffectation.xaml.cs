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
        public modifierAffectation()
        {
            InitializeComponent();
            comboBoxDivision.ItemsSource = ApplicationData.listeDivision;
            comboBoxMission.ItemsSource = ApplicationData.listeMission;
        }

        private void Bouton_Valider_Modification(object sender, RoutedEventArgs e)
        {
            Affectation aze = new Affectation(((Mission)comboBoxMission.SelectedItem).NumeroMission, ((Division)comboBoxDivision.SelectedItem).NumeroDivision, ((DateTime)datePickerAffectation.SelectedDate).Date, txtBoxCommentaire.Text.ToString());
            aze.Update();
        }
        private void Bouton_Annuler_Modification(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}