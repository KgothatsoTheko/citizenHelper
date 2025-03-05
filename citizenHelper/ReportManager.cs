//ST10092141 - Kgothatso Theko
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace citizenHelper
{
    //Report manager class to utilizes the implemented data structures for organizing, retrieving, and displaying report information.
    public class ReportManager
    {
        private AVLTree _reportTree;
        private ReportGraph _reportGraph;
        private ReportHeap _reportHeap;
        private List<ReportData> _allReports;

        public ReportManager()
        {
            _reportTree = new AVLTree();
            _reportGraph = new ReportGraph();
            _reportHeap = new ReportHeap((x, y) => x.SubmittedOn.CompareTo(y.SubmittedOn)); // Min Heap based on submission time
            _allReports = LoadReports();

            foreach (var report in _allReports)
            {
                _reportTree.Insert(report);
                _reportGraph.AddReport(report);
                _reportHeap.Insert(report);
            }
        }

        public List<ReportData> GetAllReports()
        {
            return _allReports.OrderBy(r => r.SubmittedOn).ToList();
        }

        public ReportData SearchReportById(string reportId)
        {
            return _reportTree.Search(reportId);
        }

        public void AddReport(ReportData report)
        {
            _reportTree.Insert(report);
            _reportGraph.AddReport(report);
            _reportHeap.Insert(report);
            _allReports.Add(report);
            SaveReports(_allReports);
        }

        // Methods to load and save reports from storage (UserSettings)
        private List<ReportData> LoadReports()
        {
            string jsonData = UserSettings.Default.ReportsData;
            return string.IsNullOrEmpty(jsonData) ? new List<ReportData>() : JsonSerializer.Deserialize<List<ReportData>>(jsonData) ?? new List<ReportData>();
        }

        private void SaveReports(List<ReportData> reports)
        {
            string jsonData = JsonSerializer.Serialize(reports);
            UserSettings.Default.ReportsData = jsonData;
            UserSettings.Default.Save();
        }
    }
}
