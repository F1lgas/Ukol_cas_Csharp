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
            DateTime datum = DateTime.Now;

            foreach (string line in textBox1.Lines)
            {
                string data = line.Split(';')[2];              
                
                try
                {
                    if (Convert.ToDateTime(data) < datum)
                    {
                        jmeno = line.Split(';')[0];
                        prijmeni = line.Split(';')[1];

                        datum = Convert.ToDateTime(data);
                    }
                }
                catch
                {
                    MessageBox.Show("Špatný vstup!", "Error");
                    return;
                }
            }

            MessageBox.Show("Nejstarší člověk je " + jmeno + " " + prijmeni);
        }
    }
}