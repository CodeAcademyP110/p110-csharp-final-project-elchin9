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
    public partial class AddPacketsForm : Form
    {
        private readonly FitnessEntities _context;
        public AddPacketsForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnAddNewService_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            decimal price = nmrService.Value;
            string days = txtDays.Text.Trim();
            string hours = txtHours.Text.Trim();

            if (name == string.Empty || days == string.Empty || hours == string.Empty)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            Packet thisPacket = _context.Packets.Add(new Packet
            {
                Name = name,
                Price = price,
                Days = days,
                Hours = hours
            });

            await _context.SaveChangesAsync();

            if(chcGYM.Checked)
            {
                _context.FitPacks.Add(new FitPack
                {
                    PacketId = thisPacket.Id,
                    ServiceId = 1
            });
            }
            if (chcSauna.Checked)
            {
                _context.FitPacks.Add(new FitPack
                {
                    PacketId = thisPacket.Id,
                    ServiceId = 2
                });
            }
            if (chcPool.Checked)
            {
                _context.FitPacks.Add(new FitPack
                {
                    PacketId = thisPacket.Id,
                    ServiceId = 3
                });
            }
            if (chcMassage.Checked)
            {
                _context.FitPacks.Add(new FitPack
                {
                    PacketId = thisPacket.Id,
                    ServiceId = 4
                });
            }

            await _context.SaveChangesAsync();
            MessageBox.Show("Packet is Added");

            txtDays.Text = "";
            txtHours.Text = "";
            txtName.Text = "";
            nmrService.Value = 0;
            Close();
        }

      
    }
}
