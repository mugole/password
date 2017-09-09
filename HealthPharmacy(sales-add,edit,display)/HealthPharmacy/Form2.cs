using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using HealthPharmacy;

namespace HealthPharmacy
{
    public partial class Form2 : Form
    {
        SqlConnection connection;
        string ConnectionString;
        Sales PharmancySales = new Sales();

        public Form2()
        {
            InitializeComponent();
            ConnectionString = ConfigurationManager.ConnectionStrings["HealthPharmacy.Properties.Settings.ProductDatabaseConnectionString"].ConnectionString;
            PopulateSales();
        }

        private void Salestab_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            PharmancySales.ItemName = NameBox.Text;
        }

        private void CategoryBox_TextChanged(object sender, EventArgs e)
        {
            PharmancySales.ItemCategory = CategoryBox.Text;
        }

        private void PurchaseBox_TextChanged(object sender, EventArgs e)
        {
            PharmancySales.ItemPurchasePrice = Convert.ToDouble(PurchaseBox.Text);
        }

        private void SalesBox_TextChanged(object sender, EventArgs e)
        {
            PharmancySales.ItemSalesPrice = Convert.ToDouble(SalesBox.Text);
        }

        private void AddSalesButton_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            PharmancySales.ItemQuantity = PharmancySales.ItemQuantity + 1;
            SqlCommand Command = new SqlCommand("INSERT INTO Sales VALUES('" + PharmancySales.ItemName + "','" + PharmancySales.ItemQuantity + "','" + PharmancySales.ItemCategory + "', '" + PharmancySales.ItemPurchasePrice + "','" + PharmancySales.ItemSalesPrice + "')", connection);
            Command.ExecuteNonQuery();

            MessageBox.Show("New Item added");
            PopulateSales();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();

            if (EditNameBox.Text != "")
            {
                PharmancySales.ItemName = EditNameBox.Text;
                SqlCommand Command = new SqlCommand("UPDATE Sales SET ItemName = '" + PharmancySales.ItemName + "' WHERE ItemName = '" + PharmancySales.ItemName + "';", connection);
                Command.ExecuteNonQuery();
            }
            if (EditCategoryBox.Text != "")
            {
                PharmancySales.ItemCategory = EditCategoryBox.Text;
                SqlCommand Command = new SqlCommand("UPDATE Sales SET Category = '" + PharmancySales.ItemCategory + "' WHERE ItemName = '" + PharmancySales.ItemName + "';", connection);
                Command.ExecuteNonQuery();
            }
            if (EditPurchaseBox.Text != "")
            {
                PharmancySales.ItemPurchasePrice = Convert.ToDouble(EditPurchaseBox.Text);
                SqlCommand Command = new SqlCommand("UPDATE Sales SET PurchasePrice = '" + PharmancySales.ItemPurchasePrice + "' WHERE ItemName = '" + PharmancySales.ItemName + "';", connection);
                Command.ExecuteNonQuery();
            }
            if (EditSalesBox.Text != "")
            {
                PharmancySales.ItemSalesPrice = Convert.ToDouble(EditSalesBox.Text);
                SqlCommand Command = new SqlCommand("UPDATE Sales SET SalesPrice = '" + PharmancySales.ItemSalesPrice + "' WHERE ItemName = '" + PharmancySales.ItemName + "';", connection);
                Command.ExecuteNonQuery();
            }

            MessageBox.Show("Item Updated");
            PopulateSales();
        }

        private void PopulateSales()
        {
            SalesList.Items.Clear();
            comboBox1.Items.Clear();
            using (connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Sales", connection))
            {
                DataTable SalesTable = new DataTable();
                Adapter.Fill(SalesTable); 
                for (int i = 0; i < SalesTable.Rows.Count; i++)
                {
                    SalesList.Items.Add(SalesTable.Rows[i].Field<string>(1));
                    comboBox1.Items.Add(SalesTable.Rows[i].Field<string>(1));
                }
            }
        }

        private void SalesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Sales", connection))
            {
                DataTable SalesTable = new DataTable();
                Adapter.Fill(SalesTable);
                for (int i = 0; i < SalesTable.Rows.Count; i++)
                {
                    if (SalesList.SelectedItem.ToString() == SalesTable.Rows[i].Field<string>(1))
                    {
                        MessageBox.Show("Category " + SalesTable.Rows[i].Field<string>(3) + '\n' + "Quantity "+ Convert.ToString(SalesTable.Rows[i].Field<int>(2)) + '\n' + "Price " + Convert.ToString(SalesTable.Rows[i].Field<double>(5)));
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PharmancySales.ItemName = comboBox1.SelectedItem.ToString();
        }
    }
}
