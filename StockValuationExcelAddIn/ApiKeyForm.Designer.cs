
namespace StockValuationExcelAddIn
{
    partial class ApiKeyForm
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
            this.components = new System.ComponentModel.Container();
            this.ApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SaveApiButton = new System.Windows.Forms.Button();
            this.GetApiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApiKeyTextBox
            // 
            this.ApiKeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ApiKeyTextBox.Location = new System.Drawing.Point(39, 67);
            this.ApiKeyTextBox.Name = "ApiKeyTextBox";
            this.ApiKeyTextBox.Size = new System.Drawing.Size(691, 30);
            this.ApiKeyTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "API Key";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SaveApiButton
            // 
            this.SaveApiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SaveApiButton.Location = new System.Drawing.Point(98, 126);
            this.SaveApiButton.Name = "SaveApiButton";
            this.SaveApiButton.Size = new System.Drawing.Size(237, 54);
            this.SaveApiButton.TabIndex = 2;
            this.SaveApiButton.Text = "Save API";
            this.SaveApiButton.UseVisualStyleBackColor = true;
            this.SaveApiButton.Click += new System.EventHandler(this.SaveApiButton_Click);
            // 
            // GetApiButton
            // 
            this.GetApiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.GetApiButton.Location = new System.Drawing.Point(437, 126);
            this.GetApiButton.Name = "GetApiButton";
            this.GetApiButton.Size = new System.Drawing.Size(237, 54);
            this.GetApiButton.TabIndex = 3;
            this.GetApiButton.Text = "Get API";
            this.GetApiButton.UseVisualStyleBackColor = true;
            this.GetApiButton.Click += new System.EventHandler(this.GetApiButton_Click);
            // 
            // ApiKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 212);
            this.Controls.Add(this.GetApiButton);
            this.Controls.Add(this.SaveApiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApiKeyTextBox);
            this.Name = "ApiKeyForm";
            this.Text = "ApiKeyForm";
            this.Load += new System.EventHandler(this.ApiKeyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ApiKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button SaveApiButton;
        private System.Windows.Forms.Button GetApiButton;
    }
}