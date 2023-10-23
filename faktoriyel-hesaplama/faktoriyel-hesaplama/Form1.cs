using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faktoriyel_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int topla, sayi1;
            topla = 1 ;
            sayi1=Convert.ToInt32(txtFaktoriyel.Text);
            for(int i = 1; i <= sayi1; i++)
            {
                topla *= i;
            }
            lblSonuc.Text=topla.ToString();
        }
    }
}
