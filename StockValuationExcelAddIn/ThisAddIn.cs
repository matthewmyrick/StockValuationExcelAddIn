using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;

namespace StockValuationExcelAddIn
{
    public partial class ThisAddIn
    {
        Database database = new Database();
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {

        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }
        
        public string AddWorksheet(string name)
        {
            var newSheet = (Excel.Worksheet)Application.Worksheets.Add();
            int count = 0;
            while(true){
                if (count != 0)
                {
                    string title = name + " " + count;
                    try
                    {
                        newSheet.Name = title;
                        return title;
                    }
                    catch (System.Runtime.InteropServices.COMException ex) when (ex.Message == "Exception from HRESULT: 0x800A03EC")
                    {
                        return newSheet.Name;
                    }
                    catch (System.Runtime.InteropServices.COMException ex) when (ex.Message == "That name is already taken. Try a different one.")
                    {
                        count++;
                    }
                    
                }
                else if (count == 0)
                {
                    string title = name;
                    try
                    {
                        newSheet.Name = title;
                        return title;
                    }
                    catch
                    {
                        count++;
                    }                  
                }
            }
        }

        public Excel.Worksheet GetActiveWorksheet()
        {
            return (Excel.Worksheet)Application.ActiveSheet;
        }

        public Excel.Workbook GetActiveWorkbook()
        {
            return (Excel.Workbook)Application.ActiveWorkbook;
        }

        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
    }
}
