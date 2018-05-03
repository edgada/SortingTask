using System;
using System.Windows.Forms;

namespace ACDtask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRikiuojam_Click(object sender, EventArgs e)
        {
            string naujasFailas = Rikiavimas.surikiuotiFaila("input.txt"); // failas ikeltas ACDtask\bin\Debug aplanke
            if (naujasFailas != "0")MessageBox.Show("Atlikta! Rezultatas išsaugotas " + naujasFailas + " faile."); // failas randamas ACDtask\bin\Debug aplanke
            else MessageBox.Show("Įvyko klaida!");
            Application.Exit();
        }
    }
}
