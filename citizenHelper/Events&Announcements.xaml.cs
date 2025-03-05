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

namespace citizenHelper
{
    /// <summary>
    /// Interaction logic for Events_Announcements.xaml
    /// </summary>
    public partial class Events_Announcements : Window
    {
        private EventsAnnouncementsViewModel viewModel;
        public Events_Announcements()
        {
            InitializeComponent();
            viewModel = new EventsAnnouncementsViewModel();
            this.DataContext = viewModel;
            PopulateCategories();
            LoadEvents();
            LoadRecommendations();
        }

        //Fetches unique categories from the ViewModel, adds an "All" option, and binds them to the CategoryComboBox.
        //Kgothatso Theko
        private void PopulateCategories()
        {
            var categories = viewModel.GetUniqueCategories().ToList();
            categories.Insert(0, "All"); // Add 'All' option
            CategoryComboBox.ItemsSource = categories;
            CategoryComboBox.SelectedIndex = 0; // Select 'All' by default
        }

        //Invokes the ViewModel to load all events and binds the Events collection to the EventsListView.
        private void LoadEvents()
        {
            viewModel.LoadAllEvents();
            EventsListView.ItemsSource = viewModel.Events;
        }
        //Binds the RecommendedEvents collection to the RecommendationsListView.
        private void LoadRecommendations()
        {
            RecommendationsListView.ItemsSource = viewModel.RecommendedEvents;
        }

        //Handles the search button click event. Retrieves selected category and date, triggers search in the ViewModel, and updates both the events list and recommendations.
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedCategory = CategoryComboBox.SelectedItem as string;
            DateTime? selectedDate = DatePicker.SelectedDate;

            viewModel.SearchEvents(selectedCategory, selectedDate);
            EventsListView.ItemsSource = viewModel.Events;
            viewModel.UpdateRecommendations(selectedCategory, selectedDate);
            RecommendationsListView.ItemsSource = viewModel.RecommendedEvents;
        }
    }
}
