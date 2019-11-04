using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace мыш
{
    public partial class Form1 : Form
    {
        DateTime time_info = new DateTime();

        

        public Form1()
        {
            InitializeComponent();
        }

    

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DialogResult vibor2 = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (vibor2 == DialogResult.Yes)
                {
                    System.Environment.Exit(1);
                }

            }
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && this.Left > 0) //стрелочка влево
            {
                this.SetDesktopLocation(this.Left - 5, this.Top);
            }
            if (e.KeyCode == Keys.Right && (this.Left + this.Width) < Screen.PrimaryScreen.Bounds.Right) //стрелочка вправо
            {
                this.SetDesktopLocation(this.Left + 5, this.Top);
            }
            if (e.KeyCode == Keys.Up && this.Top > 0) //стрелочка вверх
            {
                this.SetDesktopLocation(this.Left, this.Top - 5);
            }
            if (e.KeyCode == Keys.Down && this.Top + this.Height < Screen.PrimaryScreen.Bounds.Bottom) //стрелочка вниз
            {
                this.SetDesktopLocation(this.Left, this.Top + 5);
            }
            
            if (e.KeyCode == Keys.Left && e.Shift) //прибавка влево
            {
                 this.Width += 5;
            }
            if (e.KeyCode == Keys.Up && e.Shift) //прибавка в верх
            {
                this.Height += 5;
            }
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        { 
            time_info = DateTime.Now;
            if (e.Button == MouseButtons.Left)
            {
                this.Text = time_info.ToLongTimeString();
            }
            if (e.Button == MouseButtons.Right)
            {
                this.Text = time_info.ToShortDateString();
            }
            if (e.Button == MouseButtons.Middle)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Text = "Мыш Мыш Мыш Мыш Мыш Мыш";
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.Text = "Мыш Мыш Мыш Мыш Мыш Мыш";
            }
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                this.Opacity += 0.2;
            }
            else
            {
                this.Opacity -= 0.2;
            }
        }
        
    }
}
