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

namespace HealthPharmacy
{
    public partial class Pharmacy : Form
    {
        SqlConnection connection;
        string ConnectionString;
        public Pharmacy()
        {
            InitializeComponent();
            ConnectionString = ConfigurationManager.ConnectionStrings["HealthPharmacy.Properties.Settings.ProductDatabaseConnectionString"].ConnectionString;
        }

        private void Pharmacy_Load(object sender, EventArgs e)
        {
            PopulateItem();
        }

        private void PopulateItem()
        {
            using (connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Items",connection))
            {
                //connection.Open();
                DataTable ItemTable = new DataTable();
                Adapter.Fill(ItemTable);
             /**   listItems.DisplayMember = "Name";
                listItems.ValueMember = "Manufacturer ";
                listItems.DataSource = ItemTable;**/
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
           Form2 HomePage = new Form2();
            HomePage.Show();
        }
    }
}
