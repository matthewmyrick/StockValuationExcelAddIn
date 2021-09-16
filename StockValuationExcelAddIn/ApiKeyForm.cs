using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockValuationExcelAddIn
{
    public partial class ApiKeyForm : Form
    {
        Database database = new Database();
        public ApiKeyForm()
        {
            InitializeComponent();
        }

        private void SaveApiButton_Click(object sender, EventArgs e)
        {
            database.SaveApi(ApiKeyTextBox.Text.ToString());
        }

        private void GetApiButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://financialmodelingprep.com/developer/docs");
            Process.Start(sInfo);
        }

        private void ApiKeyForm_Load(object sender, EventArgs e)
        {
            ApiKeyTextBox.Text = database.GetApi().ToString();
        }
    }
}
