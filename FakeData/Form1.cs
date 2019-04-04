using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FakeData
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<Adaylar> alist = new List<Adaylar>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Veriler vr = new Veriler();

            for (int i = 1; i < 100; i++)
            {
                Adaylar a = new Adaylar();

                a.id = i;
                a.ad = vr.isimGetir();
                a.soyad = vr.SoyisimGetir();
                a.ulke = vr.UlkeGetir();
                a.puan = vr.PuanGetir();
                alist.Add(a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doldur();
        }
        private void Doldur()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alist;
        }
    }
}
