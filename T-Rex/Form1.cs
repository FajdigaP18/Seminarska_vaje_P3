using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace T_Rex
{
    public partial class Form1 : Form
    {
        bool skakanje = false;
        int hitrostskoka = 10;
        int sila = 12;
        int sttock = 0;
        int hitrostOvir = 10;
        Random rand = new Random();
        bool konecIgre = false;
        int pozicija;

        // nove pirivatne spremenljivke
        private string pot = @"rezultati.json";
        bool prebrano = false;
        private int najRez;
        private Igralec upor1;
        List<Igralec> igralci;

        public Form1()
        {
            InitializeComponent();

            //Reset();
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
                        //label1.Text += " Press R to restart the game!";
                        konecIgre = true;
                        upor1.Tocke = sttock;
                        igralci.Add(upor1);
                        Rezultati.Enabled = true;
                        Shranimo();
                        DodajamoVRezultate();
                        // omogočimo rezultate
                        Rezultati.Visible = true;
                        // nazaj omogočimo gumb začni
                        Zacni.Visible = true;
                        Zacni.Enabled = true;
                        // omogočimo textbox uporabnika
                        Uporabnik.Visible = true;
                        Uporabnik.Enabled = true;
                        // omogoimo label Ime
                        Ime.Visible = true;
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

        }

        private void Reset()
        {
            sila = 12;
            hitrostskoka = 0;
            skakanje = false;
            sttock = 0;
            hitrostOvir = 10;
            tocke.Text = sttock.ToString();
            konecIgre = false;
            rex.Top = 276;

            upor1 = new Igralec();
            upor1.Ime = Uporabnik.Text;



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
        /// Preberemo datoteko rezultatov
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
                    najRez = podatki[0].Tocke;
                    return podatki;
                }
            }
            else
            {
                najRez = 0;
                return new List<Igralec>();
            }
        }
        /// <summary>
        ///  Rezultate shrnimov datoteko 
        /// </summary>
        private void Shranimo()
        {
            string json = JsonSerializer.Serialize(igralci);
            File.WriteAllText(pot, json);
        }

        /// <summary>
        /// Izpis reziltatov v listBoxu
        /// </summary>
        private void DodajamoVRezultate()
        {
            int stevec = 1;
            // predno shranimo rezultate jih uredimo
            igralci.Sort();
            // shranimo v json datoteko
            Shranimo();
            Rezultati.Items.Add("REZULTATI");
            // ZAPIŠEMO 10 NAJBOLJŠIH REZULTATOV
            foreach (Igralec i in igralci)
            {
                if (stevec <= 10)
                {
                  
                    Rezultati.Items.Add($"{stevec++}. {i.Ime}  :  {i.Tocke}");
                }
            }
        }
        /// <summary>
        /// Kaj se zgodi ko pritisnemo na gumb zacni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Zacni_Click(object sender, EventArgs e)
        {
            // skrijemo in onemogpčimo gumb
            Zacni.Visible = false;
            Zacni.Enabled = false;
            // skrijemo label ime
            Ime.Visible = false;
            // onemogčimo in skrijemo uporabnika
            Uporabnik.Visible = false;
            Uporabnik.Enabled = false;
            // onemogočimo listbox
            Rezultati.Visible = false;
            Rezultati.Enabled = false;

            Rezultati.Items.Clear();


            // preberemo rezultate
            if (!prebrano)
            {
                igralci = LoadJson();
            }

            // zacnemo z novo igro
            Reset();
        }
    }
}
