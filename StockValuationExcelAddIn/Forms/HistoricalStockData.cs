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
    public partial class HistoricalStockData : Form
    {
        StockValuationRibbon stockValuationRibbon = new StockValuationRibbon();
        Database database = new Database();
        Requests requests = new Requests();
        public HistoricalStockData()
        {
            InitializeComponent();
        }

        private void HistoricalStockData_Load(object sender, EventArgs e)
        {
            // get symbol and add to text box & save
            string symbol = database.GetCurentTicker();
            symbolTextBox.Text = symbol;

            // add calues to time frame drop down
            timeframeDropDown.Items.Add("1min");
            timeframeDropDown.Items.Add("5min");
            timeframeDropDown.Items.Add("15min");
            timeframeDropDown.Items.Add("30min");
            timeframeDropDown.Items.Add("1hour");
            timeframeDropDown.Items.Add("4hour");
            timeframeDropDown.Items.Add("daily");

            // add technical indicators 
            technincalIndicatorsDropDown.Items.Add("SMA 20");
            technincalIndicatorsDropDown.Items.Add("SMA 50");
            technincalIndicatorsDropDown.Items.Add("SMA 100");
            technincalIndicatorsDropDown.Items.Add("SMA 200");
        }

        // format data in the new sheet
        private void goButton_Click(object sender, EventArgs e)
        {
            // get symbol, timeframe, and limit
            string symbol = symbolTextBox.Text.ToString().ToUpper();
            string timeFrame = timeframeDropDown.Text.ToString();
            int limit = Convert.ToInt32(Math.Round(limitBox.Value, 0));

            // conditional statments for form
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
                string historicalStockDataSheetTitle = driver.AddWorksheet(symbol + " Historical Stock Data");
                Worksheet historicalStockDataSheet = currentWorkBook.Sheets[historicalStockDataSheetTitle];

                // set column headers
                historicalStockDataSheet.Cells[1, 1] = "Date";
                historicalStockDataSheet.Cells[1, 2] = "Open";
                historicalStockDataSheet.Cells[1, 3] = "Low";
                historicalStockDataSheet.Cells[1, 4] = "High";
                historicalStockDataSheet.Cells[1, 5] = "Close";
                historicalStockDataSheet.Cells[1, 6] = "Volume";

                // get response and request for historical data
                DataStructures.HistoricalPricesWrapper responseObject = requests.HistoricalPrices(symbol, timeFrame, limit).Result;
                int row = 2;
                foreach (var key in responseObject.historical)
                {
                    // date column
                    historicalStockDataSheet.Cells[row, 1] = key.date;

                    // date open
                    historicalStockDataSheet.Cells[row, 2] = key.open;

                    // date low
                    historicalStockDataSheet.Cells[row, 3] = key.low;

                    // date high
                    historicalStockDataSheet.Cells[row, 4] = key.high;

                    // date close
                    historicalStockDataSheet.Cells[row, 5] = key.close;

                    // date volume
                    historicalStockDataSheet.Cells[row, 6] = key.volume;

                    // increment row 
                    row++;
                }
            }
        }

        private void addIndicatorButton_Click(object sender, EventArgs e)
        {
            // add to list box with conditions 
            if (!technicalInidcatorsListBox.Items.Contains(technincalIndicatorsDropDown.Text.ToString()))
            {
                technicalInidcatorsListBox.Items.Add(technincalIndicatorsDropDown.Text.ToString());
            }
        }
    }
}
