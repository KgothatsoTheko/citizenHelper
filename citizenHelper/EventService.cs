//ST10092141 - Kgothato Theko
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citizenHelper
{
    //manages event data, including loading, organizing, and searching.
    //Kgothato Theko
    public class EventService
    {
        // SortedDictionary with Date as key and list of events on that date as value adpated from stackoverflow
        //SortedDictionary <TKey, TValue> maintains the elements in sorted order based on the key. - Organizes events by date, allowing efficient retrieval and sorting.
        //https://stackoverflow.com/a/16069725
        //Peter
        //https://stackoverflow.com/users/2056088/peter
        private SortedDictionary<DateTime, List<Event>> eventsByDate;

        // HashSet for unique categories
        private HashSet<string> categories;

        public EventService()
        {
            eventsByDate = new SortedDictionary<DateTime, List<Event>>();
            categories = new HashSet<string>();
            LoadEvents();
        }

        //Populates the eventsByDate and categories with sample or real data.
        private void LoadEvents()
        {
            // Load events from a data source (JSON or Database or API) adapted from stackoverflow
            // For demonstration, adding some dummy data
            //https://stackoverflow.com/a/16069701
            //Linus Caldwell
            //https://stackoverflow.com/users/2156756/linus-caldwell
            var sampleEvents = new List<Event>
            {
                new Event { Title = "Music Concert", Category = "Music", Date = new DateTime(2024, 5, 20), Description = "A grand music concert.", ImagePath = "/images/music.jpg" },
                new Event { Title = "Kendrick Live Concert", Category = "Music", Date = new DateTime(2024, 12, 07), Description = "Live performance", ImagePath = "/images/music.jpg" },
                new Event { Title = "Art Exhibition", Category = "Art", Date = new DateTime(2024, 6, 15), Description = "Local artists display their work.", ImagePath = "/images/art.jpg" },
                new Event { Title = "Rand Show", Category = "Art", Date = new DateTime(2024, 11, 20), Description = "Car, art, sound, all-round entertainment", ImagePath = "/images/art.jpg" },
                // Add more events
            };

            foreach (var evt in sampleEvents)
            {
                if (!eventsByDate.ContainsKey(evt.Date))
                {
                    eventsByDate[evt.Date] = new List<Event>();
                }
                eventsByDate[evt.Date].Add(evt);
                categories.Add(evt.Category);
            }
        }
        //Retrieves all events, iterating through the sorted dictionary.
        public IEnumerable<Event> GetAllEvents()
        {
            foreach (var dateEvents in eventsByDate.Values)
            {
                foreach (var evt in dateEvents)
                {
                    yield return evt;
                }
            }
        }

        // Returns all unique categories.
        public IEnumerable<string> GetUniqueCategories()
        {
            return categories;
        }

        //Filters events based on category and/or date adapted from stackoverflow
        //https://stackoverflow.com/a/73059208
        //Eric J.
        //https://stackoverflow.com/users/141172/eric-j
        public IEnumerable<Event> SearchEvents(string category, DateTime? date)
        {
            var result = new List<Event>();

            if (date.HasValue && eventsByDate.ContainsKey(date.Value))
            {
                foreach (var evt in eventsByDate[date.Value])
                {
                    if (string.IsNullOrEmpty(category) || evt.Category == category)
                    {
                        result.Add(evt);
                    }
                }
            }
            else
            {
                foreach (var evt in GetAllEvents())
                {
                    if (string.IsNullOrEmpty(category) || evt.Category == category)
                    {
                        result.Add(evt);
                    }
                }
            }

            return result;
        }
    }
}
