//ST10092141 - Kgothatso Theko
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
using System.Windows.Shapes;

namespace citizenHelper
{
    /// <summary>
    /// Interaction logic for ReportStatus.xaml
    /// </summary>
    public partial class ReportStatus : Window
    {
        private ReportManager _reportManager;

        public ReportStatus()
        {
            InitializeComponent();
            _reportManager = new ReportManager();
            LoadReports();
        }

        //method to load reports from the reportManger
        //Kgothatso Theko
        private void LoadReports()
        {
            var reports = _reportManager.GetAllReports();
            ReportsDataGrid.ItemsSource = reports;
        }

        //method to use the serach feature
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchId = SearchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchId))
            {
                var report = _reportManager.SearchReportById(searchId);
                if (report != null)
                {
                    ReportsDataGrid.ItemsSource = new List<ReportData> { report };
                }
                else
                {
                    MessageBox.Show("Report not found.", "Search Result", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Report ID to search.", "Input Required", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        //Method to load reports and clear the search
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            LoadReports();
            SearchTextBox.Clear();
        }
    }
}
