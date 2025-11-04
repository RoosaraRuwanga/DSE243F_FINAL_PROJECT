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
    public partial class Manager_Dialog_AddProduct : Form
    {
        public Manager_ItemCatalouge mainForm;
        public Manager_Dialog_AddProduct()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Manager_Dialog_AddProduct_Load(object sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = 0;
            changeCategoryValues();
        }

        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            this.changeCategoryValues();
        }

        private void changeCategoryValues()
        {
            if(cmbCategory.SelectedItem.ToString() == "Poster")
            {
                lblExVal1.Text = "Poster Type";
                lblExVal2.Text = "Poster Size";
            }
            else if (cmbCategory.SelectedItem.ToString() == "Book")
            {
                lblExVal1.Text = "Book Type";
                lblExVal2.Text = "Binding Type";
            }
        }
        
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim() == "" || txtPrice.Text.Trim() == "" || txtVal1.Text.Trim() == "" || txtVal2.Text.Trim() == "")
            {
                MessageBox.Show("Please insert all values before adding a new product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = DatabaseSingleton.GetDBCon();
                using (con)
                {
                    String query = "INSERT INTO Products(ProductID, ProductName, ProductPrice, ProductStock) VALUES (@id, @name, @price, @stock)";
                    using(SqlCommand com = new SqlCommand(query, con))
                    {
                        try
                        {
                            com.Parameters.AddWithValue("@id", nmId.Value);
                            com.Parameters.AddWithValue("@name", txtName.Text.Trim());
                            com.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text.Trim()));
                            com.Parameters.AddWithValue("@stock", nmInitStock.Value);

                            com.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SQL Error:\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    // Add to relevant category table
                    String query2;
                    if (cmbCategory.SelectedItem.ToString() == "Poster")
                    {
                        query2 = "INSERT INTO CategoryPoster(ProductID, PosterType, PosterSize) VALUES (@id, @val1, @val2)";
                    }
                    else if(cmbCategory.SelectedItem.ToString() == "Book")
                    {
                        query2 = "INSERT INTO CategoryBook(ProductID, BookType, BindingType) VALUES (@id, @val1, @val2)";
                    }
                    else{
                        MessageBox.Show("Category not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (SqlCommand com2 = new SqlCommand(query2, con))
                    {
                        try
                        {
                            com2.Parameters.AddWithValue("@id", nmId.Value);
                            com2.Parameters.AddWithValue("@val1", txtVal1.Text.Trim());
                            com2.Parameters.AddWithValue("@val2", txtVal2.Text.Trim());

                            com2.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SQL Error:\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    MessageBox.Show("Product successfully added.");
                    mainForm.ReloadItems();
                    this.Close();
                }
            }
        }

    }
}
