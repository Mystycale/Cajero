namespace Cajero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validacion de data cajero



            //

            //Despues de la validacion, continuar a la caja

            Caja menucaja = new Caja();
            menucaja.WindowState = FormWindowState.Maximized; //pamtalla completa
            menucaja.FormBorderStyle = FormBorderStyle.None;
            menucaja.Show();



        }
    }
}
