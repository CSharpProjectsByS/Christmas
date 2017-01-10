using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Święta
{
    public partial class Form1 : Form
    {
        private ChangeWordService changeWS;
        private ChangeWorldHandler changeWH;

        public Form1()
        {
            InitializeComponent();
            TreePanel.Parent = pictureBox1;
            BearPanel.Parent = pictureBox1;
            GiftsPanel.Parent = pictureBox1;
            ReindeerPanel.Parent = pictureBox1;
            SantaPanel.Parent = pictureBox1;
            SnowManPanel.Parent = pictureBox1;

            initChangeWordCopmonents();
        }

        public void initChangeWordCopmonents()
        {
            changeWS = new ChangeWordService();
            changeWH = new ChangeWorldHandler(MessageLabel);

            changeWS.ChangeWordEvent += changeWH.ChangeWorld;
        }

        private void TreePanel_Paint(object sender, PaintEventArgs e)
        {
            TreePanel.BackColor = Color.FromArgb(1, 0, 0, 0);
        }

        private void TreePanel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Drawer");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Tu się rozpoczyna życie

        private void TreePanel_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Drawer");
            changeWS.ChooseKlickedElement("Christmas Tree");
        }

        private void BearPanel_Click(object sender, EventArgs e)
        {
            changeWS.ChooseKlickedElement("Teddy Bear");
        }

        private void SnowManPanel_Click(object sender, EventArgs e)
        {
            changeWS.ChooseKlickedElement("Snowman");
        }

        private void GiftsPanel_Click(object sender, EventArgs e)
        {
            changeWS.ChooseKlickedElement("Gifts");
        }

        private void ReindeerPanel_Click(object sender, EventArgs e)
        {
            changeWS.ChooseKlickedElement("Reindeer");
        }

        private void SantaPanel_Click(object sender, EventArgs e)
        {
            changeWS.ChooseKlickedElement("Santa Claus");
        }
    }
}
