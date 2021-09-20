using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockValuationExcelAddIn.Forms
{
    public partial class DcfHistoricalForm : Form
    {
        StockValuationRibbon stockValuationRibbon = new StockValuationRibbon();
        Database database = new Database();
        Requests requests = new Requests();
        public DcfHistoricalForm()
        {
            InitializeComponent();
        }

        private void DcfHistoricalForm_Load(object sender, EventArgs e)
        {
            // get symbol and add to text box & save
            string symbol = database.GetCurentTicker();
            symbolTextBox.Text = symbol;

            // add calues to time frame drop down
            timeframeDropDown.Items.Add("daily");
            timeframeDropDown.Items.Add("quarterly");
            timeframeDropDown.Items.Add("yearly");
        }

        private void dcfHistoricalGoButton_Click(object sender, EventArgs e)
        {

            // get symbol, timeframe, and limit
            string symbol = symbolTextBox.Text.ToString().ToUpper();
            string timeFrame = timeframeDropDown.Text.ToString();
            int limit = Convert.ToInt32(Math.Round(limitBox.Value, 0));

            if (symbol == "")
            {
                MessageBox.Show("Please Enter a Symbol.");
            }
            else
            {
                // save latest symbol to database
                database.SaveCurrentTicker(symbol);
                stockValuationRibbon.TickerSymbol.Label = symbol;

                // create new worksheet 
                var driver = Globals.ThisAddIn;
                Workbook currentWorkBook = driver.GetActiveWorkbook();
                string dcfSheetTitle = driver.AddWorksheet(symbol + " DCF Historical Data");
                Worksheet dcfHistoricalSheet = currentWorkBook.Sheets[dcfSheetTitle];

                // DCF Request Response List
                List<DataStructures.DcfHistorical> responseList = requests.DcfRequestHistorical(symbol, timeFrame, limit).Result;

                // set column headers
                dcfHistoricalSheet.Cells[1, 1] = "Date";
                dcfHistoricalSheet.Cells[1, 2] = "Market Price";
                dcfHistoricalSheet.Cells[1, 3] = "DCF Price";

                // loop through response list and display data
                int row = 2;
                foreach (var key in responseList)
                {
                    // date column
                    dcfHistoricalSheet.Cells[row, 1] = key.date;

                    // Market Price column
                    dcfHistoricalSheet.Cells[row, 2] = key.price;

                    // dcf column
                    dcfHistoricalSheet.Cells[row, 3] = key.dcf;

                    // increment row
                    row++;

                }
            }


        }

        private void dcfLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.dcfLink.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://financialmodelingprep.com/developer/docs/dcf-formula");
        }
    }
}
