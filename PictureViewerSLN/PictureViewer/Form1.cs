using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Show the Open File Dialog. If the user clicks OK, 
             *load the picture tha the user chose.*/

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*Show the color dialog box. If the user clicks ok, change the             
              Picture Box control's background color to the color the user chose.*/

            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor= colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear the picture
            pictureBox1.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*
             if the user selects the Stretch check box,
            change the Picturebox
            sizemode property to "Stretch". if the user clears
            the check box, change it to "normal"
             */
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
   
            
        }
    }
}
