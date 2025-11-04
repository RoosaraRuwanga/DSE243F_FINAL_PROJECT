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
    public partial class Manager_ItemCatalouge : Form
    {
        public Manager_ItemCatalouge()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgCatalouge.CurrentRow == null)
            {
                MessageBox.Show("Please select an item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DataGridViewRow selectedRow = dgCatalouge.CurrentRow;
                DialogResult res = MessageBox.Show("Do you wish to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(res == DialogResult.Yes)
                {
                    try
                    {
                       SqlConnection con = DatabaseSingleton.GetDBCon();
                       using(con)
                        {
                            String query = "DELETE FROM Products WHERE ProductID = @id; ";
                            String q2 = "DELETE FROM CategoryPoster WHERE ProductID = @id; ";
                            String q3 = "DELETE FROM CategoryBook WHERE ProductID = @id;  ";
                            using (SqlCommand com = new SqlCommand(query + q2 + q3, con))
                            {
                                com.Parameters.AddWithValue("@id", selectedRow.Cells["ProductID"].Value);
                                com.ExecuteNonQuery();
                                MessageBox.Show("Product successfully deleted.");
                                ReloadItems();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SQL Error:\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Manager_Dialog_AddProduct dia = new Manager_Dialog_AddProduct();
            dia.mainForm = this;
            dia.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Manager_Dashboard newFrm = new Manager_Dashboard();
            newFrm.Show();
            this.Close();
        }

        private void Manager_ItemCatalouge_Load(object sender, EventArgs e)
        {
            ReloadItems();
        }

        public void ReloadItems()
        {
            try
            {
                SqlConnection con = DatabaseSingleton.GetDBCon();
                // Clear data just in case
                dgCatalouge.DataSource = null;
                // Establish Data Adapter to get a dataset from the database
                // (NOTE: Data Reader is better suited for a singular row rather than a whole table)
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", con);
                DataSet ds = new DataSet();
                // Fill the dataset with the database records
                da.Fill(ds, "Products");
                // Set the datagrid to display information from the dataset. (Reservaction Records)
                dgCatalouge.DataSource = ds.Tables["Products"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error:\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
