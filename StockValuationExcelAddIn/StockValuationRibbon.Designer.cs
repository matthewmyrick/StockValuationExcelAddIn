
namespace StockValuationExcelAddIn
{
    partial class StockValuationRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public StockValuationRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.TickerSymbolGroup = this.Factory.CreateRibbonGroup();
            this.TickerSymbol = this.Factory.CreateRibbonEditBox();
            this.DcfGroup = this.Factory.CreateRibbonGroup();
            this.CurrentDcfModel = this.Factory.CreateRibbonButton();
            this.GenerateHistoricalDcf = this.Factory.CreateRibbonButton();
            this.ApiGroup = this.Factory.CreateRibbonGroup();
            this.SaveApiButton = this.Factory.CreateRibbonButton();
            this.GenerateApiButton = this.Factory.CreateRibbonButton();
            this.ViewDocumentationButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.TickerSymbolGroup.SuspendLayout();
            this.DcfGroup.SuspendLayout();
            this.ApiGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.TickerSymbolGroup);
            this.tab1.Groups.Add(this.DcfGroup);
            this.tab1.Groups.Add(this.ApiGroup);
            this.tab1.Label = "Stock Valuation";
            this.tab1.Name = "tab1";
            // 
            // TickerSymbolGroup
            // 
            this.TickerSymbolGroup.Items.Add(this.TickerSymbol);
            this.TickerSymbolGroup.Name = "TickerSymbolGroup";
            // 
            // TickerSymbol
            // 
            this.TickerSymbol.Label = "Ticker Symbol";
            this.TickerSymbol.MaxLength = 10;
            this.TickerSymbol.Name = "TickerSymbol";
            this.TickerSymbol.Text = null;
            // 
            // DcfGroup
            // 
            this.DcfGroup.Items.Add(this.CurrentDcfModel);
            this.DcfGroup.Items.Add(this.GenerateHistoricalDcf);
            this.DcfGroup.Label = "Discounted Cash Flow";
            this.DcfGroup.Name = "DcfGroup";
            // 
            // CurrentDcfModel
            // 
            this.CurrentDcfModel.Label = "Generate Current DCF Model";
            this.CurrentDcfModel.Name = "CurrentDcfModel";
            this.CurrentDcfModel.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CurrentDcfModel_Click);
            // 
            // GenerateHistoricalDcf
            // 
            this.GenerateHistoricalDcf.Label = "Generate Historical DCFs";
            this.GenerateHistoricalDcf.Name = "GenerateHistoricalDcf";
            this.GenerateHistoricalDcf.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GenerateHistoricalDcf_Click);
            // 
            // ApiGroup
            // 
            this.ApiGroup.Items.Add(this.SaveApiButton);
            this.ApiGroup.Items.Add(this.GenerateApiButton);
            this.ApiGroup.Items.Add(this.ViewDocumentationButton);
            this.ApiGroup.Label = "API";
            this.ApiGroup.Name = "ApiGroup";
            // 
            // SaveApiButton
            // 
            this.SaveApiButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.SaveApiButton.Image = global::StockValuationExcelAddIn.Properties.Resources.big_data_icon;
            this.SaveApiButton.Label = "Save / Update API";
            this.SaveApiButton.Name = "SaveApiButton";
            this.SaveApiButton.ShowImage = true;
            this.SaveApiButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SaveApiButton_Click);
            // 
            // GenerateApiButton
            // 
            this.GenerateApiButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.GenerateApiButton.Image = global::StockValuationExcelAddIn.Properties.Resources.api_settings1;
            this.GenerateApiButton.Label = "Generate API";
            this.GenerateApiButton.Name = "GenerateApiButton";
            this.GenerateApiButton.ShowImage = true;
            this.GenerateApiButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GenerateApiButton_Click);
            // 
            // ViewDocumentationButton
            // 
            this.ViewDocumentationButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ViewDocumentationButton.Image = global::StockValuationExcelAddIn.Properties.Resources.source_code;
            this.ViewDocumentationButton.Label = "View Documentation";
            this.ViewDocumentationButton.Name = "ViewDocumentationButton";
            this.ViewDocumentationButton.ShowImage = true;
            this.ViewDocumentationButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ViewDocumentationButton_Click);
            // 
            // StockValuationRibbon
            // 
            this.Name = "StockValuationRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.StockValuationRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.TickerSymbolGroup.ResumeLayout(false);
            this.TickerSymbolGroup.PerformLayout();
            this.DcfGroup.ResumeLayout(false);
            this.DcfGroup.PerformLayout();
            this.ApiGroup.ResumeLayout(false);
            this.ApiGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup TickerSymbolGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup DcfGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox TickerSymbol;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CurrentDcfModel;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton GenerateHistoricalDcf;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup ApiGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SaveApiButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton GenerateApiButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ViewDocumentationButton;
    }

    partial class ThisRibbonCollection
    {
        internal StockValuationRibbon StockValuationRibbon
        {
            get { return this.GetRibbon<StockValuationRibbon>(); }
        }
    }
}
