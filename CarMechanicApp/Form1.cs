using CarMechanicApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarMechanicApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GetLists();
        }

        private void GetLists()
        {
            using (var context = new CarMechanicContext())
            {
                serviceOrderBindingSource.DataSource = context.ServiceOrders.ToList();
                vehicleBindingSource.DataSource = context.Vehicles.ToList();
                clientBindingSource.DataSource = context.Clients.ToList();
                mechanicBindingSource.DataSource = context.Mechanics.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CarMechanicApp ver 1.0");
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void serviceOrderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
