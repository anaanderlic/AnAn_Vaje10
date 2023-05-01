using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Letala
{
    // vir: https://www.mooict.com/c-tutorial-create-a-t-rex-endless-runner-game-in-visual-studio/
    public partial class Form1 : Form
    {
        bool skakanje = false;
        int hitrostskoka;
        int sila = 12;
        int sttock = 0;
        int hitrostOvir = 10;
        Random rand = new Random();
        bool konecIgre = false;
        int pozicija;

        private string pot = @"rezultati.json";
        bool prebrano = false;

        private int najRez;
        private Igralec upor1;

        List<Igralec> igralci;

        public Form1()
        {
            InitializeComponent();
        }

        private void casovnik_Tick(object sender, EventArgs e)
        {
            rex.Top += hitrostskoka;
            tocke.Text = sttock.ToString();
            Najboljsirez.Text = najRez.ToString();

            if (skakanje == true && sila < 0)
            {
                skakanje = false;
            }
            if (skakanje == true)
            {
                hitrostskoka = -12;
                sila -= 1;
            }
            else
            {
                hitrostskoka = 12;
            }

            if (rex.Top > 275 && skakanje == false)
            {
                sila = 12;
                rex.Top = 276;
                hitrostskoka = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ovira")
                {
                    x.Left -= hitrostOvir;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        sttock++;
                    }
                    if (sttock > najRez)
                    {
                        najRez = sttock;
                    }

                    if (rex.Bounds.IntersectsWith(x.Bounds))
                    {
                        casovnik.Stop();

                        konecIgre = true;
                        upor1.Tocke = sttock;
                        igralci.Add(upor1);
                        najboljsiRezultati.Enabled = true;

                        DodajamoVRezultate();
     
                        najboljsiRezultati.Visible = true;
    
                        zacetek.Visible = true;
                        zacetek.Enabled = true;
                        igralecIme.Visible = true;
                        igralecIme.Enabled = true;
                        ime.Visible = true;
                    }
                }
            }
            if (sttock > 5)
            {
                hitrostOvir = 15;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && skakanje == false)
            {
                skakanje = true;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (skakanje == true)
            {
                skakanje = false;
            }

            if (e.KeyCode == Keys.R && konecIgre == true)
            {
                Reset();
            }
        }

        /// <summary>
        /// Klik na gumb zacni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Zacni_Click(object sender, EventArgs e)
        {
            zacetek.Visible = false;
            zacetek.Enabled = false;
 
            ime.Visible = false;

            igralecIme.Visible = false;
            igralecIme.Enabled = false;

            najboljsiRezultati.Visible = false;
            najboljsiRezultati.Enabled = false;

            najboljsiRezultati.Items.Clear();

            // preberemo rezultate
            if (!prebrano)
            {
                igralci = LoadJson();
            }

            Reset();
        }

        /// <summary>
        /// Resetiranje igre
        /// </summary>
        private void Reset()
        {
            sila = 12;
            hitrostskoka = 0;
            skakanje = false;
            sttock = 0;
            hitrostOvir = 10;
            tocke.Text =  sttock.ToString();
            konecIgre = false;
            rex.Top = 276;

            upor1 = new Igralec();
            upor1.Ime = igralecIme.Text;

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "ovira")
                {
                    pozicija = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = pozicija;
                }
            }
            casovnik.Start();
        }

        /// <summary>
        /// Preberemo datoteko
        /// </summary>
        /// <returns></returns>
        public List<Igralec> LoadJson()
        {
            prebrano = true;
            if (File.Exists(pot))
            {
                using (StreamReader r = new StreamReader(pot))
                {

                    string json = r.ReadToEnd();
                    List<Igralec> podatki = JsonSerializer.Deserialize<List<Igralec>>(json);
                    List<Igralec> podatki2 = podatki.OrderByDescending(x => x.Tocke).ToList();
                    najRez = podatki[0].Tocke;
                    return podatki2;
                }
            }
            else
            {
                najRez = 0;
                return new List<Igralec>();
            }
        }

        /// <summary>
        /// Zapis na datoteko
        /// </summary>
        private void Shranimo()
        {
            string json = JsonSerializer.Serialize(igralci);
            File.WriteAllText(pot, json);
        }

        /// <summary>
        /// Izpis rezultatov
        /// </summary>
        private void DodajamoVRezultate()
        {
            int stevec = 1;
            igralci = igralci.OrderByDescending(x => x.Tocke).ToList();

            Shranimo();
            foreach (Igralec i in igralci)
            {
                if (stevec < 11)
                {
                    najboljsiRezultati.Items.Add($"{stevec++}. {i.Ime}: {i.Tocke}");
                }
            }
        }
    }
}
