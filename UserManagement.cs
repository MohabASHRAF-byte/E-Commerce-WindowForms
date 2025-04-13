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
    public partial class UserManagement : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public UserManagement()
        {
            InitializeComponent();

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            load();
        }

        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            try
            {
                builder = new OracleCommandBuilder(adapter);
                adapter.Update(ds.Tables[0]);
                MessageBox.Show("Users data updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating users data: " + ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
           Forms.mainForm.showForm();
            this.Hide();
        }

        private void UserManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.homePage.Close();
        }

        public void load()
        {
            string query = "SELECT * FROM users";
            adapter = new OracleDataAdapter(query, DatabaseHelper.ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            usersGrid.DataSource = ds.Tables[0];
        }

        public void showForm()
        {
            load();
            this.Show();
        }
    }
}
