using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace doviz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolarAlis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            dolarAlisText.Text = dolarAlis;

            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            dolarSatisText.Text = dolarsatis;

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            euroAlisText.Text = euroalis;

            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            euroSatisText.Text = eurosatis;

            string sterlinAlis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            sterlinAlisText.Text = sterlinAlis;

            string siterlinSatis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            sterlinSatisText.Text = siterlinSatis;

            string frankAlis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='CHF']/BanknoteBuying").InnerXml;
            frankAlisText.Text = frankAlis;

            string frankSatis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='CHF']/BanknoteSelling").InnerXml;
            frankSatisText.Text = frankSatis;

            string dinarAlis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='KWD']/BanknoteBuying").InnerXml;
            dinarAlisText.Text = dinarAlis;

            string dinarSatis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='KWD']/BanknoteSelling").InnerXml;
            dinarSatisText.Text = dinarSatis;

        }

        private void dolarSatis_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = dolarAlisText.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = dolarSatisText.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = euroAlisText.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = euroSatisText.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = sterlinAlisText.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text =sterlinSatisText.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text =frankAlisText.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text =frankSatisText.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = dinarAlisText.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text =dinarSatisText.Text;
        }


        double kur, miktar, tutar;

        private void button2_Click(object sender, EventArgs e)
        {
            kur = Convert.ToDouble(textBox1.Text);
            int miktar = Convert.ToInt32(textBox2.Text);
            int tutar = Convert.ToInt32(miktar/kur);
            textBox3.Text = tutar.ToString();
            double kalan;
            kalan = miktar % kur;
            textBox4.Text = kalan.ToString();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(".", ",");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kur = Convert.ToDouble(textBox1.Text);
            miktar = Convert.ToDouble(textBox2.Text);
            tutar = miktar * tutar;
            textBox3.Text=tutar.ToString();



        }
    }
}
