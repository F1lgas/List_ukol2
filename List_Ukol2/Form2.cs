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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int N;
        public int A1;
        public int D;
        List<String> cisla = new List<String>();

        private void zpatky_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Pridej(int n, List<string> list, ListBox listBox1, int d)
        {
            for (int i = 0; i < n; i++)
            {
                list.Add(Convert.ToString(Convert.ToInt32(list.Last()) + d));
                listBox1.Items.Add(Convert.ToString(Convert.ToInt32(list.Last())));
            }
        }

        private void vytvorit_Click(object sender, EventArgs e)
        {
            try
            {
                N = Convert.ToInt32(textBox_N.Text);
                A1 = Convert.ToInt32(textBox_A1.Text);
                D = Convert.ToInt32(textBox_D.Text);

                cisla.Add(Convert.ToString(A1));
                listBox_cisla.Items.Add(Convert.ToString(A1));
                for (int i = 0; i < (N - 1) ; i++)
                {
                    cisla.Add(Convert.ToString(Convert.ToInt32(cisla.Last()) + D));
                    listBox_cisla.Items.Add(Convert.ToString(Convert.ToInt32(cisla.Last())));
                }

                textBox1.Visible = true;
                label4.Visible = true;
                pridat.Visible = true;
            }
            catch
            {
                MessageBox.Show("Zadej správné hodnoty!", "Error");
            }
        }

        private void pridat_Click(object sender, EventArgs e)
        {
            Pridej(N, cisla, listBox_cisla, D);
        }
    }
}