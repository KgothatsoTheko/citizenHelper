//ST10092141 - Kgothato Theko
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citizenHelper
{
    //Model for events
    //Kgothatso theko
    public class Event
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
