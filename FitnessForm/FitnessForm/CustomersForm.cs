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
    public partial class CustomersForm : Form
    {
        private readonly FitnessEntities _context;
        public CustomersForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            Load_Customers();
        }
        private void Load_Customers()
        {
            dgwCustomers.DataSource = _context.Cards.Select(c => new {
                c.Customer.Firstname,
                c.Customer.Lastname,
                c.StartDate,
                Serial_Number = c.Id
            }).ToList();
        }
        private void CustomersClosed(object sender, EventArgs e)
        {
            Load_Customers();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddCustomers addCust = new AddCustomers();
            addCust.FormClosed += CustomersClosed;
            addCust.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UpdateCustomer upCust = new UpdateCustomer();
            upCust.FormClosed += CustomersClosed;
            upCust.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DeleteCustomers delCust = new DeleteCustomers();
            delCust.FormClosed += CustomersClosed;
            delCust.ShowDialog();
        }
    }
}
