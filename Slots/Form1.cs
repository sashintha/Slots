using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slots
{
    public partial class Form1 : Form
    {
        //Variables
        int num1, num2, num3, points = 100;
        Random box1 = new Random();
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picPlayAgain_Click(object sender, EventArgs e)
        {
            
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPoints_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            points = points - 10;
            lblPoints.Text = points.ToString();
            //Slot Number One
            num1 = box1.Next(1, 4);
            if (num1 == 1)
            {
                slot1.Image = Properties.Resources.Bar;
            }
            if (num1 == 2)
            {
                slot1.Image = Properties.Resources.Bar5;
            }
            if (num1 == 3)
            {
                slot1.Image = Properties.Resources.Cherry;
            }
            //Slot Number Two
            num2 = box1.Next(1, 4);
            if (num2 == 1)
            {
                slot2.Image = Properties.Resources.Bar;
            }
            if (num2 == 2)
            {
                slot2.Image = Properties.Resources.Bar5;
            }
            if (num2 == 3)
            {
                slot2.Image = Properties.Resources.Cherry;
            }
            //Slot Number Three
            num3 = box1.Next(1, 4);
            if (num3 == 3) num3 = box1.Next(1, 4);
            if (num3 == 3) num3 = box1.Next(1, 4);

            if (num3 == 1)
            {
                slot3.Image = Properties.Resources.Bar;
            }
            if (num3 == 2)
            {
                slot3.Image = Properties.Resources.Bar5;
            }
            if (num3 == 3)
            {
                slot3.Image = Properties.Resources.Cherry;
            }
            //Getting all Bar
            if (num1 == 1 && num2 == 1 && num3 == 1)
            {
                points = points + 100;
                lblPoints.Text = points.ToString();
                MessageBox.Show("You Won!, you have " + points + " points.");
            }
            //Getting all Bar5
            if (num1 == 2 && num2 == 2 && num3 == 2)
            {
                points = points + 100;
                lblPoints.Text = points.ToString();
                MessageBox.Show("You Won!, you have " + points + " points.");
            }
            //Getting all Cherries
            if (num1 == 3 && num2 == 3 && num3 == 3)
            {
                points = points + 100;
                lblPoints.Text = points.ToString();
                MessageBox.Show("You Won!, you have " + points + " points.");
            }

            //Lost Game
            if(points <= 0)
            {
                MessageBox.Show("You are out of points, better luck next time!");
                btnNo.Visible = true;
                btnYes.Visible = true;
                lblPlayAgain.Visible = true;
                picPlayAgain.Visible = true;
            }


        }
    }
}
