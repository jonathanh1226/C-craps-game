using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craps
{
    public partial class Form1 : Form
    {
        Image img1, img2;
        int dice1, dice2;
        int Sum = 0;
        bool attempt = true;
        int attempt2 = 0;
        int result1 = 0;
        int result2 = 0;
        Random rnd = new Random();
        String lose = "YOU LOSE";
        String win = "YOU WIN!";
        String draw = "YOU DRAW";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }
        private void getRandom()
        {
            result1 = rnd.Next(1,7);
            result2 = rnd.Next(1,7);
            Sum = (result1 + result2);

        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            //Reads from the "Roll Dice" class
            playGame();
          

        }
        private void playGame()
        {
            getRandom();
            if(attempt)
            {
                RollDie();
            }
            else
            {
                RollDie0();
            }
        }
        private void RollDie()
        {
            if (result1 == 1)
            {
                img1 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 1.png");

                pictureBox1.Image = img1;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result1 == 2)
            {
                img1 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 2.png");

                pictureBox1.Image = img1;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result1 == 3)
            {
                img1 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 3.png");

                pictureBox1.Image = img1;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result1 == 4)
            {
                img1 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 4.png");

                pictureBox1.Image = img1;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result1 == 5)
            {
                img1 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 5.png");

                pictureBox1.Image = img1;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {

                img1 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 6.png");

                pictureBox1.Image = img1;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
            //picturebox 2 and dice 2 
            if (result2 == 1)
            {
                img2 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 1.png");

                pictureBox2.Image = img2;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result2 == 2)
            {
                img2 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 2.png");

                pictureBox2.Image = img2;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result2 == 3)
            {
                img2 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 3.png");

                pictureBox2.Image = img2;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result2 == 4)
            {
                img2 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 4.png");

                pictureBox2.Image = img2;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result2== 5)
            {
                img2 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 5.png");

                pictureBox2.Image = img2;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {

                img2 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 6.png");

                pictureBox2.Image = img2;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            }
            switch (Sum)
            {
            
                 case 2:
                 case 3:
                 case 12:
                     {
                     
                         DisplayL();
                         break;
                     }
                 case 7:
                 case 11:
                     {
                         DisplayW();
                         break;
                     }
                 case 4:
                 case 5:
                 case 6:
                 case 8:
                 case 9:
                 case 10:
                    {
                        DisplayD();
                        attempt2 = Sum;
                        break;
                    }

            }
            attempt = false;
        }
        private int getX()
        {
            return attempt2;
        }
        private void RollDie0()
        {
            getX();
            int X = attempt2;
            lblX.Text=("Number to hit Again:" + X);
            getRandom();
            
            if (result1 == 1)
            {
                img1 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 1.png");

                pictureBox1.Image = img1;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result1 == 2)
            {
                img1 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 2.png");

                pictureBox1.Image = img1;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result1 == 3)
            {
                img1 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 3.png");

                pictureBox1.Image = img1;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result1 == 4)
            {
                img1 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 4.png");

                pictureBox1.Image = img1;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result1 == 5)
            {
                img1 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 5.png");

                pictureBox1.Image = img1;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {

                img1 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 6.png");

                pictureBox1.Image = img1;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
            //picturebox 2 and dice 2 
            if (result2 == 1)
            {
                img2 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 1.png");

                pictureBox2.Image = img2;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result2 == 2)
            {
                img2 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 2.png");

                pictureBox2.Image = img2;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result2 == 3)
            {
                img2 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 3.png");

                pictureBox2.Image = img2;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result2 == 4)
            {
                img2 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 4.png");

                pictureBox2.Image = img2;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (result2 == 5)
            {
                img2 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 5.png");

                pictureBox2.Image = img2;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {

                img2 = Image.FromFile(@"C:\Users\jonat\OneDrive\Desktop\c#\C#Project_JHernandez\Craps\Craps\Resources\dice 6.png");

                pictureBox2.Image = img2;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            }
            if (Sum == X)
            {
                DisplayW();
                lblX.Text = ("Number to hit Again:" + X);
            }
           else
            {
                DisplayD();
            }
           if(Sum == 7)
            {
                DisplayL();
                lblX.Text = ("Number to hit Again:" + X);

            }
        }

        private void DisplayL()
        {
            lblResult.Text=($"{lose} You Draw {Sum}");
            Reset();

        }
        private void DisplayD()
        {
            lblResult.Text=($"{draw} {Sum},ROLL AGAIN");
        }
        private void DisplayW()
        {
            lblResult.Text=($"{win} You Draw {Sum}");
            Reset();
        }
        private void Display()
        {
            lblResult.Text=($"You rolled {Sum}");
        }

        private void Reset()
        {
             Sum = 0;
             attempt = true;
             attempt2 = 0;
             result1 = 0;
             result2 = 0;
            btnRoll.Enabled = false;
             lblX.Text = " ";
        }

    
      private  void ResetResults()
        {
            lblResult.Text = "";
            pictureBox1.Image = Properties.Resources.blank;
            pictureBox2.Image = Properties.Resources.blank;
            pictureBox2.Visible = true;
            Sum = 0;
            btnRoll.Enabled = true;
            Sum = 0;
            attempt = true;
            attempt2 = 0;
            result1 = 0;
            result2 = 0;
            lblX.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetResults();
        }
    }
}
