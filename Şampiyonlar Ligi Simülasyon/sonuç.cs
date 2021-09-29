﻿using System;
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
    public partial class sonuç : Form
    {
        public sonuç()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Şampiyon sampiyon = new Şampiyon();
            sampiyon.Show();
        }

        bool tutus;
        int fareX, fareY;

        private void sonuç_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            fareX = Cursor.Position.X - this.Left;
            fareY = Cursor.Position.Y - this.Top;
        }

        private void sonuç_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            fareX = 0;
            fareY = 0;
        }

        private void sonuç_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - fareX;
                this.Top = Cursor.Position.Y - fareY;
            }
        }
    }
}
