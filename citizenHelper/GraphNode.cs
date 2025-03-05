////ST10092141 - Kgothatso Theko
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citizenHelper
{
    //Graph for Managing Complex Relationships - represent relationships between different reports, such as dependencies or hierarchical structures adapted from Interviewer
    // https://interviewer.live/c-sharp/mastering-graph-data-structure-csharp/
    //Interviewer
    public class GraphNode
    {
        public ReportData Report { get; set; }
        public List<GraphNode> Adjacent { get; set; }

        public GraphNode(ReportData report)
        {
            Report = report;
            Adjacent = new List<GraphNode>();
        }
    }

    public class ReportGraph
    {
        private Dictionary<string, GraphNode> _nodes;

        public ReportGraph()
        {
            _nodes = new Dictionary<string, GraphNode>();
        }

        public void AddReport(ReportData report)
        {
            if (!_nodes.ContainsKey(report.ReportID))
                _nodes[report.ReportID] = new GraphNode(report);
        }

        public void AddDependency(string reportId, string dependsOnReportId)
        {
            if (_nodes.ContainsKey(reportId) && _nodes.ContainsKey(dependsOnReportId))
            {
                _nodes[reportId].Adjacent.Add(_nodes[dependsOnReportId]);
            }
        }

        public List<ReportData> GetDependencies(string reportId)
        {
            var dependencies = new List<ReportData>();
            if (_nodes.ContainsKey(reportId))
            {
                foreach (var adj in _nodes[reportId].Adjacent)
                {
                    dependencies.Add(adj.Report);
                }
            }
            return dependencies;
        }
    }
}
