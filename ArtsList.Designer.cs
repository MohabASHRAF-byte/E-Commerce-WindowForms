
namespace SWProject
{
    partial class ArtsList
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.art_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.pctimg = new System.Windows.Forms.PictureBox();
            this.cmbempname = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.go_to_cart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backToMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctimg)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(144, 407);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(107, 20);
            this.numericUpDown1.TabIndex = 34;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(144, 369);
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Size = new System.Drawing.Size(107, 20);
            this.Stock.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Stock";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(144, 310);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(107, 44);
            this.description.TabIndex = 31;
            this.description.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 271);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Artist";
            // 
            // art_name
            // 
            this.art_name.Location = new System.Drawing.Point(144, 237);
            this.art_name.Name = "art_name";
            this.art_name.ReadOnly = true;
            this.art_name.Size = new System.Drawing.Size(107, 20);
            this.art_name.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Art Name";
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(236, 198);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(24, 24);
            this.next.TabIndex = 25;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(79, 198);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(24, 24);
            this.previous.TabIndex = 24;
            this.previous.Text = "<";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // pctimg
            // 
            this.pctimg.Location = new System.Drawing.Point(58, 15);
            this.pctimg.Name = "pctimg";
            this.pctimg.Size = new System.Drawing.Size(223, 177);
            this.pctimg.TabIndex = 23;
            this.pctimg.TabStop = false;
            // 
            // cmbempname
            // 
            this.cmbempname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbempname.FormattingEnabled = true;
            this.cmbempname.Location = new System.Drawing.Point(109, 200);
            this.cmbempname.Name = "cmbempname";
            this.cmbempname.Size = new System.Drawing.Size(121, 21);
            this.cmbempname.TabIndex = 22;
            this.cmbempname.SelectedIndexChanged += new System.EventHandler(this.cmbempname_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // go_to_cart
            // 
            this.go_to_cart.Location = new System.Drawing.Point(174, 435);
            this.go_to_cart.Name = "go_to_cart";
            this.go_to_cart.Size = new System.Drawing.Size(83, 34);
            this.go_to_cart.TabIndex = 35;
            this.go_to_cart.Text = "Go to cart";
            this.go_to_cart.UseVisualStyleBackColor = true;
            this.go_to_cart.Click += new System.EventHandler(this.go_to_cart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Quantity";
            // 
            // backToMenuBtn
            // 
            this.backToMenuBtn.Location = new System.Drawing.Point(84, 435);
            this.backToMenuBtn.Name = "backToMenuBtn";
            this.backToMenuBtn.Size = new System.Drawing.Size(83, 34);
            this.backToMenuBtn.TabIndex = 37;
            this.backToMenuBtn.Text = "Back to menu";
            this.backToMenuBtn.UseVisualStyleBackColor = true;
            this.backToMenuBtn.Click += new System.EventHandler(this.backToMenuBtn_Click);
            // 
            // ArtsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 481);
            this.Controls.Add(this.backToMenuBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.art_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.pctimg);
            this.Controls.Add(this.cmbempname);
            this.Controls.Add(this.go_to_cart);
            this.Name = "ArtsList";
            this.Text = "ArtsList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArtsList_FormClosing);
            this.Load += new System.EventHandler(this.ArtistList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox Stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox art_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.PictureBox pctimg;
        private System.Windows.Forms.ComboBox cmbempname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button go_to_cart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backToMenuBtn;
    }
}