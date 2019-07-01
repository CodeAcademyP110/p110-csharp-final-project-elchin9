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
    public partial class RevenueForm : Form
    {
        private readonly FitnessEntities _context;
        public RevenueForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void pnlFinance_Paint(object sender, PaintEventArgs e)
        {
            dgwFInance.DataSource = _context.Revenues.Select(r => new {
                Service = r.OrderDetail.Service.Name,
                Packet = r.OrderDetail.Packet.Name,
                Employee =  r.OrderDetail.Order.User.Username,
                r.Price
            }).ToList();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            lblDgwHeading.Text = "Revenue";
            dgwFInance.DataSource = _context.Revenues.Select(r => new {
                Service = r.OrderDetail.Service.Name,
                Packet = r.OrderDetail.Packet.Name,
                Employee =  r.OrderDetail.Order.User.Username,
                r.Price
            }).ToList();
            pnlNet.Visible = false;
            dgwFInance.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            lblDgwHeading.Text = "Expenses";
            dgwFInance.DataSource = _context.Expenses.Select(r => new {
                r.Reason,
                r.Amount
            }).ToList();
            pnlNet.Visible = false;
            dgwFInance.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            lblDgwHeading.Text = "Net Revenue";
            pnlNet.Visible = true;
            dgwFInance.Visible = false;
            var RevenueSum =  _context.Revenues.Sum(r => r.Price);
            var ExpensesSum = _context.Expenses.Sum(r => r.Amount);
            

            if (ExpensesSum == null)
            {
                ExpensesSum = 0;
            }
            if (RevenueSum == null)
            {
                RevenueSum = 0;
            }

            nmrcRevenue.Value = (decimal)RevenueSum;
            nmrcExpenses.Value = (decimal)ExpensesSum;
            var Net = RevenueSum - ExpensesSum;
            nmrcNet.Value = (decimal)Net;
        }
    }
}
