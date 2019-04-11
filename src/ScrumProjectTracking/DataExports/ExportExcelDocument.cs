using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrumProjectTracking.Sprints.SprintTaskList;
using Microsoft.Office.Interop.Excel;
namespace ScrumProjectTracking.DataExports
{
    class ExportExcelDocument :IExportDocument

    {
        String saveLocation;

        public ExportExcelDocument(String saveLocation) => this.saveLocation = saveLocation;

        public string exportData(List<SprintTaskListItem> results)
        {
            try
            {
                Application excelApp = new Application();
                
                Workbook workbook = excelApp.Workbooks.Add();
                Worksheet worksheet = workbook.Sheets[1];
                worksheet.Cells[1, 1] = "Sprint";
                worksheet.Cells[1, 2] = "Project";
                worksheet.Cells[1, 3] = "Sprint Task ID";
                worksheet.Cells[1, 4] = "Task Name";
                worksheet.Cells[1, 5] = "Status";
                worksheet.Cells[1, 6] = "Substatus";
                worksheet.Cells[1, 7] = "% Completed";
                worksheet.Cells[1, 8] = "Story Points";
                worksheet.Cells[1, 9] = "Team";
                worksheet.Cells[1, 10] = "Assignee";
                for (int i = 0; i <= results.Count - 1; i++)
                {
                    worksheet.Cells[i+2, 1] = results.ElementAt(i).SprintName;
                    worksheet.Cells[i+2, 2] = results.ElementAt(i).ProjectName;
                    worksheet.Cells[i+2, 3] = results.ElementAt(i).SprintTaskID;
                    worksheet.Cells[i + 2, 4] = results.ElementAt(i).TaskName;
                    worksheet.Cells[i + 2, 5] = results.ElementAt(i).TaskStatus;
                    worksheet.Cells[i + 2, 6] = results.ElementAt(i).TaskSubstatus;
                    worksheet.Cells[i + 2, 7] = results.ElementAt(i).TaskCompletionPercent;
                    worksheet.Cells[i + 2, 8] = results.ElementAt(i).StoryPoints;
                    worksheet.Cells[i + 2, 9] = results.ElementAt(i).TeamName;
                    worksheet.Cells[i + 2, 10] = results.ElementAt(i).AssignedToName;
                }
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 10]].Font.Bold = true;

                worksheet.Columns.AutoFit();
                workbook.SaveAs(saveLocation);
                workbook.Close();
                excelApp.Quit();
        }
            catch (System.Runtime.InteropServices.COMException)
            {
                return "An error has occured while exporting the file.  Please ensure Microsoft Excel is installed and the file path is accessible.";

            }

            return "Success";
        }
    }
}
