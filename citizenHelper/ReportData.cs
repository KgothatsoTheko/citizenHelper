//ST10092141 - Kgothatso Theko
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citizenHelper
{
    //Report Data Model
    //Kgothatso Theko
    public class ReportData
    {
        public string ReportID { get; set; } // Unique Identifier
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; } // e.g., Submitted, In Progress, Completed
        public DateTime SubmittedOn { get; set; }

        //method to add report id, date submitted and status value
        public ReportData()
        {
            ReportID = Guid.NewGuid().ToString();
            SubmittedOn = DateTime.Now;
            Status = "Submitted";
        }
    }

}
