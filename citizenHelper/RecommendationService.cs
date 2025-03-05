//ST10092141 - Kgothato Theko
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citizenHelper
{
    //recommendation service
    //simple recommendation algorithm based on search frequency adapted from satckoverflow
    //https://stackoverflow.com/q/12425060
    //Ramesh Durai
    //https://stackoverflow.com/users/1537422/ramesh-durai
    public class RecommendationService
    {
        public IEnumerable<Event> GetRecommendations(Dictionary<string, int> categorySearchCount,
                                                      Dictionary<DateTime, int> dateSearchCount,
                                                      EventService eventService)
        {
            var recommended = new List<Event>();

            // Recommend based on most searched categories
            var topCategories = categorySearchCount.OrderByDescending(kv => kv.Value)
                                                  .Take(3)
                                                  .Select(kv => kv.Key);

            foreach (var category in topCategories)
            {
                var events = eventService.SearchEvents(category, null).Take(5);
                recommended.AddRange(events);
            }

            // Recommend based on most searched dates
            var topDates = dateSearchCount.OrderByDescending(kv => kv.Value)
                                         .Take(3)
                                         .Select(kv => kv.Key);

            foreach (var date in topDates)
            {
                if (eventService.SearchEvents(null, date) != null)
                {
                    recommended.AddRange(eventService.SearchEvents(null, date).Take(5));
                }
            }

            // Remove duplicates
            return recommended.Distinct().Take(10);
        }
    }
}
