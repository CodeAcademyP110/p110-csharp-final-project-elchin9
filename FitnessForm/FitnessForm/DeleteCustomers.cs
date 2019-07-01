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
    public partial class DeleteCustomers : Form
    {
        private readonly FitnessEntities _context;
        public DeleteCustomers()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteCustomers_Load(object sender, EventArgs e)
        {
            cmbDeleteCustomer.Items.AddRange(_context.Customers.ToArray());
        }

        private void cmbDeleteCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteCustomer.Visible = true;
        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            _context.Customers.Remove(cmbDeleteCustomer.SelectedItem as Customer);

            await _context.SaveChangesAsync();

            MessageBox.Show("Customer deleted");
            Close();
        }
    }
}
