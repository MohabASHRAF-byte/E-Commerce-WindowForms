
namespace SWProject
{
    partial class AddGallery
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
            this.label5 = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DESCRIPTION = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.art_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.pctimg = new System.Windows.Forms.PictureBox();
            this.backToMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctimg)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Image";
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(113, 285);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(151, 20);
            this.Stock.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Stock";
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.Location = new System.Drawing.Point(113, 253);
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.Size = new System.Drawing.Size(151, 20);
            this.DESCRIPTION.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Description";
            // 
            // art_name
            // 
            this.art_name.Location = new System.Drawing.Point(113, 219);
            this.art_name.Name = "art_name";
            this.art_name.Size = new System.Drawing.Size(151, 20);
            this.art_name.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Art name";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(105, 324);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(83, 34);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(194, 324);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(83, 34);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(113, 177);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 16;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // pctimg
            // 
            this.pctimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctimg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctimg.Location = new System.Drawing.Point(75, 41);
            this.pctimg.Name = "pctimg";
            this.pctimg.Size = new System.Drawing.Size(151, 128);
            this.pctimg.TabIndex = 15;
            this.pctimg.TabStop = false;
            // 
            // backToMenuBtn
            // 
            this.backToMenuBtn.Location = new System.Drawing.Point(16, 324);
            this.backToMenuBtn.Name = "backToMenuBtn";
            this.backToMenuBtn.Size = new System.Drawing.Size(83, 34);
            this.backToMenuBtn.TabIndex = 28;
            this.backToMenuBtn.Text = "Back to menu";
            this.backToMenuBtn.UseVisualStyleBackColor = true;
            this.backToMenuBtn.Click += new System.EventHandler(this.backToMenuBtn_Click);
            // 
            // AddGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 378);
            this.Controls.Add(this.backToMenuBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DESCRIPTION);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.art_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.pctimg);
            this.Name = "AddGallery";
            this.Text = "AddGallery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddGallery_FormClosing);
            this.Load += new System.EventHandler(this.AddGallery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Stock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DESCRIPTION;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox art_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.PictureBox pctimg;
        private System.Windows.Forms.Button backToMenuBtn;
    }
}