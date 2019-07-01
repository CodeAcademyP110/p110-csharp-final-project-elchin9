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
    public partial class AddCustomers : Form
    {
        private readonly FitnessEntities _context;
        public AddCustomers()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnAddCustomers_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text.Trim();
            string lname = txtLname.Text.Trim();

            if(fname == string.Empty || lname == string.Empty)
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            Customer thisCustomer = _context.Customers.Add(new Customer
            {
                Firstname = fname,
                Lastname = lname
            });

            await _context.SaveChangesAsync();

            Card thisCard = _context.Cards.Add(new Card
            {
                CustomerId = thisCustomer.Id,
                StartDate = DateTime.Now
            });

            await _context.SaveChangesAsync();

            pnlCard.Visible = true;
            lblHeadingCard.Visible = true;
            lblfname.Text = $"Firstname : {fname}";
            lblLastname.Text = $"Lastname : {lname}";
            lblCardNumber.Text = $"Serial Number : {thisCard.Id}";

            txtFname.Text = "";
            txtLname.Text = "";

            MessageBox.Show("Customers Added");
            Close();
        }
    }
}
