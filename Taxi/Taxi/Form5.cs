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
    public partial class F5 : Form
    {
        public F5()
        {
            InitializeComponent();
        }

        private void автомобилиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.автомобилиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);

        }

        private void F5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.taxiDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Марка_автомобиля". При необходимости она может быть перемещена или удалена.
            this.марка_автомобиляTableAdapter.Fill(this.taxiDataSet.Марка_автомобиля);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.taxiDataSet.Автомобили);

        }

        private void код_маркиComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
