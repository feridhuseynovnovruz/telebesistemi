using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelebeSistemiFeridNovruz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Zehmet olmasa telebenin adini girin!", "Xeta");
                return;
            }

            string cinsiyet = "";
            if (radioButton1.Checked == true)
            {
                cinsiyet = "Kisi";
            }
            else if (radioButton2.Checked == true)
            {
                cinsiyet = "Qadin";
            }
            else
            {
                MessageBox.Show("Zehmet olmasa cinsiyet seçin!");
                return;
            }

            string telebeler = textBox1.Text + " - " + numericUpDown1.Value.ToString() + " yaş - " + comboBox1.Text + " - " + cinsiyet;

            listBox1.Items.Add(telebeler);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Silmek ucun listden bir telebe seçin!", "Xeberdarliq");
                return;
            }

            DialogResult mesaj = MessageBox.Show("Bu öğrenciyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);

            if (mesaj == DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                label1.Text = listBox1.SelectedItem.ToString();
            }
        }
    }
}
