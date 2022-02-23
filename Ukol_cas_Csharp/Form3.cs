using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol_cas_Csharp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        public string jmeno, prijmeni;

        private void button1_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Text.Split(';');
            DateTime datum = DateTime.Now;
            int i = 3;

            while (i < textBox1.Lines.Count())
            {
                if (Convert.ToDateTime(data[i]) > datum)
                {
                    jmeno = data[i - 2];
                    prijmeni = data[i - 1];
                }

                i = i + 3;
            }

            MessageBox.Show("Nejstarší člověk je " + jmeno + prijmeni);
        }
    }
}