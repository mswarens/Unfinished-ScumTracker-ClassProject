using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectTracking.DataExports
{
    public class ExportDocumentFactory
    {

        public static IExportDocument getExportDocument (String exportType, String saveLocation)
        {
            switch (exportType)
            {
                case "PDF":
                    return new ExportPDFDocument(saveLocation);
                default:
                    return new ExportExcelDocument(saveLocation);

            }

            

        }



    }
}
