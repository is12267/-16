using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
namespace Подай_на_16
{
    public partial class Services : Form
    {
        static string constr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=qa;Integrated Security=True";
        DataContext cont = new DataContext(constr);
        public Services()
        {
            Entrance f2 = new Entrance();
            f2.ShowDialog();
            InitializeComponent();
            Table<Serv> servs = cont.GetTable<Serv>();
          


          
        
      

       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Редактировать red = new Редактировать();
            red.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
              Serv newServ = new Serv { Title = textBox1.Text, Cost = Convert.ToInt32(textBox2.Text), DurationInSeconds = Convert.ToInt32(textBox4.Text), 
                Description = textBox3.Text, Discount = Convert.ToInt32(textBox6.Text), MainImagePath = textBox5.Text };
            cont.GetTable<Serv>().InsertOnSubmit(newServ);
            cont.SubmitChanges();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Запись_на_услугу zap = new Запись_на_услугу ();
            zap.Show();
            this.Hide();
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Serv currentServ = cont.GetTable<Serv>().FirstOrDefault(
            x => x.Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            currentServ.Title = textBox1.Text;
            currentServ.Cost = Convert.ToDecimal(textBox2.Text);
            currentServ.DurationInSeconds = Convert.ToInt32(textBox4.Text);
            currentServ.Description = textBox3.Text;
            currentServ.Discount = Convert.ToDecimal(textBox6.Text);
            currentServ.MainImagePath = textBox5.Text;
            cont.SubmitChanges();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            //Image Source = "{Binding Player.Img}" ><;
            Serv currentServ = cont.GetTable<Serv>().FirstOrDefault(
            x => x.Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            textBox1.Text = currentServ.Title;
            textBox2.Text = currentServ.Cost.ToString();
            textBox4.Text = currentServ.DurationInSeconds.ToString();
            textBox3.Text = currentServ.Description;
            textBox6.Text = currentServ.Discount.ToString();
            textBox5.Text = currentServ.MainImagePath;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Удалить запись", "Удаленно", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (q==DialogResult.OK)
            {
                Serv DeliteServ = cont.GetTable<Serv>().OrderByDescending(x => x.Id).FirstOrDefault();
                cont.GetTable<Serv>().DeleteOnSubmit(DeliteServ);
                cont.SubmitChanges();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
