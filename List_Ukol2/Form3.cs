using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Ukol2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        List<String> cisla = new List<String>();

        private void zpatky_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Soucet(List<string> list, int p)
        {
            int soucet = 0;
            if (list.Count < p)
            {
                MessageBox.Show("V Listu je moc málo prvků!", "Výsledek");
            }
            else
            {
                for (int i = 0; i < p; i++)
                {
                    soucet += Convert.ToInt32(list[i]);
                }
                MessageBox.Show("Součet prvních " + p + " prvků je " + soucet);
            }
        }

        private void vytvorit_Click_1(object sender, EventArgs e)
        {
            try
            {
                listBox_cisla.Items.Clear();
                cisla.Clear();

                int N = Convert.ToInt32(textBox_N.Text);
                int A1 = Convert.ToInt32(textBox_A1.Text);
                int A2 = Convert.ToInt32(textBox_A2.Text);
                double D = (double)A2 / (double)A1;

                cisla.Add(Convert.ToString(A1));
                for (int i = 1; i < N; i++)
                {
                    cisla.Add(Convert.ToString(Convert.ToInt32(cisla.Last()) * D));
                }
                listBox_cisla.Items.AddRange(cisla.ToArray());

                textBox_P.Visible = true;
                label4.Visible = true;
                secist.Visible = true;
            }
            catch
            {
                MessageBox.Show("Zadej správné hodnoty!", "Error");
            }
        }

        private void pridat_Click(object sender, EventArgs e)
        {
            Soucet(cisla, Convert.ToInt32(textBox_P.Text));
        }
    }
}