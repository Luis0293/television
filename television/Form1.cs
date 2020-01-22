using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

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

        private void Button15_Click(object sender, EventArgs e)
        {
            
        }

        // MÚSICA
        private void Button16_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(television.Properties.Resources.Festa);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(television.Properties.Resources.Rodeo2);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(television.Properties.Resources.More_Sex_More_Bless);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            
        }
        // MÚSICA

        private void Button28_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(television.Properties.Resources.Festa);
                player.Stop();
                SoundPlayer player1 = new SoundPlayer(television.Properties.Resources.Rodeo2);
                player1.Stop();
                SoundPlayer player2 = new SoundPlayer(television.Properties.Resources.More_Sex_More_Bless);
                player2.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(television.Properties.Resources.Festa);
                player.Play();
                SoundPlayer player1 = new SoundPlayer(television.Properties.Resources.Rodeo2);
                player1.Play();
                SoundPlayer player2 = new SoundPlayer(television.Properties.Resources.More_Sex_More_Bless);
                player2.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            
        }
    }
}
