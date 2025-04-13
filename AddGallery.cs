using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.IO;

namespace SWProject
{
    public partial class AddGallery : Form
    {
        string imagename;

        public AddGallery()
        {
            InitializeComponent();
        }

        private void AddGallery_Load(object sender, EventArgs e)
        {
            
        }
        void clear_fields()
        {
            pctimg.Image = null;
            imagename = "";
            Stock.Text = "";
            art_name.Text = "";
            DESCRIPTION.Text = "";
            Stock.Text = "";
        }
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog fldlg = new OpenFileDialog();
                //specify your own initial directory 
                fldlg.InitialDirectory = @":D\";
                //this will allow onlt those file extensions to be added 
                fldlg.Filter = "Image File (*.png;*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif;*.png";
                if (fldlg.ShowDialog() == DialogResult.OK)
                {
                    imagename = fldlg.FileName;
                    Bitmap newimg = new Bitmap(imagename);
                    pctimg.SizeMode = PictureBoxSizeMode.StretchImage;
                    pctimg.Image = (Image)newimg;
                }
                fldlg = null;
                try
                {
                    string[] substrings = imagename.Split('\\');
                    art_name.Text = substrings[substrings.Length - 1];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Choose valid path");
                }
            }

            catch (System.ArgumentException ae)
            {
                imagename = " ";
                MessageBox.Show(ae.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save the Art ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            int stock;
            if (imagename.Length == 0)
            {
                MessageBox.Show("Please select photo ");
                return;
            }
            if (art_name.Text.Length == 0)
            {
                MessageBox.Show("Please Enter a valid name ");
                return;
            }
            if (DESCRIPTION.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Description ");
                return;
            }
            try
            {
                stock = int.Parse(Stock.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Stock ");
                return;
            }
            int userid = LoggedInUser.CurrentUser.UserId;
            try
            {
                //proceed only when the image has a valid path 
                FileStream fls;
                fls = new FileStream(@imagename, FileMode.Open, System.IO.FileAccess.Read);
                //a byte array to read the image 
                byte[] blob = new byte[fls.Length];
                fls.Read(blob, 0, System.Convert.ToInt32(fls.Length));
                fls.Close();
                //open the database using odp.net and insert the data 
                OracleCommand cmnd;
                string query;
                query = $"insert into art_works values(ART_WORK_ID_SEQ.NEXTVAL, {userid}, '{art_name.Text}', '{DESCRIPTION.Text}', :BlobParameter, {stock})";
                //insert the byte as oracle parameter of type blob 
                OracleParameter blobParameter = new OracleParameter();
                blobParameter.OracleDbType = OracleDbType.Blob;
                blobParameter.ParameterName = "BlobParameter";
                blobParameter.Value = blob;
                cmnd = new OracleCommand(query, DatabaseHelper.conn);
                cmnd.Parameters.Add(blobParameter);
                cmnd.ExecuteNonQuery();
                // clear all boxs
                clear_fields();
                MessageBox.Show("Saved successfully !!");
                cmnd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Clear all fields ?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            clear_fields();
        }

        private void backToMenuBtn_Click(object sender, EventArgs e)
        {
            Forms.mainForm.showForm();
            this.Hide();
        }

        private void AddGallery_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.homePage.Close();
        }

        public void load()
        {
            clear_fields();
        }
        public void showForm()
        {
            load();
            this.Show();
        }
    }
}
