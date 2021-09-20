using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockValuationExcelAddIn
{
    public partial class StockValuationRibbon
    {
        Database database = new Database();
        Requests requests = new Requests();
        private void StockValuationRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            // get current api
            string api = database.GetApi().ToString();
            if (api == "demo" || api == "")
            {
                MessageBox.Show("Please add an API Key, features may be limited.");
            }

            // get current symbol
            string symbol = database.GetCurentTicker().ToString().ToUpper();
            TickerSymbol.Text = symbol;
            
        }

        // DCF Button Gorups
        private void CurrentDcfModel_Click(object sender, RibbonControlEventArgs e)
        {
            string symbol = TickerSymbol.Text.ToString().ToUpper();
            // save latest symbol to database
            database.SaveCurrentTicker(symbol);
            
        }

        private void GenerateHistoricalDcf_Click(object sender, RibbonControlEventArgs e)
        {
            // get current api
            string api = database.GetApi().ToString();
            if (api == "demo" || api == "")
            {
                MessageBox.Show("Please add an API Key for this feature.");
            }
            else
            {
                try
                {
                    // get current symbol 
                    string symbol = TickerSymbol.Text.ToString().ToUpper();

                    // save latest symbol to database
                    database.SaveCurrentTicker(symbol);

                    // initialize object
                    Forms.DcfHistoricalForm app = new Forms.DcfHistoricalForm();
                    app.Show();
                }
                catch
                {
                    MessageBox.Show("Error opening feature.");
                }
            }

        }

        // Historical Prices Groups
        private void historicalDataButton_Click(object sender, RibbonControlEventArgs e)
        {
            // get current api
            string api = database.GetApi().ToString();
            if (api == "demo" || api == "")
            {
                MessageBox.Show("Please add an API Key for this feature.");
            }
            else
            {
                try
                {
                    // get current symbol 
                    string symbol = TickerSymbol.Text.ToString().ToUpper();

                    // save latest symbol to database
                    database.SaveCurrentTicker(symbol);

                    // initialize forms application
                    Forms.HistoricalStockData app = new Forms.HistoricalStockData();
                    app.Show();
                }
                catch
                {
                    MessageBox.Show("Error opening feature.");
                }

            }


        }

        // API Button Groups 
        private void SaveApiButton_Click(object sender, RibbonControlEventArgs e)
        {
            ApiKeyForm apiKeyForm = new ApiKeyForm();
            apiKeyForm.Show();
        }

        private void GenerateApiButton_Click(object sender, RibbonControlEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://financialmodelingprep.com/developer/docs");
            Process.Start(sInfo);
        }

        private void ViewDocumentationButton_Click(object sender, RibbonControlEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/matthewmyrick");
            Process.Start(sInfo);
        }

        
    }
}
