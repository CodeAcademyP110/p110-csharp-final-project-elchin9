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
    public partial class PacketsForm : Form
    {
        private readonly FitnessEntities _context;
        public PacketsForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PacketsForm_Load(object sender, EventArgs e)
        {
            Load_Packets();
        }
        private void Load_Packets()
        {
            dgwPackets.DataSource = _context.Packets.Select(s => new {
                s.Name,
                s.Price,
                s.Days,
                s.Hours
            }).ToList();
        }
        private void ClosedLoadPackets(object sender, EventArgs e)
        {
            Load_Packets();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddPacketsForm addPack = new AddPacketsForm();
            addPack.FormClosed += ClosedLoadPackets;
            addPack.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UpdatePacket upPack = new UpdatePacket();
            upPack.FormClosed += ClosedLoadPackets;
            upPack.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DeletePackets delPack = new DeletePackets();
            delPack.FormClosed += ClosedLoadPackets;
            delPack.ShowDialog();
        }
    }
}
