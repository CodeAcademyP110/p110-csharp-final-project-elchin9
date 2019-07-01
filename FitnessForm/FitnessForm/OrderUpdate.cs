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
    public partial class OrderUpdate : Form
    {
        private readonly FitnessEntities _context;
        public OrderUpdate()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderUpdate_Load(object sender, EventArgs e)
        {
            cmbOrders.Items.AddRange(_context.OrderDetails.ToArray());
        }

        private void cmbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOr.Items.Clear();
            cmbPacket.Items.Clear();
            cmbService.Items.Clear();
            pnlOrders.Visible = true;
            OrderDetail thisOrder = cmbOrders.SelectedItem as OrderDetail;
            string[] menu = new string[] { "Services", "Packets" };
            cmbOr.Items.AddRange(menu);

            if (thisOrder.ServiceId == null)
            {
                cmbOr.SelectedIndex = 1;
                lblPacket.Visible = true;
                cmbPacket.Visible = true;
                lblService.Visible = false;
                cmbService.Visible = false;
                cmbPacket.Items.AddRange(_context.Packets.ToArray());
                cmbService.Items.AddRange(_context.Services.ToArray());
                cmbPacket.SelectedItem = thisOrder.Packet;
            }
            if(thisOrder.PackedId == null)
            {
                cmbOr.SelectedIndex = 0;
                lblPacket.Visible = false;
                cmbPacket.Visible = false;
                lblService.Visible = true;
                cmbService.Visible = true;
                cmbService.Items.AddRange(_context.Services.ToArray());
                cmbPacket.Items.AddRange(_context.Packets.ToArray());
                cmbService.SelectedItem = thisOrder.Service;
            }

        }

        private void cmbOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cmbOr.SelectedItem as string;

            if (selectedItem == "Services")
            {
                lblPacket.Visible = false;
                cmbPacket.Visible = false;
                lblService.Visible = true;
                cmbService.Visible = true;
            }
            if (selectedItem == "Packets")
            {
                lblPacket.Visible = true;
                cmbPacket.Visible = true;
                lblService.Visible = false;
                cmbService.Visible = false;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            OrderDetail thisOrder = cmbOrders.SelectedItem as OrderDetail;
            string selectedItem = cmbOr.SelectedItem as string;
            Packet thisPacket = cmbPacket.SelectedItem as Packet;
            Service thisService = cmbService.SelectedItem as Service;
            if (selectedItem == "Services")
            {
                thisOrder.ServiceId = thisService.Id;
                thisOrder.PackedId = null;
            }
            if (selectedItem == "Packets")
            {
                thisOrder.ServiceId = null;
                thisOrder.PackedId = thisPacket.Id;
            }

            await _context.SaveChangesAsync();

            Close();
        }
    }
}
