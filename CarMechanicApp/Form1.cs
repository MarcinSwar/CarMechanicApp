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
    }
}
