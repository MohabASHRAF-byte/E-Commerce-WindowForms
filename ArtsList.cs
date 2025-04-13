using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SWProject
{
    public partial class ArtsList : Form
    {

        OracleDataAdapter empadap;
        
        DataSet dset;

        int idx = 0;
        int n = 0;
        public ArtsList()
        {
            InitializeComponent();
        }
        void load()
        {
            try
            {
                n = 0;
                empadap = new OracleDataAdapter();
                empadap.SelectCommand = new OracleCommand("SELECT * FROM ART_WORKS", DatabaseHelper.conn);
                dset = new DataSet("dset");
                empadap.Fill(dset);
                DataTable dtable;
                dtable = dset.Tables[0];
                cmbempname.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbempname.Items.Add(drow[2].ToString());
                    n++;
                }
                cmbempname.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ArtistList_Load(object sender, EventArgs e)
        {
            load();
        }

        private void set_img(int indx)
        {
            DataTable dataTable = dset.Tables[0];
            var dataRow = dataTable.Rows[indx];
            byte[] blob = (byte[])dataRow[4];
            using (MemoryStream ms = new MemoryStream(blob))
            {
                Image image = Image.FromStream(ms);
                pctimg.Image = image;
                pctimg.SizeMode = PictureBoxSizeMode.StretchImage;
                pctimg.Refresh();
            }

            art_name.Text = dataRow[2].ToString();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DatabaseHelper.conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select username from users where user_id = {dataRow[1].ToString()}";
            var ret = cmd.ExecuteReader();
            ret.Read();
            textBox1.Text = ret[0].ToString();
            description.Text = dataRow[3].ToString();
            Stock.Text = dataRow[5].ToString();
            //
            int work_id = int.Parse(dataRow[0].ToString());

            cmd.CommandText = $"SELECT quantity from cart where work_id={work_id} and user_id ={LoggedInUser.CurrentUser.UserId}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                numericUpDown1.Value = int.Parse(dr[0].ToString());
            }
            else
                numericUpDown1.Value = 0;
        }

        private void previous_Click(object sender, EventArgs e)
        {
            idx = (idx - 1 + n) % n;
            set_img(idx);
            cmbempname.SelectedIndex = idx;
        }
        private void next_Click(object sender, EventArgs e)
        {
            idx = (idx + 1 + n) % n;
            set_img(idx);
            cmbempname.SelectedIndex = idx;
        }

        private void cmbempname_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if there is an already an image in picturebox, then delete it 
            if (pctimg.Image != null)
            {
                pctimg.Image.Dispose();
            }
            if (cmbempname.SelectedIndex == -1)
                return;
            idx = cmbempname.SelectedIndex;
            set_img(idx);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 0)
            {
                numericUpDown1.Value = 0;
            }
            DataTable dataTable = dset.Tables[0];
            var dataRow = dataTable.Rows[idx];
            if (numericUpDown1.Value > int.Parse(dataRow[5].ToString()))
            {
                numericUpDown1.Value = int.Parse(dataRow[5].ToString());
            }
            int work_id = int.Parse(dataRow[0].ToString());
            OracleCommand cmd = new OracleCommand();
            // check if exisit
            cmd.Connection = DatabaseHelper.conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT quantity from cart where work_id={work_id} and user_id ={LoggedInUser.CurrentUser.UserId}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (numericUpDown1.Value == 0)
                    cmd.CommandText = $"DELETE FROM cart WHERE user_id = {LoggedInUser.CurrentUser.UserId} and work_id = {work_id}";
                else
                    cmd.CommandText = $"UPDATE cart SET quantity = {numericUpDown1.Value} WHERE work_id = {work_id} and user_id ={LoggedInUser.CurrentUser.UserId}";
            }
            else
            {
                if (numericUpDown1.Value > 0)
                    cmd.CommandText = $"insert into cart values({work_id},{LoggedInUser.CurrentUser.UserId},{numericUpDown1.Value})";
            }
            int r = cmd.ExecuteNonQuery();
        }

        private void go_to_cart_Click(object sender, EventArgs e)
        {
            Forms.cartForm.Show();
            this.Hide();
        }

        private void backToMenuBtn_Click(object sender, EventArgs e)
        {
            Forms.mainForm.showForm();
            this.Hide();
        }

        private void ArtsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.homePage.Close();
        }


        public void showForm()
        {
            load();
            this.Show();
        }
    }
}
