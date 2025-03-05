//ST10092141 - Kgothato Theko
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
using System.Text.Json;

namespace citizenHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ReportManager _reportManager;

        public MainWindow()
        {
            InitializeComponent();
            _reportManager = new ReportManager();
            LoadData();
        }

        // Method to open report window
        // Kgothatso theko
        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Instance of report
            Report reportWindow = new Report();

            // Subscribe to the ReportSaved event
            reportWindow.ReportSaved += LoadData;

            // Show report window
            reportWindow.Show();
        }

        // Method to open local events and announcement window
        // Kgothatso Theko
        private void AnnouncementsEvents_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Events_Announcements eventsWindow = new Events_Announcements();
            eventsWindow.Show();
        }

        // Method to open report status window
        private void reportStatus_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ReportStatus eventsWindow = new ReportStatus();
            eventsWindow.Show();
        }

        // Method to load data and display from UserSettings JSON string
        public void LoadData()
        {
            // Load saved reports
            var reports = _reportManager.GetAllReports();

            // Bind reports to the ListBox or DataGrid
            ReportsListBox.ItemsSource = reports;
        }

        // Method to change the language adapted from stack overflow
        //https://stackoverflow.com/questions/11327840/multilingual-wpf-application
        //Aghilas Yakoub
        //https://stackoverflow.com/users/1036390/aghilas-yakoub
        private void ChangeLanguage(string languageCode)
        {
            ResourceDictionary dict = new ResourceDictionary();
            switch (languageCode)
            {
                case "en":
                    dict.Source = new Uri("/English.xaml", UriKind.Relative);
                    break;
                case "af":
                    dict.Source = new Uri("/Afrikaans.xaml", UriKind.Relative);
                    break;
                case "zu":
                    dict.Source = new Uri("/Zulu.xaml", UriKind.Relative);
                    break;
                case "xh":
                    dict.Source = new Uri("/Xhosa.xaml", UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("/English.xaml", UriKind.Relative);
                    break;
            }

            // Clear the old resource and load the new one
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dict);
        }

        // Call this method when language is changed
        private void LanguageSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem; // Get the selected ComboBoxItem
            string selectedLanguage = (string)selectedItem.Tag; // Get the language code from the Tag property

            ChangeLanguage(selectedLanguage);
        }

    }
}