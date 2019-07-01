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
    public partial class DeletePackets : Form
    {
        private readonly FitnessEntities _context;
        public DeletePackets()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeletePackets_Load(object sender, EventArgs e)
        {
            cmbDeletePackets.Items.AddRange(_context.Packets.ToArray());
        }

        private async void btnDeletePacket_Click(object sender, EventArgs e)
        {
            _context.Packets.Remove(cmbDeletePackets.SelectedItem as Packet);

            await _context.SaveChangesAsync();
            MessageBox.Show("Packet Deleted");

            Close();
        }

        private void cmbDeletePackets_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeletePacket.Visible = true;
        }
    }
}
