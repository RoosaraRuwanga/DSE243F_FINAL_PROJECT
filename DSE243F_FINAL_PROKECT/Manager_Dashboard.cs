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
    public partial class Manager_Dashboard : Form
    {

        public Manager_Dashboard()
        {
            InitializeComponent();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {

        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Manager_ItemCatalouge newFrm = new Manager_ItemCatalouge();
            newFrm.Show();
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
