//ST10092141 - Kgothato Theko
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citizenHelper
{
    //Events and announcment viewModel adapted from stackoverflow
    //ViewModel to handle data operations, data binding, and interaction with services, handles search functionality, and updates recommendations based on user behavior.
    //https://stackoverflow.com/a/8490996
    //Racheal
    //https://stackoverflow.com/users/302677/rachel
    public class EventsAnnouncementsViewModel
    {
        //Handles data retrieval and management of events.
        private EventService eventService;
        //Generates event recommendations based on user interactions.
        private RecommendationService recommendationService;

        public ObservableCollection<Event> Events { get; set; }
        public ObservableCollection<Event> RecommendedEvents { get; set; }

        // Data Structures for managing search patterns
        private Dictionary<string, int> categorySearchCount;
        private Dictionary<DateTime, int> dateSearchCount;

        public EventsAnnouncementsViewModel()
        {
            eventService = new EventService();
            recommendationService = new RecommendationService();
            Events = new ObservableCollection<Event>();
            RecommendedEvents = new ObservableCollection<Event>();
            categorySearchCount = new Dictionary<string, int>();
            dateSearchCount = new Dictionary<DateTime, int>();
        }

        //Retrieves all unique event categories from the EventService.
        public IEnumerable<string> GetUniqueCategories()
        {
            return eventService.GetUniqueCategories();
        }

        // Loads all events into the Events collection.
        public void LoadAllEvents()
        {
            Events.Clear();
            foreach (var evt in eventService.GetAllEvents())
            {
                Events.Add(evt);
            }
        }

        // Filters events based on selected category and/or date, updates search counts.
        public void SearchEvents(string category, DateTime? date)
        {
            var results = eventService.SearchEvents(category, date);
            Events.Clear();
            foreach (var evt in results)
            {
                Events.Add(evt);
            }

            // Update search counts for recommendation
            if (!string.IsNullOrEmpty(category))
            {
                if (categorySearchCount.ContainsKey(category))
                    categorySearchCount[category]++;
                else
                    categorySearchCount[category] = 1;
            }

            if (date.HasValue)
            {
                if (dateSearchCount.ContainsKey(date.Value))
                    dateSearchCount[date.Value]++;
                else
                    dateSearchCount[date.Value] = 1;
            }
        }

        //Fetches and updates the RecommendedEvents based on search patterns.
        public void UpdateRecommendations(string category, DateTime? date)
        {
            RecommendedEvents.Clear();
            var recommendations = recommendationService.GetRecommendations(categorySearchCount, dateSearchCount, eventService);
            foreach (var rec in recommendations)
            {
                RecommendedEvents.Add(rec);
            }
        }
    }
}
