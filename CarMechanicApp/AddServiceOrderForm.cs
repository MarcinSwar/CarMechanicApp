using CarMechanicApp.Data;
using CarMechanicApp.Models;
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
    public partial class AddServiceOrderForm : Form
    {
        public AddServiceOrderForm()
        {
            InitializeComponent();
            GetLists();
        }
        private void GetLists() {
            using (var context = new CarMechanicContext())
            {
                mechanicBindingSource.DataSource = context.Mechanics.ToList();
                vehicleBindingSource.DataSource = context.Vehicles.ToList();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var mechanicId = (int)mechanicComboBox.SelectedValue;
            var vechicleId = (int)vehicleComboBox.SelectedValue;
            //MessageBox.Show(mechanicId.ToString(), vechicleId.ToString());
            var serviceOrder = new ServiceOrder
            {
                StartDate = DateTime.Now,
                MechanicId = mechanicId,
                VehicleId = vechicleId,
                Description = descriptionRichTextBox.Text

            };

            using (var context = new CarMechanicContext())
            {
                context.ServiceOrders.Add(serviceOrder);
                context.SaveChanges();
            }

            this.Close();
        }
    }
}
