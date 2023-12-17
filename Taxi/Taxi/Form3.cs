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
    public partial class F3 : Form
    {
        public F3()
        {
            InitializeComponent();
        }

        private void марка_автомобиляBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.марка_автомобиляBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);

        }

        private void F3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Марка_автомобиля". При необходимости она может быть перемещена или удалена.
            this.марка_автомобиляTableAdapter.Fill(this.taxiDataSet.Марка_автомобиля);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
