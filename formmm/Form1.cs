using System;
using System.Drawing;
using System.Windows.Forms;

namespace formmm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int skor;
        
        bool left, right;
       

        private void Sayacevent(object sender, EventArgs e)
        {
            
            agaclar(5);
            oyunbitir();
            ekle();
            label1.Text = "SKOR:" +Convert.ToString(skor);
         
            if(left==true&&kayak.Left>5)
            {
                kayak.Left -= 9;
            }
            if (right == true && kayak.Left < 841)
            {
                kayak.Left += 9;
            }
            if (left == true && monster.Left > 5)
            {
                monster.Left -= 9;
            }
            if (right == true && monster.Left < 841)
            {
                monster.Left += 9;
            }
        }
        
        Random r = new Random();
        int x, y;
        
            
       
        void agaclar(int hiz)
        {

            if (agac.Top <= 0)
            {
                x = r.Next(0, 300);
                y = r.Next(600, 669);
                agac.Location = new Point(x, y);
            }
            else
            {
                agac.Top -= hiz;
            }
            if (agac1.Top <= 0)
            {
                x = r.Next(300, 500);
                y = r.Next(600, 669);
                agac1.Location = new Point(x, y);
            }
            else
            {
                agac1.Top -= hiz;
            }
            if (agac2.Top <= 0)
            {
                x = r.Next(500, 700);
                y = r.Next(600, 669);
                agac2.Location = new Point(x, y);
            }
            else
            {
                agac2.Top -= hiz;
            }
            if (agac3.Top <= 0)
            {
                x = r.Next(700, 900);
                y = r.Next(600, 669);
                agac3.Location = new Point(x, y);
            }
            else
            {
                agac3.Top -= hiz;
            }
            if (monster.Bottom < kayak.Top)
            {
                
                int hiz1 =+ 1;
                
                monster.Top += hiz1;
            }
            else
            {
                int hiz1 = 1;
                monster.Top -= hiz1;
            }
            if (star.Top <= 0)
            {
                x = r.Next(0, 900);
                y = r.Next(0, 669);
                star.Location = new Point(x, y);
            }
            else
            {
                star.Top -= hiz;
            }
            if (star1.Top <= 0)
            {
                x = r.Next(0, 900);
                y = r.Next(0, 669);
                star1.Location = new Point(x, y);
            }
            else
            {
                star1.Top -= hiz;
            }
            if (star2.Top <= 0)
            {
                x = r.Next(0, 900);
                y = r.Next(0, 669);
                star2.Location = new Point(x, y);
            }
            else
            {
                star2.Top -= hiz;
            }
            if (star3.Top <= 0)
            {
                x = r.Next(0, 900);
                y = r.Next(0, 669);
                star3.Location = new Point(x, y);
            }
            else
            {
                star3.Top -= hiz;
            }
        }
        void oyunbitir()
        {
            if (agac.Top-kayak.Bottom <3  && kayak.Left - agac.Right  < 3 && kayak.Right - agac.Left > 3)
            {
                if (agac.Bottom < kayak.Top)
                {
                    sayac.Enabled = true;
                }
                else
                {
                    sayac.Enabled = false;
                }
            }
            if (agac1.Top - kayak.Bottom < 3 && kayak.Left - agac1.Right < 3 && kayak.Right - agac1.Left > 3)
            {
                if (agac1.Bottom < kayak.Top)
                {
                    sayac.Enabled = true;
                }
                else
                {
                    sayac.Enabled = false;
                }

            }
            if (agac2.Top - kayak.Bottom < 3 && kayak.Left - agac2.Right < 3 && kayak.Right - agac2.Left > 3)
            {
                if (agac2.Bottom < kayak.Top)
                {
                    sayac.Enabled = true;
                }
                else
                {
                    sayac.Enabled = false;
                }

            }
            if (agac3.Top - kayak.Bottom < 3 && kayak.Left - agac3.Right < 3 && kayak.Right - agac3.Left > 3)
            {
                if (agac3.Bottom < kayak.Top)
                {
                    sayac.Enabled = true;
                }
                else
                {
                    sayac.Enabled = false;
                }

            }
            if (kayak.Top - monster.Bottom < 3)
            {
                sayac.Enabled = false;
            }
        }

        void ekle()
        {
            if (star.Top - kayak.Bottom < 3 && kayak.Left - star.Right < 3 && kayak.Right - star.Left > 3)
            {
                if (star.Bottom < kayak.Top)
                {
                    sayac.Enabled = true;
                }
                else
                {
                    skor += 1;
                    monster.Top -= 5;
                }
            }
            if (star1.Top - kayak.Bottom < 3 && kayak.Left - star1.Right < 3 && kayak.Right - star1.Left > 3)
            {
                if (star1.Bottom < kayak.Top)
                {
                    sayac.Enabled = true;
                }
                else
                {
                    skor += 1;
                    monster.Top -= 5;
                }


            }
            if (star2.Top - kayak.Bottom < 3 && kayak.Left - star2.Right < 3 && kayak.Right - star2.Left > 3)
            {
                if (star2.Bottom < kayak.Top)
                {
                    sayac.Enabled = true;
                }
                else
                {
                    skor += 1;
                    monster.Top -= 5;
                }
            }
            if (star3.Top - kayak.Bottom < 3 && kayak.Left - star3.Right < 3 && kayak.Right - star3.Left > 3)
            {
                if (star3.Bottom < kayak.Top)
                {
                    sayac.Enabled = true;
                }
                else
                {
                    skor += 1;
                    monster.Top -= 5;
                }
            }
        }
            private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
        }

        
       
    }
}
