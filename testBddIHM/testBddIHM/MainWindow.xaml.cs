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

namespace testBddIHM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            ApplicationData.loadApplicationData();
            InitializeComponent();
            //listviewGroupes.ItemsSource = ApplicationData.listeGroupes;
            listviewCorpDArmee.ItemsSource = ApplicationData.listeCorpDArmee;
            listviewDivision.ItemsSource = ApplicationData.listeDivision;
            listviewMission.ItemsSource = ApplicationData.listeMission;
            comboBoxDivision.ItemsSource = ApplicationData.listeDivision;
            comboBoxMission.ItemsSource = ApplicationData.listeMission;
            listviewAffectationDivision.ItemsSource = ApplicationData.listeAffectation;
        }

        private void Bouton_Valider(object sender, RoutedEventArgs e)
        {
            //division = comboBoxDivision.Items[0].ToString();
            DataAccess insert = new DataAccess();

            Mission mission;
            DateTime date;
            Division division;
            String commentaire;

            mission = (Mission)comboBoxMission.SelectedItem;
            date = (DateTime)datePickerAffectation.SelectedDate;
            division = (Division)comboBoxDivision.SelectedItem;
            commentaire = txtBoxCommentaire.Text.ToString();

            labeltest.Content = mission.NumeroMission + " " + date.ToShortDateString() + " " + division.NumeroDivision + " " + commentaire;
            
            Affectation aze = new Affectation(((Mission)comboBoxMission.SelectedItem).NumeroMission, ((Division)comboBoxDivision.SelectedItem).NumeroDivision, ((DateTime)datePickerAffectation.SelectedDate).Date, txtBoxCommentaire.Text.ToString());
            aze.Create();
            /*
             mission = new mission()
                        if(date < DateTime.Today)
                        {
                            MessageBox.Show("Veuillez renseigner la date correctement !", "Erreur !", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            insert.setData($"INSERT INTO AFFECTE_A VALUES({division.NumeroDivision}, {mission.NumeroMission}, '{date.ToShortDateString()}', '{commentaire}')");

                            Affectation uneAffectation = new Affectation();
                            listviewAffectationDivision.ItemsSource = uneAffectation.FindAll();
                        }*/
        }

        private void Bouton_Supprimer_Affectation(object sender, RoutedEventArgs e)
        {
            Window deletePage = new supprimerAffectation();
            deletePage.Show();
        }
    }
}
