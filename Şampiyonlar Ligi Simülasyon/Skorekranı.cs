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
    public partial class Skorekranı : Form
    {

        public Skorekranı()
        {
            InitializeComponent();

            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
      
        }

        private void G1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ikincitur tur2 = new ikincitur();
            tur2.Show();
        }

        bool tutus;
        int fareX, fareY;

        private void Skorekranı_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            fareX = Cursor.Position.X - this.Left;
            fareY = Cursor.Position.Y - this.Top;
        }

        private void Skorekranı_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            fareX = 0;
            fareY = 0;
        }

        private void Skorekranı_Load(object sender, EventArgs e)
        {

        }

        private void Skorekranı_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - fareX;
                this.Top = Cursor.Position.Y - fareY;
            }
        }

        //private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //{

        //}

    }
    
}
