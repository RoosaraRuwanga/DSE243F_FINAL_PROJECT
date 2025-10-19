using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        }
    }
}
