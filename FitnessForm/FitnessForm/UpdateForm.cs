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
    public partial class UpdateForm : Form
    {
        private readonly FitnessEntities _context;
        public UpdateForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            cmbService.Items.AddRange(_context.Services.ToArray());
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUpdateName.Text == string.Empty || txtUpdateTime.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            Service selectedService = cmbService.SelectedItem as Service;
            selectedService.Name = txtUpdateName.Text.Trim();
            selectedService.Price = nmrUpdatePrice.Value;
            selectedService.Time = txtUpdateTime.Text.Trim();

            await _context.SaveChangesAsync();

            MessageBox.Show("Service is Update");
            Close();

            txtUpdateName.Text = "";
            txtUpdateTime.Text = "";
            nmrUpdatePrice.Value = 0;
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlUpdateInner.Visible = true;
            Service selectedService = cmbService.SelectedItem as Service;
            txtUpdateName.Text = selectedService.Name;
            nmrUpdatePrice.Value = (decimal)selectedService.Price;
            txtUpdateTime.Text = selectedService.Time;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
