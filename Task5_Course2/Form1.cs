using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RaceLibrary5;
using ClassLibrary1;

namespace Task5_Course2
{
    public partial class Form1 : Form
    {
        Race race;
        private bool resize = false;
        public Form1()
        {
            InitializeComponent();
            race = new Race(ClientSize.Width, ClientSize.Height);
            timer1.Start();
        }

        private void начатьГонкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                race.StartRace();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DrawAll(Graphics g, Rectangle r)
        {
            if (race != null)
            {
                Bitmap bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
                Drawing.DrawRace(bmp, race);
                g.DrawImage(bmp, r);
                bmp.Dispose();
            }
        }

        private void остановитьГонкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                race.StopRace();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void добавить4УчастниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            race.CreateRace();
        }

        private void очиститьУчастниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                race.ClearParticipants();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void изменитьРазмерТрассыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!race.RaceIsOn)
            {
                resize = true;
                FormBorderStyle = FormBorderStyle.Sizable;
                menuStrip1.Enabled = false;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawAll(e.Graphics, e.ClipRectangle);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (!race.RaceIsOn && resize)
            {
                race.UpdateTrack(ClientSize.Width, ClientSize.Height);
                resize = false;
                FormBorderStyle = FormBorderStyle.FixedDialog;
                menuStrip1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
