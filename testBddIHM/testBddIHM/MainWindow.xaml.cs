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
            comboBoxTri.ItemsSource = ApplicationData.listeDivision;
            listviewTri.ItemsSource = ApplicationData.listviewTri;
            listviewTri.Visibility = Visibility.Hidden;
        }

        public void refresh()
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
            comboBoxTri.ItemsSource = ApplicationData.listeDivision;
            listviewTri.ItemsSource = ApplicationData.listviewTri;
        }

        private void Bouton_Valider(object sender, RoutedEventArgs e)
        {
            if(comboBoxMission.SelectedItem != null && comboBoxDivision.SelectedItem != null && datePickerAffectation.SelectedDate != null)
            {
                Affectation aze = new Affectation(((Mission)comboBoxMission.SelectedItem).NumeroMission, ((Division)comboBoxDivision.SelectedItem).NumeroDivision, ((DateTime)datePickerAffectation.SelectedDate).Date, txtBoxCommentaire.Text.ToString());
                aze.Create();
                datePickerAffectation.SelectedDate = null;
                txtBoxCommentaire.Text = "";
                reset();
                refresh();
            }
            else
                MessageBox.Show("Veuillez remplir correctement le formulaire de modification !", "Error", MessageBoxButton.OK, MessageBoxImage.Error);


        }

        private void Bouton_Supprimer_Affectation(object sender, RoutedEventArgs e)
        {
            Window deletePage = new supprimerAffectation(this);
            deletePage.Show();
        }

        private void Bouton_Modifier_Affectation(object sender, RoutedEventArgs e)
        {
            Window pageSelectionAffectation = new selectionneAffectation(this);
            pageSelectionAffectation.Show();
        }
        private void reset()
        {
            comboBoxDivision.SelectedItem = null;
            comboBoxMission.SelectedItem = null;
            datePickerAffectation.SelectedDate = null;
            txtBoxCommentaire.Text = "";
        }
        private void Bouton_Annuler(object sender, RoutedEventArgs e)
        {
            reset();
        }

        private void Bouton_Fermer_Application(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void updateliste()
        {
            if (!(comboBoxTri.SelectedItem is null))
            {
                ApplicationData.listviewTri.Clear();
                
                foreach (Affectation uneAffectation in ApplicationData.listeAffectation)
                {
                    if (uneAffectation.NumeroD == ((Division)(comboBoxTri.SelectedItem)).NumeroDivision)
                    {
                        ApplicationData.listviewTri.Add(uneAffectation);
                    }
                }
                if (ApplicationData.listviewTri.Count <= 0)
                    MessageBox.Show("Il n'y à pas d'affectation contenant ce numéro de division !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                listviewTri.Items.Refresh();
            }
        }
        private void comboBoxTri_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            updateliste();
            listviewAffectationDivision.Visibility = Visibility.Hidden;
            listviewTri.Visibility = Visibility.Visible;
        }

        private void Bouton_Annuler_Tri(object sender, RoutedEventArgs e)
        {
            listviewTri.Visibility = Visibility.Hidden;
            listviewAffectationDivision.Visibility = Visibility.Visible;
        }
    }
}
