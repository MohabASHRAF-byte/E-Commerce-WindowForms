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
namespace SWProject
{
    public partial class CartForm : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public CartForm()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            string cmd = $"select aw.work_name , ct.quantity from art_works aw ,CART ct where aw.work_id = ct.work_id and ct.user_id = {LoggedInUser.CurrentUser.UserId}";
            adapter = new OracleDataAdapter(cmd, DatabaseHelper.ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
        private void CartForm_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validate())
                return;
            purshace();
            ArtsList artsList = new ArtsList();
            artsList.Show();
            this.Hide();
        }

        void clear()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DatabaseHelper.conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"DELETE FROM cart WHERE user_id = {LoggedInUser.CurrentUser.UserId}";
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                load_data();
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to clear the cart ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            clear();
            MessageBox.Show("Cleared successfully !!");
            ArtsList artsList = new ArtsList();
            artsList.Show();
            this.Hide();

        }
        private bool validate()
        {
            string cmd = $"select * FROM cart where user_id ={LoggedInUser.CurrentUser.UserId}";
            adapter = new OracleDataAdapter(cmd, DatabaseHelper.ordb);
            DataSet dss = new DataSet();
            adapter.Fill(dss);

            OracleCommand c = new OracleCommand();
            c.Connection = DatabaseHelper.conn;
            c.CommandType = CommandType.Text;
            for (int i = 0; i < dss.Tables[0].Rows.Count; i++)
            {
                DataTable dataTable = dss.Tables[0];
                var work_id = dataTable.Rows[i][0];
                var quantity = int.Parse(dataTable.Rows[i][2].ToString());
                c.CommandText = $"select stock FROM art_works where work_id ={work_id}";
                var dr = c.ExecuteReader();
                if (dr.Read())
                {
                    if (int.Parse(dr[0].ToString()) < quantity)
                    {
                        MessageBox.Show($"The available quantity of this item#{work_id} is less than than what you ordered");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show($"this art #{work_id} is out of stock");
                    return false;
                }
            }
            return true;

        }

        private bool purshace()
        {
            string cmd = $"select * FROM cart where user_id ={LoggedInUser.CurrentUser.UserId}";
            adapter = new OracleDataAdapter(cmd, DatabaseHelper.ordb);
            DataSet dss = new DataSet();
            adapter.Fill(dss);
            OracleCommand c = new OracleCommand();
            c.Connection = DatabaseHelper.conn;
            c.CommandType = CommandType.Text;
            for (int i = 0; i < dss.Tables[0].Rows.Count; i++)
            {
                DataTable dataTable = dss.Tables[0];
                var work_id = dataTable.Rows[i][0];
                var req_quantity = int.Parse(dataTable.Rows[i][2].ToString());
                // get  current quantity
                c.CommandText = $"select stock FROM art_works where work_id ={work_id}";
                var dr = c.ExecuteReader();
                dr.Read();
                var quantity = int.Parse(dr[0].ToString());
                // update new quantity
                quantity -= req_quantity;
                c.CommandText = $"UPDATE art_works SET stock = {quantity} WHERE work_id = {work_id}";
                int r = c.ExecuteNonQuery();
                // add to purchase 
                c.CommandText = $"insert into PURCHASE values(PURCHASE_ID_SEQ.NEXTVAL , {work_id} , {LoggedInUser.CurrentUser.UserId} , {req_quantity})";
                r = c.ExecuteNonQuery();
            }
            clear();
            return true;
        }

        private void backToMenuBtn_Click(object sender, EventArgs e)
        {
            Forms.artsListForm.Show();
            this.Hide();
        }

        private void CartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.homePage.Close();
        }
    }
}
