using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackOffice;

namespace BackOffice
{
    public partial class BackOffice : Form
    {
        Funciones funciones = new Funciones();
        public BackOffice()
        {
            InitializeComponent();
            WelcomUserLabel.Text = ("Welcome " + funciones.GetUserName());
            int[] Posicion = funciones.GetWelcomePosition(this.Size.Width,this.Size.Height);
            Point NewLocation = new Point((Posicion[0] - (WelcomUserLabel.Size.Width/2)),Posicion[1]);
            WelcomUserLabel.Location =  NewLocation;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
