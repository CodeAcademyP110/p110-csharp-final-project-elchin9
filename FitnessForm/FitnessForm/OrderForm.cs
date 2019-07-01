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
    public partial class OrderForm : Form
    {
        private readonly FitnessEntities _context;
        public OrderForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            Load_Orders();
        }
        private void Load_Orders()
        {
            dgwOrders.DataSource = _context.OrderDetails.Select(o => new {
                o.Card.Customer.Firstname,
                o.Card.Customer.Lastname,
                Service = o.Service.Name,
                Packet = o.Packet.Name,
                Employee = o.Order.User.Username,
                o.Order.Date
            }).ToList();
        }
        private void OrderClosed(object sender, EventArgs e)
        {
            Load_Orders();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OrderUpdate ordUp = new OrderUpdate();
            ordUp.FormClosed += OrderClosed;
            ordUp.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DeleteOrder delOrd = new DeleteOrder();
            delOrd.FormClosed += OrderClosed;
            delOrd.ShowDialog();
        }
    }
}
