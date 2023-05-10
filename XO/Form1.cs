using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sana = 0;



        int ballX = 0, ballY = 0;

        private void x1_Click(object sender, EventArgs e)
        {
           Button ajaga = (Button)sender;
            X_OR_O(ajaga);
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            lbl_balX.Text = "Ball X:0" ;
            lbl_balY.Text = "Ball O:0" ;
            x1.Text = "";
            x2.Text = "";
            x3.Text = "";
            x4.Text = "";
            x5.Text = "";
            x6.Text = "";
            x7.Text = "";
            x8.Text = "";
            x9.Text = "";
            sana = 0;
            ballX = 0; ballY = 0;
            this.BackgroundImage = Properties.Resources.defaem;
        }

        void X_OR_O(Button btn)

        {
            if (btn.Text == "" && sana % 2 == 0)
            {
                btn.Text = "X";
                sana++;

            }
            else if (btn.Text == "" && sana % 2 == 1)
            {
                btn.Text = "O";
                sana++;

            }
            tekser("X");
            tekser("O");
            void tekser(string belgi)
            {
                if (x1.Text == belgi && x2.Text == belgi && x3.Text == belgi ||
                   x4.Text == belgi && x5.Text == belgi && x6.Text == belgi ||
                           x7.Text == belgi && x8.Text == belgi && x9.Text == belgi ||
                           x1.Text == belgi && x4.Text == belgi && x7.Text == belgi ||
                           x2.Text == belgi && x5.Text == belgi && x8.Text == belgi ||
                           x3.Text == belgi && x6.Text == belgi && x9.Text == belgi ||
                           x1.Text == belgi && x5.Text == belgi && x9.Text == belgi ||
               x3.Text == belgi && x5.Text == belgi && x7.Text == belgi)
                {

                   
                    if (belgi == "X")
                    {
                        this.BackgroundImage = Properties.Resources.X;
                        MessageBox.Show(belgi + " Won the Game");
                        this.BackgroundImage = Properties.Resources.defaem;
                    }
                    else if(belgi=="O")
                    {
                        this.BackgroundImage = Properties.Resources.O;
                        MessageBox.Show(belgi + " Won the Game");
                        this.BackgroundImage = Properties.Resources.defaem;
                    }
                   
                    if (belgi == "X")
                    {
                        ballX++;
                    }
                    else if (belgi == "O")
                    {
                        ballY++;
                    }
                    Console.Beep();
                    lbl_balX.Text = "Ball X: " + ballX;
                    lbl_balY.Text = "Ball O: " + ballY;
                    x1.Text = "";
                    x2.Text = "";
                    x3.Text = "";
                    x4.Text = "";
                    x5.Text = "";
                    x6.Text = "";
                    x7.Text = "";
                    x8.Text = "";
                    x9.Text = "";
                    sana = 0;
                }
                else if(sana==9)
                {
                    this.BackgroundImage = Properties.Resources.XO;
                    MessageBox.Show("Draw!");
                    x1.Text = "";
                    x2.Text = "";
                    x3.Text = "";
                    x4.Text = "";
                    x5.Text = "";
                    x6.Text = "";
                    x7.Text = "";
                    x8.Text = "";
                    x9.Text = "";
                    this.BackgroundImage = Properties.Resources.defaem;
                }

            }
        }
    }

}