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
    public partial class UpdatePacket : Form
    {
        private readonly FitnessEntities _context;
        public UpdatePacket()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlUpdateInner.Visible = true;
            Packet selectedPacket = cmbPackets.SelectedItem as Packet;
            txtUpdateName.Text = selectedPacket.Name;
            txtUpdateDays.Text = selectedPacket.Days;
            nmrUpdatePrice.Value = (decimal)selectedPacket.Price;
            txtUpdateHours.Text = selectedPacket.Hours;
        }

        private void UpdatePacket_Load(object sender, EventArgs e)
        {
            cmbPackets.Items.AddRange(_context.Packets.ToArray());
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtUpdateName.Text.Trim();
            string days = txtUpdateDays.Text.Trim();
            string hours = txtUpdateHours.Text.Trim();
            decimal price = nmrUpdatePrice.Value;
            if (name == string.Empty || days == string.Empty || hours == string.Empty)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            Packet selectedPacket = cmbPackets.SelectedItem as Packet;
            selectedPacket.Name = name;
            selectedPacket.Days = days;
            selectedPacket.Hours = hours;
            selectedPacket.Price = price;

            await _context.SaveChangesAsync();
            MessageBox.Show("Packets is Update");

            Close();
        }
    }
}
