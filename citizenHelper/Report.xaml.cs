//ST10092141 - Kgothato Theko
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
using Microsoft.Win32; 
using System;
using System.IO;
using System.Collections.Specialized; 
using System.Text.Json;

namespace citizenHelper
{
    /// <summary>
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : Window
    {
        private string _imagePath;
        private ReportManager _reportManager;

        // Define the event
        public event Action ReportSaved;

        public Report()
        {
            InitializeComponent();
            _reportManager = new ReportManager();
        }

        // this method was adapted from stack overflow
        //https://stackoverflow.com/questions/2704516/how-to-save-user-inputed-value-in-textbox-wpf-xaml
        //Simon P Stevens
        //https://stackoverflow.com/users/119738/simon-p-stevens
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Get Location, Category, Description, ImagePath
            string location = LocationTextBox.Text.Trim();
            string category = (CategoryComboBox.SelectedItem as ComboBoxItem)?.Content.ToString() ?? string.Empty;
            TextRange descriptionTextRange = new TextRange(DescriptionRichBox.Document.ContentStart, DescriptionRichBox.Document.ContentEnd);
            string description = descriptionTextRange.Text.Trim();

            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Create a new report object
            var newReport = new ReportData
            {
                Location = location,
                Category = category,
                Description = description,
                ImagePath = _imagePath ?? string.Empty
            };

            try
            {
                _reportManager.AddReport(newReport);
                // Notify subscribers that a report was saved
                ReportSaved?.Invoke();
                MessageBox.Show($"Report Saved with ID: {newReport.ReportID}", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                // Close the window
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving report: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //this method was adpated from WDF Tutorial
        //https://wpf-tutorial.com/basic-controls/the-image-control/
        //WDF Tutorial
        private void UploadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                _imagePath = openFileDialog.FileName;
                PreviewImage.Source = new BitmapImage(new Uri(_imagePath));
            }
        }


    }
}
