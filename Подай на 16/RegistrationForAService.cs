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
    public partial class Запись_на_услугу : Form
    {
        static string conSTR = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=qa;Integrated Security=True";
        DataContext cont = new DataContext(conSTR);
        public Запись_на_услугу()
        {
            InitializeComponent();
            Table<ClientServ> cservs = cont.GetTable<ClientServ>();
            dataGridView2.DataSource = cservs.ToList();
        }

        private void Запись_на_услугу_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qaDataSet3.w1". При необходимости она может быть перемещена или удалена.
            this.w1TableAdapter.Fill(this.qaDataSet3.w1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qaDataSet2.clientsCMB". При необходимости она может быть перемещена или удалена.
            this.clientsCMBTableAdapter.Fill(this.qaDataSet2.clientsCMB);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qaDataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.qaDataSet1.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qaDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.qaDataSet.Service);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientTableAdapter.FillBy(this.qaDataSet1.Client);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Добавить","Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
            if (res == DialogResult.Yes)
            {
                ClientServ clientServ = new ClientServ { ClientID = comboBox2.SelectedIndex, ServiceID = comboBox1.SelectedIndex, StartTime = dateTimePicker1.Value};
                cont.GetTable<ClientServ>().InsertOnSubmit(clientServ);
                cont.SubmitChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Services f = new Services();
            f.Show();
        }

      
    }
}
