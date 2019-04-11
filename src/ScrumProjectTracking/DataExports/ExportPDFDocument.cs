using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.IO;
using ScrumProjectTracking.Sprints.SprintTaskList;
namespace ScrumProjectTracking.DataExports
{
    public class ExportPDFDocument : IExportDocument
    {
        string saveLocation;

        public ExportPDFDocument(string saveLocation) => this.saveLocation = saveLocation;

        public string exportData(List<SprintTaskListItem> results)
        {
            ReportDataSource ds = new ReportDataSource();
            ReportViewer rv = new ReportViewer();
            BindingSource bs = new BindingSource();

            bs.DataSource = results.Select(a => new SprintTaskListReportItem { assignedToName = a.AssignedToName, projectName = a.ProjectName, sprintName = a.SprintName, sprintTaskID = a.SprintTaskID, taskName = a.TaskName, taskStatus = a.TaskStatus, teamName = a.TeamName, taskCompletionPercent = a.TaskCompletionPercent, storyPoints = a.StoryPoints, taskSubStatus = a.TaskSubstatus }).ToList();
            rv.LocalReport.ReportEmbeddedResource = "ScrumProjectTracking.DataExports.SprintTaskListReport.rdlc";
            ds.Name = "DataSet1";
            ds.Value = bs;
            rv.LocalReport.DataSources.Add(ds);
            rv.RefreshReport();
            byte[] bytes = rv.LocalReport.Render("PDF", null);
            try
            {
                using (var stream = new FileStream(saveLocation, FileMode.Create, FileAccess.Write))
                {
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Close();
                }
                rv.Dispose();

              
            }
            catch (IOException)
            {
                return "The file could not be written to.  Please ensure the file is not currently open and that you have access to the file location and then try again.";

            }

            return "Success";

        }
    }
}
