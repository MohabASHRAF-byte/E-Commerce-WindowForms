namespace SWProject
{
    partial class MainForm
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
            this.artsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userManagementBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.uploadArtBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // artsBtn
            // 
            this.artsBtn.Location = new System.Drawing.Point(84, 120);
            this.artsBtn.Name = "artsBtn";
            this.artsBtn.Size = new System.Drawing.Size(133, 44);
            this.artsBtn.TabIndex = 0;
            this.artsBtn.Text = "Arts";
            this.artsBtn.UseVisualStyleBackColor = true;
            this.artsBtn.Click += new System.EventHandler(this.artsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Art Gallery";
            // 
            // userManagementBtn
            // 
            this.userManagementBtn.Location = new System.Drawing.Point(84, 259);
            this.userManagementBtn.Name = "userManagementBtn";
            this.userManagementBtn.Size = new System.Drawing.Size(133, 44);
            this.userManagementBtn.TabIndex = 2;
            this.userManagementBtn.Text = "Users Managmenet";
            this.userManagementBtn.UseVisualStyleBackColor = true;
            this.userManagementBtn.Click += new System.EventHandler(this.userManagementBtn_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.Location = new System.Drawing.Point(84, 331);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(133, 44);
            this.reportsBtn.TabIndex = 3;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseVisualStyleBackColor = true;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // uploadArtBtn
            // 
            this.uploadArtBtn.Location = new System.Drawing.Point(85, 193);
            this.uploadArtBtn.Name = "uploadArtBtn";
            this.uploadArtBtn.Size = new System.Drawing.Size(133, 44);
            this.uploadArtBtn.TabIndex = 4;
            this.uploadArtBtn.Text = "Upload Art";
            this.uploadArtBtn.UseVisualStyleBackColor = true;
            this.uploadArtBtn.Click += new System.EventHandler(this.uploadArtBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uploadArtBtn);
            this.Controls.Add(this.reportsBtn);
            this.Controls.Add(this.userManagementBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.artsBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button artsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userManagementBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button uploadArtBtn;
        private System.Windows.Forms.Button button1;
    }
}