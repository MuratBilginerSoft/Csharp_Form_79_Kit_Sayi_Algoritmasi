using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Kod_H_Kıt_Sayı_Algoritması
{
    public partial class Form1 : Form
    {
        #region Değişkenler

        int a, b;
        int toplam = 0;
        ArrayList bölüm = new ArrayList();

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            for (int j = a; j <= b; j++)
            {
                bölüm.Clear();
                for (int i = 1; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        bölüm.Add(i);
                    }
                }

                toplam = 0;
                foreach (int s in bölüm)
                {
                    toplam += s;
                }

                if (toplam < j)
                {
                    listBox1.Items.Add(j);
                }
            }
        }
    }
}
