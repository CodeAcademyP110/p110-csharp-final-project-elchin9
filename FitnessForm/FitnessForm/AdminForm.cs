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
    public partial class AdminForm : Form
    {
        private readonly FitnessEntities _context;
        public AdminForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Load_Runner();
        }
        private void Load_Runner()
        {
            runner.Height = btnHome.Height;
            runner.Top = btnHome.Top;
        }
        private void ClosedRunner(object sender, EventArgs e)
        {
            Load_Runner();
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            runner.Height = btnSales.Height;
            runner.Top = btnSales.Top;
            SalesForm salesForm = new SalesForm();
            salesForm.FormClosed += ClosedRunner;
            salesForm.ShowDialog();
        }

        private void btnFInance_Click(object sender, EventArgs e)
        {
            runner.Height = btnFInance.Height;
            runner.Top = btnFInance.Top;
            RevenueForm revenueForm = new RevenueForm();
            revenueForm.FormClosed += ClosedRunner;
            revenueForm.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm();
            serviceForm.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            PacketsForm packetForm = new PacketsForm();
            packetForm.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            EmployeeForm empForm = new EmployeeForm();
            empForm.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            CustomersForm custForm = new CustomersForm();
            custForm.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OrderForm ordForm = new OrderForm();
            ordForm.ShowDialog();
        }
    }
}
