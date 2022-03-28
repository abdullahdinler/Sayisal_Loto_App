using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayisal_Loto_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int s1, s2, s3, s4, s5, s6, n1, n2, n3, n4, n5, n6;
            s1 = rnd.Next(1, 91);
            s2 = rnd.Next(1, 91);
            s3 = rnd.Next(1, 91);
            s4 = rnd.Next(1, 91);
            s5 = rnd.Next(1, 91);
            s6 = rnd.Next(1, 91);
            n1 = Convert.ToInt16(textBox1.Text);
            n2 = Convert.ToInt16(textBox1.Text);
            n3 = Convert.ToInt16(textBox1.Text);
            n4 = Convert.ToInt16(textBox1.Text);
            n5 = Convert.ToInt16(textBox1.Text);
            n6 = Convert.ToInt16(textBox1.Text);

            
            if (s1 == n1 && s2 == n2 && s3 == n3 && s4 == n4 && s5 == n5 && s6 == n6) 
            {
                textBox1.BackColor = Color.Green;
                textBox2.BackColor = Color.Green;
                textBox3.BackColor = Color.Green;
                textBox4.BackColor = Color.Green;
                textBox5.BackColor = Color.Green;
                textBox6.BackColor = Color.Green;
                listBox1.Items.Add(s1 + " " + s2 + " " + s3 + " " + s4 + " " + s5 + " " + s6);
                MessageBox.Show("Tebrikler 1 Milyon TL Kazandınız.", "Sayısal Loto", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else if (s1 == n1 && s2 == n2 && s3 == n3 && s4 == n4)
            {
                textBox1.BackColor = Color.Green;
                textBox2.BackColor = Color.Green;
                textBox3.BackColor = Color.Green;
                textBox4.BackColor = Color.Green;
                listBox1.Items.Add(s1 + " " + s2 + " " + s3 + " " + s4 + " " + s5 + " " + s6);
                MessageBox.Show("Tebrikler 500 Bin TL Kazandınız.", "Sayısal Loto", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

            }
            else if (s1 == n1 && s2 == n2)
            {
                textBox1.BackColor = Color.Green;
                textBox2.BackColor = Color.Green;
                listBox1.Items.Add(s1 + " " + s2 + " " + s3 + " " + s4 + " " + s5 + " " + s6);
                MessageBox.Show("Tebrikler 250 Bin TL Kazandınız.", "Sayısal Loto", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
                textBox4.BackColor = Color.Red;
                textBox5.BackColor = Color.Red;
                textBox6.BackColor = Color.Red;
                listBox1.Items.Add(s1 + " " + s2 + " " + s3 + " " + s4 + " " + s5 + " " + s6);
                MessageBox.Show("Üzgünüm Kazanamadınız!!!", "Sayısal Loto", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
