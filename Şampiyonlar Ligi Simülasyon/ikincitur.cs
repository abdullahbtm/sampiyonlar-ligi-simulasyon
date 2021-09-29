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
    public partial class ikincitur : Form
    {
        public ikincitur()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sonuç tur3 = new sonuç();
            tur3.Show();
        }

        bool tutus;
        int fareX, fareY;

        private void ikincitur_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            fareX = Cursor.Position.X - this.Left;
            fareY = Cursor.Position.Y - this.Top;
        }

        private void ikincitur_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            fareX = 0;
            fareY = 0;
        }

        private void ikincitur_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - fareX;
                this.Top = Cursor.Position.Y - fareY;
            }
        }
    }
}
