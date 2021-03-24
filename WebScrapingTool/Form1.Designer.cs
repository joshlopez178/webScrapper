namespace WebScrapingTool
{
    partial class Form1
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
            this.scrapBTN = new System.Windows.Forms.Button();
            this.txtdata = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // scrapBTN
            // 
            this.scrapBTN.Location = new System.Drawing.Point(12, 44);
            this.scrapBTN.Name = "scrapBTN";
            this.scrapBTN.Size = new System.Drawing.Size(133, 38);
            this.scrapBTN.TabIndex = 0;
            this.scrapBTN.Text = "Scrap Now";
            this.scrapBTN.UseVisualStyleBackColor = true;
            this.scrapBTN.Click += new System.EventHandler(this.scrapBTN_Click);
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(217, 12);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(548, 414);
            this.txtdata.TabIndex = 1;
            this.txtdata.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.scrapBTN);
            this.Name = "Form1";
            this.Text = "WebScrapper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scrapBTN;
        private System.Windows.Forms.RichTextBox txtdata;
    }
}

