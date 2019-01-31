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
    public partial class AddVehicleForm : Form
    {
        public AddVehicleForm()
        {
            InitializeComponent();
            GetLists();
        }

        private void GetLists()
        {
            using (var context = new CarMechanicContext())
            {
                clientBindingSource.DataSource = context.Clients.ToList();
               
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var plateNo = plateNoTextBox.Text;
            var brand = brandTextBox.Text;
            var model = modelTextBox.Text;
            var colour = colourTextBox.Text;
            var year = Convert.ToInt32(yearTextBox.Text);
            var ownerId = (int)ownerComboBox.SelectedValue;

            var vehicle = new Vehicle
            {
                PlateNo = plateNo,
                Brand = brand,
                Model = model,
                Colour = colour,
                Year = year,
                ClientId = ownerId
            };

            using (var context = new CarMechanicContext())
            {
                context.Vehicles.Add(vehicle);
                context.SaveChanges();
            }

                this.Close();
        }
    }
}
