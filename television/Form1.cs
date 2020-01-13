using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace television
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        Televisao TV = new Televisao();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = TV.enviar2;
            pictureBox4.Visible = TV.enviar2;
            pictureBox5.Visible = TV.enviar2;
            pictureBox6.Visible = TV.enviar2;
            pictureBox7.Visible = TV.enviar2;
            pictureBox8.Visible = TV.enviar2;
            pictureBox9.Visible = TV.enviar2;
            pictureBox10.Visible = TV.enviar2;
            pictureBox11.Visible = TV.enviar2;
            pictureBox12.Visible = TV.enviar2;
            player.controls.stop();
            pictureBox3.Visible = TV.enviar;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = TV.enviar2;
            pictureBox4.Visible = TV.enviar2;
            pictureBox5.Visible = TV.enviar2;
            pictureBox6.Visible = TV.enviar2;
            pictureBox7.Visible = TV.enviar2;
            pictureBox8.Visible = TV.enviar2;
            pictureBox9.Visible = TV.enviar2;
            pictureBox10.Visible = TV.enviar2;
            pictureBox11.Visible = TV.enviar2;
            pictureBox12.Visible = TV.enviar2;
            pictureBox3.Visible = TV.enviar2;
            player.controls.stop();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = TV.enviar;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = TV.enviar2;
            pictureBox5.Visible = TV.enviar2;
            pictureBox6.Visible = TV.enviar2;
            pictureBox7.Visible = TV.enviar2;
            pictureBox8.Visible = TV.enviar2;
            pictureBox9.Visible = TV.enviar2;
            pictureBox10.Visible = TV.enviar2;
            pictureBox11.Visible = TV.enviar2;
            pictureBox12.Visible = TV.enviar2;
            player.controls.stop();
            pictureBox4.Visible = TV.enviar;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = TV.enviar2;
            pictureBox4.Visible = TV.enviar2;
            pictureBox6.Visible = TV.enviar2;
            pictureBox7.Visible = TV.enviar2;
            pictureBox8.Visible = TV.enviar2;
            pictureBox9.Visible = TV.enviar2;
            pictureBox10.Visible = TV.enviar2;
            pictureBox11.Visible = TV.enviar2;
            pictureBox12.Visible = TV.enviar2;
            player.controls.stop();
            pictureBox5.Visible = TV.enviar;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = TV.enviar2;
            pictureBox4.Visible = TV.enviar2;
            pictureBox5.Visible = TV.enviar2;
            pictureBox7.Visible = TV.enviar2;
            pictureBox8.Visible = TV.enviar2;
            pictureBox9.Visible = TV.enviar2;
            pictureBox10.Visible = TV.enviar2;
            pictureBox11.Visible = TV.enviar2;
            pictureBox12.Visible = TV.enviar2;
            player.controls.stop();
            pictureBox6.Visible = TV.enviar;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = TV.enviar2;
            pictureBox4.Visible = TV.enviar2;
            pictureBox5.Visible = TV.enviar2;
            pictureBox6.Visible = TV.enviar2;
            pictureBox8.Visible = TV.enviar2;
            pictureBox9.Visible = TV.enviar2;
            pictureBox10.Visible = TV.enviar2;
            pictureBox11.Visible = TV.enviar2;
            pictureBox12.Visible = TV.enviar2;
            player.controls.stop();
            pictureBox7.Visible = TV.enviar;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = TV.enviar2;
            pictureBox4.Visible = TV.enviar2;
            pictureBox5.Visible = TV.enviar2;
            pictureBox6.Visible = TV.enviar2;
            pictureBox7.Visible = TV.enviar2;
            pictureBox9.Visible = TV.enviar2;
            pictureBox10.Visible = TV.enviar2;
            pictureBox11.Visible = TV.enviar2;
            pictureBox12.Visible = TV.enviar2;
            player.controls.stop();
            pictureBox8.Visible = TV.enviar;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = TV.enviar2;
            pictureBox4.Visible = TV.enviar2;
            pictureBox5.Visible = TV.enviar2;
            pictureBox6.Visible = TV.enviar2;
            pictureBox7.Visible = TV.enviar2;
            pictureBox8.Visible = TV.enviar2;
            pictureBox10.Visible = TV.enviar2;
            pictureBox11.Visible = TV.enviar2;
            pictureBox12.Visible = TV.enviar2;
            player.controls.stop();
            pictureBox9.Visible = TV.enviar;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = TV.enviar2;
            pictureBox4.Visible = TV.enviar2;
            pictureBox5.Visible = TV.enviar2;
            pictureBox6.Visible = TV.enviar2;
            pictureBox7.Visible = TV.enviar2;
            pictureBox8.Visible = TV.enviar2;
            pictureBox9.Visible = TV.enviar2;
            pictureBox11.Visible = TV.enviar2;
            pictureBox12.Visible = TV.enviar2;
            player.controls.stop();
            pictureBox10.Visible = TV.enviar;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = TV.enviar2;
            pictureBox4.Visible = TV.enviar2;
            pictureBox5.Visible = TV.enviar2;
            pictureBox6.Visible = TV.enviar2;
            pictureBox7.Visible = TV.enviar2;
            pictureBox8.Visible = TV.enviar2;
            pictureBox9.Visible = TV.enviar2;
            pictureBox10.Visible = TV.enviar2;
            pictureBox12.Visible = TV.enviar2;
            player.controls.stop();
            pictureBox11.Visible = TV.enviar;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = TV.enviar2;
            pictureBox4.Visible = TV.enviar2;
            pictureBox5.Visible = TV.enviar2;
            pictureBox6.Visible = TV.enviar2;
            pictureBox7.Visible = TV.enviar2;
            pictureBox8.Visible = TV.enviar2;
            pictureBox9.Visible = TV.enviar2;
            pictureBox10.Visible = TV.enviar2;
            pictureBox11.Visible = TV.enviar2;
            player.controls.stop();
            pictureBox12.Visible = TV.enviar;
        }

        private void Button13_Click(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {

        }

        private void Button15_Click(object sender, EventArgs e)
        {
            
        }

        // MÚSICA
        private void Button16_Click(object sender, EventArgs e)
        {
            player.URL = "Mocca.mp3";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            player.URL = "Rodeo.mp3";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            player.URL = "Baby Momma.mp3";
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            player.URL = "More Sex More Bless.mp3";
        }
        // MÚSICA

        private void Button28_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }
    }
}
