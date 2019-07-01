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
    public partial class DeleteOrder : Form
    {
        private readonly FitnessEntities _context;
        public DeleteOrder()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteOrder_Load(object sender, EventArgs e)
        {
            cmbDeleteOrder.Items.AddRange(_context.Orders.ToArray());
        }

        private void cmbDeleteOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteOrder.Visible = true;

        }

        private async void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            Order thisOrder = cmbDeleteOrder.SelectedItem as Order;
            OrderDetail thisOrderDetail =_context.OrderDetails.FirstOrDefault(o => o.OrderId == thisOrder.Id);
            _context.Orders.Remove(thisOrder);
            _context.OrderDetails.Remove(thisOrderDetail);

            await _context.SaveChangesAsync();

            Close();
        }
    }
}
