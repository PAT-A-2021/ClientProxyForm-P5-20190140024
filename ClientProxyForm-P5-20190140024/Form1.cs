using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxyForm_P5_20190140024
{
    public partial class Form1 : Form
    {
        ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(texbox1.Text);
            int angka2 = Convert.ToInt32(textbox2.Text);

            double HasilKurang = obj.Kurang(angka1, angka2);
            double HasilKali = obj.Kali(angka1, angka2);
            double HasilBagi = obj.Bagi(angka1, angka2);

            labelPengurangan.Text = HasilKurang.ToString();
            labelPerkalian.Text = HasilKali.ToString();
            labelPembagian.Text = HasilBagi.ToString();

        }
    }
}
