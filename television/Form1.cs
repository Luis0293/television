﻿using System;
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
            pictureBox12.Visible = TV.enviar;
        }

        private void Button13_Click(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {

        }

        // Música
        private void Button16_Click(object sender, EventArgs e)
        {
            //My.Computer.Audio.Play(My.Resources.Rodeo_2);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "/Resources/Rodeo 2.wav";
            player.Play();
        }
    }
}
