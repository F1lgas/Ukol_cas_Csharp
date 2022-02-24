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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            DateTime datum = DateTime.Now;

            label1.Text = "Dnes je " + datum.ToString("D") + ". Je to " + datum.DayOfYear + ". den v roce." + Environment.NewLine + "Je " + datum.ToString("HH") + " hodin, " + datum.ToString("mm") + " minut a " + datum.ToString("ss") + " sekund.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
    }
}