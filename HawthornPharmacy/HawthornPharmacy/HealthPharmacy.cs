using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HawthornPharmacy;
using System.Configuration;
using System.Data.SqlClient;

namespace HawthornPharmacy
{
    public partial class HealthPharmacy : Form
    {
        public HealthPharmacy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemForm HomePage = new ItemForm();
            HomePage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalesForm HomePage = new SalesForm();
            HomePage.Show();
        }
    }
}
