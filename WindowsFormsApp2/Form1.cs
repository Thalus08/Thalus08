using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Resources;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Music Player
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();
        }


        private void showleader_Button_Click(object sender, EventArgs e)
        {
            showleader_Label.Text = "Roi is the leader";
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void backgroundpic_Button_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void clearpic_Button_Click(object sender, EventArgs e)
        {
            // Clear the picture
            pictureBox1.Image = null;
        }

        private void showpic_Button_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);

                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box, 
            // change the PictureBox's
            // SizeMode property to "Stretch". If the user clears 
            // the check box, change it to "Normal".
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        int temp = 1;
        private void mathgame_Button_Click(object sender, EventArgs e)
        {
            temp *= -1;
            if (temp == -1)
            {
                Bitmap b = new Bitmap(@"C:\Users\Lenovo\Downloads\All Genshin Emotes-Stickers (PNG ver)\Paimon_s Paintings\Set 10\Shiki Taishou 1.PNG");
                mathgame_Button.BackgroundImage = b;
            }
            else
            {
                Bitmap b = new Bitmap(global::WindowsFormsApp2.Properties.Resources.Raiden_Shogun_41);
                mathgame_Button.BackgroundImage = b;
            }


        }
    }
}
