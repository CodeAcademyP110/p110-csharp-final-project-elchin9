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
    public partial class SalesForm : Form
    {
        private readonly FitnessEntities _context;
        public SalesForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            string[] menu = new string[] { "All", "Services", "Packets", "Employee"};

            cmbOr.Items.AddRange(menu);
            cmbOr.SelectedIndex = 0;
            dgwSales.DataSource = _context.OrderDetails.Select(o => new
            {
                Employee = o.Order.User.Username,
                o.Card.Customer.Firstname,
                o.Card.Customer.Lastname,
                Service = o.Service.Name,
                Packet = o.Packet.Name,
                o.Price,
                o.Order.Date
            }).ToList();
        }

        private void cmbOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbOr.SelectedItem.ToString() == "All")
            {
                lblService.Visible = false;
                lblPacket.Visible = false;
                cmbPacket.Visible = false;
                cmbService.Visible = false;
                lblUsers.Visible = false;
                cmbUsers.Visible = false;
                dgwSales.DataSource = _context.OrderDetails.Select(o => new
                {
                    Employee = o.Order.User.Username,
                    o.Card.Customer.Firstname,
                    o.Card.Customer.Lastname,
                    Service = o.Service.Name,
                    Packet = o.Packet.Name,
                    o.Price,
                    o.Order.Date
                }).ToList();
                lblHeading.Text = "All Sales";
            }
            if(cmbOr.SelectedItem.ToString() == "Services")
            {
                lblService.Visible = true;
                lblPacket.Visible = false;
                cmbPacket.Visible = false;
                cmbService.Visible = true;
                lblUsers.Visible = false;
                cmbUsers.Visible = false;
                cmbService.Items.AddRange(_context.Services.ToArray());
            }
            if (cmbOr.SelectedItem.ToString() == "Packets")
            {
                lblPacket.Visible = true;
                cmbPacket.Visible = true;
                lblService.Visible = false;
                cmbService.Visible = false;
                lblUsers.Visible = false;
                cmbUsers.Visible = false;
                cmbPacket.Items.AddRange(_context.Packets.ToArray());
            }
            if (cmbOr.SelectedItem.ToString() == "Employee")
            {
                lblPacket.Visible = false;
                cmbPacket.Visible = false;
                lblService.Visible = false;
                cmbService.Visible = false;
                lblUsers.Visible = true;
                cmbUsers.Visible = true;
                cmbUsers.Items.AddRange(_context.Users.ToArray());
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User thisUser = cmbUsers.SelectedItem as User;
            dgwSales.DataSource = _context.OrderDetails.Where(o => o.Order.UserId == thisUser.Id).Select(o => new
            {
                Employee = o.Order.User.Username,
                o.Card.Customer.Firstname,
                o.Card.Customer.Lastname,
                Service = o.Service.Name,
                Packet = o.Packet.Name,
                o.Price,
                o.Order.Date
            }).ToList();
            lblHeading.Text = $"{thisUser.Username} Sales";
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            Service thisService = cmbService.SelectedItem as Service;
            dgwSales.DataSource = _context.OrderDetails.Where(o => o.ServiceId == thisService.Id).Select(o => new
            {
                Employee = o.Order.User.Username,
                o.Card.Customer.Firstname,
                o.Card.Customer.Lastname,
                Service = o.Service.Name,
                Packet = o.Packet.Name,
                o.Price,
                o.Order.Date
            }).ToList();
            lblHeading.Text = $"{thisService.Name} Sales";
        }

        private void cmbPacket_SelectedIndexChanged(object sender, EventArgs e)
        { 
            Packet thisPacket = cmbPacket.SelectedItem as Packet;
            dgwSales.DataSource = _context.OrderDetails.Where(o => o.PackedId == thisPacket.Id).Select(o => new
            {
                Employee = o.Order.User.Username,
                o.Card.Customer.Firstname,
                o.Card.Customer.Lastname,
                Service = o.Service.Name,
                Packet = o.Packet.Name,
                o.Price,
                o.Order.Date
            }).ToList();
            lblHeading.Text = $"{thisPacket.Name} Sales";
        }
    }

}
