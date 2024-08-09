using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Caja : Form
    {
        public Caja()
        {
            InitializeComponent();
        }

        private void Cerrarcaja_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            Caja menucaja = new Caja();
            menucaja.Close(); //cierra la caja
            menu.Refresh(); //Limpia los campos
        }
    }
}
