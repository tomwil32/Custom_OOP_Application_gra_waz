using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waz
{
    public partial class Form1 : Form
    {
        private bool czy_gra_aktywna;
        private Waz snake;
        private Owoc owoc;
        public Form1()
        {
            InitializeComponent();
            czy_gra_aktywna = false;
            timer1.Enabled = true;
            pAUZAToolStripMenuItem.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (czy_gra_aktywna)
            {
                pole_gry.CreateGraphics().Clear(Color.Black);
                snake.move();
                snake.rysuj(pole_gry.CreateGraphics(), new SolidBrush(Color.Green));
                owoc.rysuj_owoc(pole_gry.CreateGraphics(), new SolidBrush(Color.Red));
                if (owoc.czy_nowy_owoc(snake.x[0], snake.y[0]))
                {
                    snake.dodaj();
                }
                if (snake.czy_waz_zyje() == false)
                {
                    czy_gra_aktywna = false;
                }
            }
            else
            {
                FontFamily fontFamily1 = new FontFamily("Arial");
                Font f = new Font(fontFamily1, 15);
                Brush b = new SolidBrush(Color.Red);
                pole_gry.CreateGraphics().DrawString("Naciśnij Start", f, b, 100, 135);
            }
        }

        private void sTARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czy_gra_aktywna = true;
            snake = new Waz(pole_gry.Width, pole_gry.Height);
            owoc = new Owoc(snake.segment);
            pAUZAToolStripMenuItem.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) snake.ruch = "gora";
            if (e.KeyCode == Keys.Down) snake.ruch = "dol";
            if (e.KeyCode == Keys.Right) snake.ruch = "prawo";
            if (e.KeyCode == Keys.Left) snake.ruch = "lewo";
        }

        private void pAUZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (czy_gra_aktywna)
            {
                czy_gra_aktywna = false;
                pAUZAToolStripMenuItem.Text = "Wznów";
                pole_gry.CreateGraphics().Clear(Color.Black);
            }
            else
            {
                czy_gra_aktywna = true;
                pAUZAToolStripMenuItem.Text = "Pauza";
            } 
        }

        private void oDNOWAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (czy_gra_aktywna)
            {
                snake = new Waz(pole_gry.Width, pole_gry.Height);
                owoc = new Owoc(snake.segment);
            }
        }

        private void wOLNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval += 10;
        }

        private void sZYBKOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 10) { timer1.Interval -= 10; }
        }
    }
}
