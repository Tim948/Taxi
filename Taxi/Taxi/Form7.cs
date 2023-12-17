using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi
{
    public partial class F7 : Form
    {
        public F7()
        {
            InitializeComponent();
        }

        private void вызовыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вызовыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.taxiDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Тарифы". При необходимости она может быть перемещена или удалена.
            this.тарифыTableAdapter.Fill(this.taxiDataSet.Тарифы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Работа". При необходимости она может быть перемещена или удалена.
            this.работаTableAdapter.Fill(this.taxiDataSet.Работа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Вызовы". При необходимости она может быть перемещена или удалена.
            this.вызовыTableAdapter.Fill(this.taxiDataSet.Вызовы);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
