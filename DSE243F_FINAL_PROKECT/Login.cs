using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSE243F_FINAL_PROKECT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // TODO: Open relevant dashboards for the corresponding members
            /* Basically, just check if the username and password combo exists first,
             then check what account type it is. Open the relevant form for that member
             type afterwards.*/
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;

            SqlConnection con = DatabaseSingleton.GetDBCon();

            if(username.Trim() == "" || password.Trim() == "")
            {
                MessageBox.Show("Error: All login credentials must be provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string returnVal;
                try
                {
                    // Get the role of the employee if the account details are correct
                    string query = "SELECT Role from Employee WHERE Username = @name AND Password = @pass";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = username;
                        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
                        returnVal = (string)cmd.ExecuteScalar();
                    }
                    if (String.IsNullOrEmpty(returnVal))
                    {
                        MessageBox.Show("Incorrect Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Check role
                    returnVal.Trim();
                    if(returnVal == "ManagingDirector")
                    {
                        Manager_Dashboard newFrm = new Manager_Dashboard();
                        newFrm.Show();
                        this.Hide();
                    }
                }
                catch (SqlException ex) // If the SQL Commands fail:
                {
                    MessageBox.Show("SQL Error:\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
