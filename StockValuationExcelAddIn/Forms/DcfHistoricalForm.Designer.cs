
namespace StockValuationExcelAddIn.Forms
{
    partial class DcfHistoricalForm
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
            this.timeframeDropDown = new System.Windows.Forms.ComboBox();
            this.symbolTextBox = new System.Windows.Forms.TextBox();
            this.symbolLabel = new System.Windows.Forms.Label();
            this.timeFrameLabel = new System.Windows.Forms.Label();
            this.limitDropDown = new System.Windows.Forms.Label();
            this.limitBox = new System.Windows.Forms.NumericUpDown();
            this.dcfHistoricalGoButton = new System.Windows.Forms.Button();
            this.dcfLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.limitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timeframeDropDown
            // 
            this.timeframeDropDown.DisplayMember = "Hello";
            this.timeframeDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeframeDropDown.FormattingEnabled = true;
            this.timeframeDropDown.Location = new System.Drawing.Point(67, 185);
            this.timeframeDropDown.Name = "timeframeDropDown";
            this.timeframeDropDown.Size = new System.Drawing.Size(218, 33);
            this.timeframeDropDown.TabIndex = 0;
            this.timeframeDropDown.Text = "daily";
            // 
            // symbolTextBox
            // 
            this.symbolTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.symbolTextBox.Location = new System.Drawing.Point(67, 87);
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.Size = new System.Drawing.Size(218, 30);
            this.symbolTextBox.TabIndex = 1;
            // 
            // symbolLabel
            // 
            this.symbolLabel.AutoSize = true;
            this.symbolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.symbolLabel.Location = new System.Drawing.Point(62, 54);
            this.symbolLabel.Name = "symbolLabel";
            this.symbolLabel.Size = new System.Drawing.Size(78, 25);
            this.symbolLabel.TabIndex = 2;
            this.symbolLabel.Text = "Symbol";
            // 
            // timeFrameLabel
            // 
            this.timeFrameLabel.AutoSize = true;
            this.timeFrameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeFrameLabel.Location = new System.Drawing.Point(64, 152);
            this.timeFrameLabel.Name = "timeFrameLabel";
            this.timeFrameLabel.Size = new System.Drawing.Size(117, 25);
            this.timeFrameLabel.TabIndex = 3;
            this.timeFrameLabel.Text = "Time Frame";
            // 
            // limitDropDown
            // 
            this.limitDropDown.AutoSize = true;
            this.limitDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.limitDropDown.Location = new System.Drawing.Point(62, 244);
            this.limitDropDown.Name = "limitDropDown";
            this.limitDropDown.Size = new System.Drawing.Size(52, 25);
            this.limitDropDown.TabIndex = 5;
            this.limitDropDown.Text = "Limit";
            // 
            // limitBox
            // 
            this.limitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.limitBox.Location = new System.Drawing.Point(69, 277);
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
            this.limitBox.Size = new System.Drawing.Size(216, 30);
            this.limitBox.TabIndex = 6;
            this.limitBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dcfHistoricalGoButton
            // 
            this.dcfHistoricalGoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dcfHistoricalGoButton.Location = new System.Drawing.Point(69, 353);
            this.dcfHistoricalGoButton.Name = "dcfHistoricalGoButton";
            this.dcfHistoricalGoButton.Size = new System.Drawing.Size(216, 45);
            this.dcfHistoricalGoButton.TabIndex = 7;
            this.dcfHistoricalGoButton.Text = "Go";
            this.dcfHistoricalGoButton.UseVisualStyleBackColor = true;
            this.dcfHistoricalGoButton.Click += new System.EventHandler(this.dcfHistoricalGoButton_Click);
            // 
            // dcfLink
            // 
            this.dcfLink.AutoSize = true;
            this.dcfLink.Location = new System.Drawing.Point(278, 433);
            this.dcfLink.Name = "dcfLink";
            this.dcfLink.Size = new System.Drawing.Size(88, 13);
            this.dcfLink.TabIndex = 8;
            this.dcfLink.TabStop = true;
            this.dcfLink.Text = "DCF Calculations";
            this.dcfLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dcfLink_LinkClicked);
            // 
            // DcfHistoricalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 455);
            this.Controls.Add(this.dcfLink);
            this.Controls.Add(this.dcfHistoricalGoButton);
            this.Controls.Add(this.limitBox);
            this.Controls.Add(this.limitDropDown);
            this.Controls.Add(this.timeFrameLabel);
            this.Controls.Add(this.symbolLabel);
            this.Controls.Add(this.symbolTextBox);
            this.Controls.Add(this.timeframeDropDown);
            this.Name = "DcfHistoricalForm";
            this.Text = "DCF Historical Data";
            this.Load += new System.EventHandler(this.DcfHistoricalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.limitBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox timeframeDropDown;
        private System.Windows.Forms.TextBox symbolTextBox;
        private System.Windows.Forms.Label symbolLabel;
        private System.Windows.Forms.Label timeFrameLabel;
        private System.Windows.Forms.Label limitDropDown;
        private System.Windows.Forms.NumericUpDown limitBox;
        private System.Windows.Forms.Button dcfHistoricalGoButton;
        private System.Windows.Forms.LinkLabel dcfLink;
    }
}