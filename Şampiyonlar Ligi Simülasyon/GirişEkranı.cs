using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şampiyonlar_Ligi_Simülasyon
{
    public partial class GirişEkranı : Form
    {
        List<Takim> takimlar;
        //List<Takim> torbalar1;
        //List<Takim> torbalar2;
        //List<Takim> torbalar3;
        //List<Takim> torbalar4;

        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox> gruplar = new List<ListBox>();

        public GirişEkranı()
        {
            InitializeComponent();
            
            


        }

        private void GirişEkranı_Load(object sender, EventArgs e)
        {
            Takim yenitakim = null;
            
            takimlar = new List<Takim>();

            ////torbalar1 = new List<Takim>();
            ////torbalar2 = new List<Takim>();
            ////torbalar3 = new List<Takim>();
            ////torbalar4 = new List<Takim>();


            takimlar.Add(new Takim("Bayern Munih ", " [Almanya]"));
            takimlar.Add(new Takim("Sevilla ", " [İspanya]"));
            takimlar.Add(new Takim("Real Madrid ", " [İspanya]"));
            takimlar.Add(new Takim("Liverpool ", " [İngiltere]"));
            takimlar.Add(new Takim("Juventus ", " [İtalya]"));          
            takimlar.Add(new Takim("Paris Saint-Germain ", " [Fransa]"));
            takimlar.Add(new Takim("Zenit ", " [Rusya]"));
            takimlar.Add(new Takim("Porto ", " [Portekiz]"));
            takimlar.Add(new Takim("Barcelona ", " [İspanya]"));
            takimlar.Add(new Takim("Atletico Madrid ", " [İspanya]"));
            takimlar.Add(new Takim("Manchester City ", " [İngiltere]"));
            takimlar.Add(new Takim("Manchester United ", " [İngiltere]"));
            takimlar.Add(new Takim("Borussia Dortmund ", " [Almanya]"));
            takimlar.Add(new Takim("shakhtar Donetsk ", " [Ukrayna]"));
            takimlar.Add(new Takim("Chelsea ", " [İngiltere]"));
            takimlar.Add(new Takim("Ajax ", " [Hollanda]"));
            takimlar.Add(new Takim("Dynamo Kiev ", " [Ukrayna]"));
            takimlar.Add(new Takim("Red bull Salzburg ", " [Almanya]"));
            takimlar.Add(new Takim("RB Leipzig ", " [Almanya]"));
            takimlar.Add(new Takim("Internazionle ", " [İtalya]"));
            takimlar.Add(new Takim("Olympiacos ", " [Yunanistan]"));
            takimlar.Add(new Takim("Lazio ", " [İtalya]"));
            takimlar.Add(new Takim("Krasnodar ", " [Rusya]"));
            takimlar.Add(new Takim("Atalanta ", " [İtalya]"));
            takimlar.Add(new Takim("Lokomotiv Moskova ", " [Rusya]"));
            takimlar.Add(new Takim("Marseille ", " [Fransa]"));
            takimlar.Add(new Takim("Club Brugge ", " [Belçika]"));
            takimlar.Add(new Takim("Bor.Mönchengladbach ", " [Almanya]"));
            takimlar.Add(new Takim("Galatasaray ", " [Türkiye]"));
            takimlar.Add(new Takim("Midtjylland ", " [Danimarka]"));
            takimlar.Add(new Takim("Rennes ", " [Fransa]"));
            takimlar.Add(new Takim("Ferencvaros ", " [Macaristan]"));


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();
            for (int j = 0; j < 4; j++)
            {
                secilentakimlar.Clear();

                for (int i = 0; i < 8; i++)
                {
                    int seçilentakim = rastgele.Next(0, takimlar.Count / 4);

                    if (secilentakimlar.Contains(seçilentakim))
                    {
                        i--;
                    }
                    else
                    {
                        secilentakimlar.Add(seçilentakim);
                    }
                }
                bool aynıulkedentakimvar = false;

                for (int k = 0; k < 8; k++)
                {
                    aynıulkedentakimvar = Aynıulketakimivarmi(gruplar[k], torbalar[j].Items[secilentakimlar[k]] as Takim);
                    if (aynıulkedentakimvar)
                        break;
                }
                if (!aynıulkedentakimvar)
                {
                    listBox1.Items.Add(torbalar[j].Items[secilentakimlar[0]] as Takim);
                    ggruplar.Grups[0, j] = torbalar[j].Items[secilentakimlar[0]] as Takim;
                    listBox2.Items.Add(torbalar[j].Items[secilentakimlar[1]] as Takim);
                    ggruplar.Grups[1, j] = torbalar[j].Items[secilentakimlar[1]] as Takim;
                    listBox3.Items.Add(torbalar[j].Items[secilentakimlar[2]] as Takim);
                    ggruplar.Grups[2, j] = torbalar[j].Items[secilentakimlar[2]] as Takim;
                    listBox4.Items.Add(torbalar[j].Items[secilentakimlar[3]] as Takim);
                    ggruplar.Grups[3, j] = torbalar[j].Items[secilentakimlar[3]] as Takim;
                    listBox5.Items.Add(torbalar[j].Items[secilentakimlar[4]] as Takim);
                    ggruplar.Grups[4, j] = torbalar[j].Items[secilentakimlar[4]] as Takim;
                    listBox6.Items.Add(torbalar[j].Items[secilentakimlar[5]] as Takim);
                    ggruplar.Grups[5, j] = torbalar[j].Items[secilentakimlar[5]] as Takim;
                    listBox7.Items.Add(torbalar[j].Items[secilentakimlar[6]] as Takim);
                    ggruplar.Grups[6, j] = torbalar[j].Items[secilentakimlar[6]] as Takim;
                    listBox8.Items.Add(torbalar[j].Items[secilentakimlar[7]] as Takim);
                    ggruplar.Grups[7, j] = torbalar[j].Items[secilentakimlar[7]] as Takim;

                }
                else
                {
                    j--;
                }
            }
        }
        private bool Aynıulketakimivarmi(ListBox grup, Takim takim)
        {
            bool durum = false;

            for (int i = 0; i < grup.Items.Count; i++)
            {
                Takim gruptakim = grup.Items[i] as Takim;
                if (gruptakim.TeamCountry == takim.TeamCountry)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();

            for (int i = 0; i < takimlar.Count; i++)
            {
                int seçilentakim = rastgele.Next(0, takimlar.Count);
                if (secilentakimlar.Contains(seçilentakim))
                {
                    i--;

                }
                else
                {
                    secilentakimlar.Add(seçilentakim);
                }

            }
            for (int i = 0; i < secilentakimlar.Count; i++)
            {
                if (i < 8)
                {
                    lstTorba1.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if (i < 16)
                {
                    LstTorba2.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if (i < 24)
                {
                    LstTorba3.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else
                {
                    LstTorba4.Items.Add(takimlar[secilentakimlar[i]]);
                }
            }
            torbalar.Add(lstTorba1);
            torbalar.Add(LstTorba2);
            torbalar.Add(LstTorba3);
            torbalar.Add(LstTorba4);

            gruplar.Add(listBox1);
            gruplar.Add(listBox2);
            gruplar.Add(listBox3);
            gruplar.Add(listBox4);
            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
            gruplar.Add(listBox8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Skorekranı skor = new Skorekranı();
            skor.Show();

        }

        bool tutus;
        int fareX, fareY;

        private void GirişEkranı_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            fareX = Cursor.Position.X - this.Left;
            fareY = Cursor.Position.Y - this.Top;
        }

        private void GirişEkranı_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            fareX = 0;
            fareY = 0;
        }

        private void GirişEkranı_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - fareX;
                this.Top = Cursor.Position.Y - fareY;
            }
        }
    }
}
