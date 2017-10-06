using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using HawthornPharmacy;

namespace HawthornPharmacy
{
    public partial class ItemForm : Form
    {
        string ConnectionString;
        SqlConnection Connection;
        Item item = new Item();

        public ItemForm()
        {
            InitializeComponent();
            ConnectionString = ConfigurationManager.ConnectionStrings["HawthornPharmacy.Properties.Settings.PharmacyConnectionString"].ConnectionString;
            PopulateItems();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {

        }

        private void PopulateItems()
        {
            EditcomboBox.Items.Clear();
            DisplaycomboBox.Items.Clear();
            using (Connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Item", Connection))
            {
                DataTable ItemTable = new DataTable();
                Adapter.Fill(ItemTable);
                for (int i = 0; i < ItemTable.Rows.Count; i++)
                {
                    DisplaycomboBox.Items.Add(ItemTable.Rows[i].Field<string>(1));
                    EditcomboBox.Items.Add(ItemTable.Rows[i].Field<string>(1));
                }
            }
        }

        private void DisplaycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Item", Connection))
            {
                DataTable ItemTable = new DataTable();
                Adapter.Fill(ItemTable);
                for (int i = 0; i < ItemTable.Rows.Count; i++)
                {
                    if (DisplaycomboBox.SelectedItem.ToString() == ItemTable.Rows[i].Field<string>(1))
                    {
                        MessageBox.Show("Name " + ItemTable.Rows[i].Field<string>(1) + '\n' + "Quantity " + ItemTable.Rows[i].Field<int>(2) + '\n' + "Price " + Convert.ToString(ItemTable.Rows[i].Field<double>(3)));
                    }
                }
            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            // Connection = new SqlConnection(ConnectionString);
            //Connection.Open();

            Connection = new SqlConnection(ConnectionString);
            Connection.Open();

            if (EditName.Text != "")
            {
                item.Name = EditName.Text;
                SqlCommand Command = new SqlCommand("UPDATE Item SET Name = '" + item.Name + "' WHERE Name = '" + item.Name + "';", Connection);
                Command.ExecuteNonQuery();
            }
            if (EditCategory.Text != "")
            {
                item.category = EditCategory.Text;
                SqlCommand Command = new SqlCommand("UPDATE Item SET Purpose = '" + item.category + "' WHERE Name = '" + item.Name + "';", Connection);
                Command.ExecuteNonQuery();
            }
            if (EditPurchase.Text != "")
            {
                item.price = Convert.ToDouble(EditPurchase.Text);
                SqlCommand Command = new SqlCommand("UPDATE Item SET PurchasePrice = '" + item.price + "' WHERE Name = '" + item.Name + "';", Connection);
                Command.ExecuteNonQuery();
            }
            if (EditSales.Text != "")
            {
                item.SalesPrice = Convert.ToDouble(EditSales.Text);
                SqlCommand Command = new SqlCommand("UPDATE Item SET SalesPrice = '" + item.SalesPrice + "' WHERE Name = '" + item.Name + "';", Connection);
                Command.ExecuteNonQuery();
            }
            if (EditQuantity.Text != "")
            {
                item._Quantity = Convert.ToInt32(EditQuantity.Text);
                SqlCommand Command = new SqlCommand("UPDATE Item SET Quantity = '" + item._Quantity + "' WHERE Name = '" + item.Name + "';", Connection);
                Command.ExecuteNonQuery();
            }
            if (EditMaker.Text != "")
            {
                item.Maker = EditMaker.Text;
                SqlCommand Command = new SqlCommand("UPDATE Item SET Manufacturer = '" + item.Maker + "' WHERE Name = '" + item.Name + "';", Connection);
                Command.ExecuteNonQuery();
            }

            MessageBox.Show("Item Updated");
            EditName.Text = "";
            EditCategory.Text = "";
            EditPurchase.Text = "";
            EditMaker.Text = "";
            EditSales.Text = "";
            EditQuantity.Text = "";
            PopulateItems();
        }

        private void EditcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Item", Connection))
            {
                DataTable ItemTable = new DataTable();
                Adapter.Fill(ItemTable);
                for (int i = 0; i < ItemTable.Rows.Count; i++)
                {
                    if (EditcomboBox.SelectedItem.ToString() == ItemTable.Rows[i].Field<string>(1))
                    {
                        EditName.Text = ItemTable.Rows[i].Field<string>(1);
                        EditQuantity.Text = Convert.ToString(ItemTable.Rows[i].Field<int>(2));
                        EditPurchase.Text = Convert.ToString(ItemTable.Rows[i].Field<double>(4));
                        EditSales.Text = Convert.ToString(ItemTable.Rows[i].Field<double>(3));
                        EditMaker.Text = ItemTable.Rows[i].Field<string>(6);
                        EditCategory.Text = ItemTable.Rows[i].Field<string>(5);
                    }
                }
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            item._Quantity = item._Quantity + 1;
            SqlCommand Command = new SqlCommand("INSERT INTO Item VALUES('" + AddName.Text + "','" + Convert.ToInt32(AddQuantity.Text) + "','" + Convert.ToDouble(AddSales.Text) + "', '" + Convert.ToDouble(AddPurchase.Text) + "','"+ AddCategory.Text + "' , '" + AddMaker.Text + "')", Connection);
            Command.ExecuteNonQuery();

            MessageBox.Show("New Item added");

            AddMaker.Text = "";
            AddPurchase.Text = "";
            AddCategory.Text = "";
            AddName.Text = "";
            AddSales.Text = "";
            AddQuantity.Text = "";
            PopulateItems();
        }
    }
}
