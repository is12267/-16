using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Подай_на_16
{
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "a";
            string password = "a";
            if (textBox1.Text==login && textBox2.Text ==password)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("ок");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Услуги_гость_ f = new Услуги_гость_();
            f.ShowDialog();
        }
    }
}
