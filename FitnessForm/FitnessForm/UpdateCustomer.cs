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
    public partial class UpdateCustomer : Form
    {
        private readonly FitnessEntities _context;
        public UpdateCustomer()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            cmbcustomer.Items.AddRange(_context.Customers.ToArray());
        }

        private void cmbcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer selectedCustomer = cmbcustomer.SelectedItem as Customer;
            pnlCustomer.Visible = true;
            txtFname.Text = selectedCustomer.Firstname;
            txtLname.Text = selectedCustomer.Lastname;
        }

        private async void btnAddCustomers_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text.Trim();
            string lname = txtLname.Text.Trim();

            if (fname == string.Empty || lname == string.Empty)
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            Customer selectedCustomer = cmbcustomer.SelectedItem as Customer;

            selectedCustomer.Firstname = fname;
            selectedCustomer.Lastname = lname;

            await _context.SaveChangesAsync();

            MessageBox.Show("Customer has been Update");
            Close();

            txtFname.Text = "";
            txtLname.Text = "";
        }
    }
}
