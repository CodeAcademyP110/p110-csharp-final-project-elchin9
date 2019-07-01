using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessForm.Model;

namespace FitnessForm
{
    public partial class AddServiceForm : Form
    {
        private readonly FitnessEntities _context;
        public AddServiceForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private async void btnAddNewService_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            decimal price = nmrService.Value;
            string time = txtTime.Text.Trim();
            if(name == string.Empty || time == string.Empty)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            _context.Services.Add(new Service
            {
                Name = name,
                Price = price,
                Time = time
            });
            await _context.SaveChangesAsync();
            MessageBox.Show("Service is Added");

            txtName.Text = "";
            txtTime.Text = "";
            nmrService.Value = 0;
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
