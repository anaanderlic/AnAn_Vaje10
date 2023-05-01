using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trki
{
    public partial class Okno : Form
    {
        bool levo;
        bool desno;
        bool gor;
        bool dol;
        int premik = 3;

        public Okno()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Definiranje dvignjenih tipk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dvignjeno(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gor = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                levo = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                dol = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                desno = false;
            }
        }

        /// <summary>
        /// Definiranje pritisnjenih tipk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pritisnjeno(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gor = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                levo = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                dol = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                desno = true;
            }
        }

        /// <summary>
        /// Timer za premikanje in preverjanje prekrivanja dveh kvadratov
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {

            // premikanje
            if (dol == true && kvadrat.Bottom < this.Height)
            {
                kvadrat.Top += premik;
            }

            if (levo == true && kvadrat.Left > 0)
            {
                kvadrat.Left -= premik;
            }

            if (desno == true && kvadrat.Right < this.Width)
            {
                kvadrat.Left += premik;
            }

            if (gor == true && kvadrat.Top > 0)
            {
                kvadrat.Top -= premik;
            }

            // pregled nad prekrivanjem
            foreach (Control element in Controls)
            {
                if (element is PictureBox && (string)element.Tag == "rumen")
                {

                    // barvo nastavimo na rdečo, če se prekrivata
                    if (kvadrat.Bounds.IntersectsWith(element.Bounds))
                    {
                        element.BackColor = Color.Red;
                    }

                    // drugače barva ostane rumena
                    else
                    {
                        element.BackColor = Color.Yellow;
                    }
                }
            }
        }
    }
}
