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
        public List<string> Items = new List<string>();
        public List<string> _Category = new List<string>();
        public List<int> _Quantity = new List<int>();
        public List<double> PurchaseCost = new List<double>();
        public List<string> ItemsMonth = new List<string>();
        public List<string> CategoryMonth = new List<string>();
        public List<int> _QuantityMonth = new List<int>();
        public List<double> PurchaseCostMonth = new List<double>();
        DateTime startTime = DateTime.UtcNow;
        DateTime startTime_secs = DateTime.UtcNow;
        TimeSpan breakDuration = TimeSpan.FromMinutes(2);
        TimeSpan breakDuration_secs = TimeSpan.FromSeconds(30);
        

        public Form2()
        {
            InitializeComponent();
            ConnectionString = ConfigurationManager.ConnectionStrings["HealthPharmacy.Properties.Settings.ProductDatabaseConnectionString"].ConnectionString;
            PopulateSales();
        }

        private void Salestab_Click(object sender, EventArgs e)
        {

        }

        private void AddSalesButton_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            PharmancySales.ItemQuantity = PharmancySales.ItemQuantity + 1;
            SqlCommand Command = new SqlCommand("INSERT INTO Sales VALUES('" + NameBox.Text + "','" + PharmancySales.ItemQuantity + "','" + CategoryBox.Text + "', '" + Convert.ToDouble(PurchaseBox.Text) + "','" + Convert.ToDouble(SalesBox.Text) + "')", connection);
            Command.ExecuteNonQuery();

            MessageBox.Show("New Item added");
            Items.Add(NameBox.Text);
            _Category.Add(CategoryBox.Text);
            _Quantity.Add(PharmancySales.ItemQuantity);
            PurchaseCost.Add(Convert.ToDouble(PurchaseBox.Text));
            ItemsMonth.Add(NameBox.Text);
            CategoryMonth.Add(CategoryBox.Text);
            _QuantityMonth.Add(PharmancySales.ItemQuantity);
            PurchaseCostMonth.Add(Convert.ToDouble(PurchaseBox.Text));

            SalesBox.Text = "";
            PurchaseBox.Text = "";
            CategoryBox.Text = "";
            NameBox.Text = "";
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
            EditNameBox.Text = "";
            EditCategoryBox.Text = "";
            EditPurchaseBox.Text = "";
            EditSalesBox.Text = "";
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

        private void MonthReportbutton_Click(object sender, EventArgs e)
        {
            if (DateTime.UtcNow - startTime > breakDuration)
            {
                MessageBox.Show("Report is avaliable");
                tabControl1.Show();
           
                startTime = DateTime.UtcNow;
            }
            else
            {
                MessageBox.Show("Report under constuction");
            }
          
        }

        private void PopulateMonthlyGrid()
        {
            for(int i=0;i<ItemsMonth.Count(); i++)
            {
                MonthlyView.Rows.Add(ItemsMonth[i],CategoryMonth[i],_QuantityMonth[i],PurchaseCostMonth[i]);
            }
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            MonthlyView.Rows.Clear(); // To clear yhe previous month data.
            PopulateMonthlyGrid();

            ItemsMonth.Clear();
            CategoryMonth.Clear();
            _QuantityMonth.Clear();
            PurchaseCostMonth.Clear();
        }

        private void WeekView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DateTime.UtcNow - startTime_secs > breakDuration_secs)
            {
                MessageBox.Show("Report is avaliable");

                startTime_secs = DateTime.UtcNow;
            }
            else
            {
                MessageBox.Show("Report under constuction");
            }
        }

        private void PopulateWeeklyGrid()
        {
            for (int i = 0; i < Items.Count(); i++)
            {
                WeekView.Rows.Add(Items[i], _Category[i], _Quantity[i], PurchaseCost[i]);
            }
        }

        private void View2button_Click(object sender, EventArgs e)
        {
            WeekView.Rows.Clear(); // To clear yhe previous month data.
            PopulateWeeklyGrid();

            Items.Clear();
            _Category.Clear();
            _Quantity.Clear();
            PurchaseCost.Clear();
        }
    }
}
