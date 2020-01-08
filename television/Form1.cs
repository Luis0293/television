using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace television
{
    public partial class Form1 : Form
    {
        Televisao TV = new Televisao();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = TV.enviar;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = TV.enviar2;
            pictureBox4.Visible = TV.enviar;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = TV.enviar2;
            pictureBox5.Visible = TV.enviar;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = TV.enviar;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = TV.enviar;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = TV.enviar;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = TV.enviar;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = TV.enviar;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = TV.enviar;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = TV.enviar;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = TV.enviar;
        }
    }
}
