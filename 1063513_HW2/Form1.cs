using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;    //DashStyle
namespace _1063513_HW2
{
    public partial class Form1 : Form
    {
        Rectangle rect1 = new Rectangle(0, 30, 60, 60);
        Rectangle rect2 = new Rectangle(60, 30, 60, 60);
        Rectangle rect3 = new Rectangle(120, 30, 60, 60);

        Rectangle rect4 = new Rectangle(0, 90, 60, 60);
        Rectangle rect5 = new Rectangle(60, 90, 60, 60);
        Rectangle rect6 = new Rectangle(120, 90, 60, 60);

        Rectangle rect7 = new Rectangle(0, 150, 60, 60);
        Rectangle rect8 = new Rectangle(60, 150, 60, 60);
        Rectangle rect9 = new Rectangle(120, 150, 60, 60);

        Pen bp = new Pen(Color.Blue,2);
        Pen rp = new Pen(Color.Red,2);
        Pen p = new Pen(Color.Black, 2);
        int round = 0;
        int[] ptr = new int[9];
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            label1.Text = " ";
            e.Graphics.DrawRectangle(p, rect1);
            e.Graphics.DrawRectangle(p, rect2);
            e.Graphics.DrawRectangle(p, rect3);
            e.Graphics.DrawRectangle(p, rect4);
            e.Graphics.DrawRectangle(p, rect5);
            e.Graphics.DrawRectangle(p, rect6);
            e.Graphics.DrawRectangle(p, rect7);
            e.Graphics.DrawRectangle(p, rect8);
            e.Graphics.DrawRectangle(p, rect9);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //////////////////////////////////////
            Graphics grap = this.CreateGraphics();
            if (round % 2 == 0 && round < 10) // player = O
            {
                if (rect1.Contains(e.Location) && ptr[0] == 0)//pt1[0] == 0 如果此位置沒被畫過
                {
                    grap.DrawEllipse(bp, 5, 35, 50, 50);
                    ptr[0] = 1;
                    round++;
                }
                if (rect2.Contains(e.Location) && ptr[1] == 0)
                {
                    grap.DrawEllipse(bp, 65, 35, 50, 50);
                    ptr[1] = 1;
                    round++;
                }
                if (rect3.Contains(e.Location) && ptr[2] == 0)
                {
                    grap.DrawEllipse(bp, 125, 35, 50, 50);
                    ptr[2] = 1;
                    round++;
                }
                if (rect4.Contains(e.Location) && ptr[3] == 0)
                {
                    grap.DrawEllipse(bp, 5, 95, 50, 50);
                    ptr[3] = 1;
                    round++;
                }
                if (rect5.Contains(e.Location) && ptr[4] == 0)
                {
                    grap.DrawEllipse(bp, 65, 95, 50, 50);
                    ptr[4] = 1;
                    round++;
                }
                if (rect6.Contains(e.Location) && ptr[5] == 0)
                {
                    grap.DrawEllipse(bp, 125, 95, 50, 50);
                    ptr[5] = 1;
                    round++;
                }
                if (rect7.Contains(e.Location) && ptr[6] == 0)
                {
                    grap.DrawEllipse(bp, 5, 155, 50, 50);
                    ptr[6] = 1;
                    round++;
                }
                if (rect8.Contains(e.Location) && ptr[7] == 0)
                {
                    grap.DrawEllipse(bp, 65, 155, 50, 50);
                    ptr[7] = 1;
                    round++;
                }
                if (rect9.Contains(e.Location) && ptr[8] == 0)
                {
                    grap.DrawEllipse(bp, 125, 155, 50, 50);
                    ptr[8] = 1;
                    round++;
                }

            }
            if (round % 2 == 1 && round < 9) //computer X
            {
                int a = -2;
                Random rd = new Random();
                while (round % 2 == 1)
                {
                    a = rd.Next(9);
                    if (ptr[a] == 0)
                    {
                        if (a == 0)
                        {
                            grap.DrawLine(bp, 10, 40, 50, 80);
                            grap.DrawLine(bp, 10, 80, 50, 40);
                            ptr[0] = 2;
                            round++;
                        }
                        if (a == 1)
                        {
                            grap.DrawLine(bp, 70, 40, 110, 80);
                            grap.DrawLine(bp, 70, 80, 110, 40);
                            ptr[1] = 2;
                            round++;
                        }
                        if (a == 2)
                        {
                            grap.DrawLine(bp, 130, 40, 170, 80);
                            grap.DrawLine(bp, 130, 80, 170, 40);
                            ptr[2] = 2;
                            round++;
                        }
                        if (a == 3)
                        {
                            grap.DrawLine(bp, 10, 100, 50, 140);
                            grap.DrawLine(bp, 10, 140, 50, 100);
                            ptr[3] = 2;
                            round++;
                        }
                        if (a == 4)
                        {
                            grap.DrawLine(bp, 70, 100, 110, 140);
                            grap.DrawLine(bp, 70, 140, 110, 100);
                            ptr[4] = 2;
                            round++;
                        }
                        if (a == 5)
                        {
                            grap.DrawLine(bp, 130, 100, 170, 140);
                            grap.DrawLine(bp, 130, 140, 170, 100);
                            ptr[5] = 2;
                            round++;
                        }
                        if (a == 6)
                        {
                            grap.DrawLine(bp, 10, 160, 50, 200);
                            grap.DrawLine(bp, 10, 200, 50, 160);
                            ptr[6] = 2;
                            round++;
                        }
                        if (a == 7)
                        {
                            grap.DrawLine(bp, 70, 160, 110, 200);
                            grap.DrawLine(bp, 70, 200, 110, 160);
                            ptr[7] = 2;
                            round++;
                        }
                        if (a == 8)
                        {
                            grap.DrawLine(bp, 130, 160, 170, 200);
                            grap.DrawLine(bp, 130, 200, 170, 160);
                            ptr[8] = 2;
                            round++;
                        }
                    }
                }

            }


            if(ptr[0] == 1 && ptr[1] == 1 && ptr[2] == 1)
            {
                grap.DrawLine(rp, 10, 60, 170, 60);
                label1.Text = "You win!";
            }
            else if (ptr[3] == 1 && ptr[4] == 1 && ptr[5] == 1)
            {
                grap.DrawLine(rp, 10, 120, 170, 120);
                label1.Text = "You win!";
            }
            else if (ptr[6] == 1 && ptr[7] == 1 && ptr[8] == 1)
            {
                grap.DrawLine(rp, 10, 180, 170, 180);
                label1.Text = "You win!";
            }
            else if (ptr[0] == 1 && ptr[3] == 1 && ptr[6] == 1)
            {
                grap.DrawLine(rp, 30, 40, 30, 200);
                label1.Text = "You win!";
            }
            else if (ptr[1] == 1 && ptr[4] == 1 && ptr[7] == 1)
            {
                grap.DrawLine(rp, 90, 40, 90, 200);
                label1.Text = "You win!";
            }
            else if (ptr[2] == 1 && ptr[5] == 1 && ptr[8] == 1)
            {
                grap.DrawLine(rp, 150, 40, 150, 200);
                label1.Text = "You win!";
            }
            else if (ptr[0] == 1 && ptr[4] == 1 && ptr[8] == 1)
            {
                grap.DrawLine(rp, 10, 40, 170, 200);
                label1.Text = "You win!";
            }
            else if (ptr[2] == 1 && ptr[4] == 1 && ptr[6] == 1)
            {
                grap.DrawLine(rp, 170, 40, 10, 200);
                label1.Text = "You win!";
            }
            else if (ptr[0] == 2 && ptr[1] == 2 && ptr[2] == 2)
            {
                grap.DrawLine(rp, 10, 60, 170, 60);
                label1.Text = "You lose!";
            }
            else if (ptr[3] == 2 && ptr[4] == 2 && ptr[5] == 2)
            {
                grap.DrawLine(rp, 10, 120, 170, 120);
                label1.Text = "You lose!";
            }
            else if (ptr[6] == 2 && ptr[7] == 2 && ptr[8] == 2)
            {
                grap.DrawLine(rp, 10, 180, 170, 180);
                label1.Text = "You lose!";
            }
            else if (ptr[0] == 2 && ptr[3] == 2 && ptr[6] == 2)
            {
                grap.DrawLine(rp, 30, 40, 30, 200);
                label1.Text = "You lose!";
            }
            else if (ptr[1] == 2 && ptr[4] == 2 && ptr[7] == 2)
            {
                grap.DrawLine(rp, 90, 40, 90, 200);
                label1.Text = "You lose!";
            }
            else if (ptr[2] == 2 && ptr[5] == 2 && ptr[8] == 2)
            {
                grap.DrawLine(rp, 150, 40, 150, 200);
                label1.Text = "You lose!";
            }
            else if (ptr[0] == 2 && ptr[4] == 2 && ptr[8] == 2)
            {
                grap.DrawLine(rp, 10, 40, 170, 200);
                label1.Text = "You lose!";
            }
            else if (ptr[2] == 2 && ptr[4] == 2 && ptr[6] == 2)
            {
                grap.DrawLine(rp, 170, 40, 10, 200);
                label1.Text = "You lose!";
            }
            else
            {
                int j = 0;
                for(int i = 0;i < 9;i++)
                {
                    if (ptr[i] != 0)
                    {
                        j++;
                    }
                }
                if (j == 9)
                    label1.Text = "Draw!";

            }




        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics grap2 = this.CreateGraphics();
            grap2.Clear(this.BackColor);
            for (int j = 0; j < 9; j++)
            {
                ptr[j] = 0;
            }
            round = 0;
            label1.Text = " ";
            this.Invalidate();
        }
    }
}
