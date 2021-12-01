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

    public partial class Услуги_гость_ : Form
    {    static string conSTR = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=qa;Integrated Security=True";
    DataContext cont = new DataContext(conSTR);
        public Услуги_гость_()
        {
         
          
        }

        private void Услуги_гость__Load(object sender, EventArgs e)
        {

        }

        private void Выход_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
