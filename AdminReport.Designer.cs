namespace SWProject
{
    partial class AdminReport
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
            this.DisplayReport = new System.Windows.Forms.Button();
            this.ReportType = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.backToMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayReport
            // 
            this.DisplayReport.Location = new System.Drawing.Point(405, 18);
            this.DisplayReport.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayReport.Name = "DisplayReport";
            this.DisplayReport.Size = new System.Drawing.Size(211, 46);
            this.DisplayReport.TabIndex = 0;
            this.DisplayReport.Text = "Display Report";
            this.DisplayReport.UseVisualStyleBackColor = true;
            this.DisplayReport.Click += new System.EventHandler(this.DisplayReport_Click);
            // 
            // ReportType
            // 
            this.ReportType.FormattingEnabled = true;
            this.ReportType.Items.AddRange(new object[] {
            "Users",
            "Transactions"});
            this.ReportType.Location = new System.Drawing.Point(193, 32);
            this.ReportType.Margin = new System.Windows.Forms.Padding(2);
            this.ReportType.Name = "ReportType";
            this.ReportType.Size = new System.Drawing.Size(162, 21);
            this.ReportType.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(17, 81);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(826, 328);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelWidth = 150;
            // 
            // backToMenuBtn
            // 
            this.backToMenuBtn.Location = new System.Drawing.Point(17, 18);
            this.backToMenuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backToMenuBtn.Name = "backToMenuBtn";
            this.backToMenuBtn.Size = new System.Drawing.Size(90, 46);
            this.backToMenuBtn.TabIndex = 3;
            this.backToMenuBtn.Text = "Back to menu";
            this.backToMenuBtn.UseVisualStyleBackColor = true;
            this.backToMenuBtn.Click += new System.EventHandler(this.backToMenuBtn_Click);
            // 
            // AdminReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 418);
            this.Controls.Add(this.backToMenuBtn);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.ReportType);
            this.Controls.Add(this.DisplayReport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminReport";
            this.Text = "AdminReport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminReport_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DisplayReport;
        private System.Windows.Forms.ComboBox ReportType;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button backToMenuBtn;
    }
}