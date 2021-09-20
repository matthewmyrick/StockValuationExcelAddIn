
namespace StockValuationExcelAddIn.Forms
{
    partial class HistoricalStockData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.symbolTextBox = new System.Windows.Forms.TextBox();
            this.symbolLabel = new System.Windows.Forms.Label();
            this.timeframeDropDown = new System.Windows.Forms.ComboBox();
            this.timeframeLabel = new System.Windows.Forms.Label();
            this.limitBox = new System.Windows.Forms.NumericUpDown();
            this.limitLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addIndicatorButton = new System.Windows.Forms.Button();
            this.technincalIndicatorsDropDown = new System.Windows.Forms.ComboBox();
            this.technicalInidcatorsListBox = new System.Windows.Forms.ListBox();
            this.goButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.limitBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // symbolTextBox
            // 
            this.symbolTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.symbolTextBox.Location = new System.Drawing.Point(34, 78);
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.Size = new System.Drawing.Size(180, 30);
            this.symbolTextBox.TabIndex = 0;
            // 
            // symbolLabel
            // 
            this.symbolLabel.AutoSize = true;
            this.symbolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.symbolLabel.Location = new System.Drawing.Point(29, 45);
            this.symbolLabel.Name = "symbolLabel";
            this.symbolLabel.Size = new System.Drawing.Size(78, 25);
            this.symbolLabel.TabIndex = 1;
            this.symbolLabel.Text = "Symbol";
            // 
            // timeframeDropDown
            // 
            this.timeframeDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeframeDropDown.FormattingEnabled = true;
            this.timeframeDropDown.Location = new System.Drawing.Point(34, 179);
            this.timeframeDropDown.Name = "timeframeDropDown";
            this.timeframeDropDown.Size = new System.Drawing.Size(180, 33);
            this.timeframeDropDown.TabIndex = 2;
            this.timeframeDropDown.Text = "daily";
            // 
            // timeframeLabel
            // 
            this.timeframeLabel.AutoSize = true;
            this.timeframeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeframeLabel.Location = new System.Drawing.Point(29, 146);
            this.timeframeLabel.Name = "timeframeLabel";
            this.timeframeLabel.Size = new System.Drawing.Size(105, 25);
            this.timeframeLabel.TabIndex = 3;
            this.timeframeLabel.Text = "Timeframe";
            // 
            // limitBox
            // 
            this.limitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.limitBox.Location = new System.Drawing.Point(34, 278);
            this.limitBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.limitBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.limitBox.Name = "limitBox";
            this.limitBox.Size = new System.Drawing.Size(180, 30);
            this.limitBox.TabIndex = 4;
            this.limitBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // limitLabel
            // 
            this.limitLabel.AutoSize = true;
            this.limitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.limitLabel.Location = new System.Drawing.Point(29, 245);
            this.limitLabel.Name = "limitLabel";
            this.limitLabel.Size = new System.Drawing.Size(52, 25);
            this.limitLabel.TabIndex = 5;
            this.limitLabel.Text = "Limit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addIndicatorButton);
            this.groupBox1.Controls.Add(this.technincalIndicatorsDropDown);
            this.groupBox1.Controls.Add(this.technicalInidcatorsListBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(273, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 319);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Technical Indicators";
            // 
            // addIndicatorButton
            // 
            this.addIndicatorButton.Location = new System.Drawing.Point(239, 27);
            this.addIndicatorButton.Name = "addIndicatorButton";
            this.addIndicatorButton.Size = new System.Drawing.Size(75, 23);
            this.addIndicatorButton.TabIndex = 2;
            this.addIndicatorButton.Text = "Add";
            this.addIndicatorButton.UseVisualStyleBackColor = true;
            this.addIndicatorButton.Click += new System.EventHandler(this.addIndicatorButton_Click);
            // 
            // technincalIndicatorsDropDown
            // 
            this.technincalIndicatorsDropDown.FormattingEnabled = true;
            this.technincalIndicatorsDropDown.Location = new System.Drawing.Point(21, 27);
            this.technincalIndicatorsDropDown.Name = "technincalIndicatorsDropDown";
            this.technincalIndicatorsDropDown.Size = new System.Drawing.Size(182, 24);
            this.technincalIndicatorsDropDown.TabIndex = 1;
            this.technincalIndicatorsDropDown.Text = "None";
            this.technincalIndicatorsDropDown.UseWaitCursor = true;
            // 
            // technicalInidcatorsListBox
            // 
            this.technicalInidcatorsListBox.FormattingEnabled = true;
            this.technicalInidcatorsListBox.ItemHeight = 16;
            this.technicalInidcatorsListBox.Location = new System.Drawing.Point(6, 61);
            this.technicalInidcatorsListBox.Name = "technicalInidcatorsListBox";
            this.technicalInidcatorsListBox.Size = new System.Drawing.Size(327, 244);
            this.technicalInidcatorsListBox.TabIndex = 0;
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.goButton.Location = new System.Drawing.Point(34, 334);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(180, 34);
            this.goButton.TabIndex = 7;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // HistoricalStockData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 392);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.limitLabel);
            this.Controls.Add(this.limitBox);
            this.Controls.Add(this.timeframeLabel);
            this.Controls.Add(this.timeframeDropDown);
            this.Controls.Add(this.symbolLabel);
            this.Controls.Add(this.symbolTextBox);
            this.Name = "HistoricalStockData";
            this.Text = "Historical Stock Data";
            this.Load += new System.EventHandler(this.HistoricalStockData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.limitBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox symbolTextBox;
        private System.Windows.Forms.Label symbolLabel;
        private System.Windows.Forms.ComboBox timeframeDropDown;
        private System.Windows.Forms.Label timeframeLabel;
        private System.Windows.Forms.NumericUpDown limitBox;
        private System.Windows.Forms.Label limitLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox technincalIndicatorsDropDown;
        private System.Windows.Forms.ListBox technicalInidcatorsListBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button addIndicatorButton;
    }
}