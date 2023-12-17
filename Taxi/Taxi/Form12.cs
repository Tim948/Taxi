﻿using System;
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
    public partial class F12 : Form
    {
        public F12()
        {
            InitializeComponent();
        }

        private void работаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.работаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiDataSet);

        }

        private void F12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "taxiDataSet.Работа". При необходимости она может быть перемещена или удалена.
            this.работаTableAdapter.Fill(this.taxiDataSet.Работа);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < работаDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < работаDataGridView.RowCount - 1; j++)
                {
                    работаDataGridView[i, j].Style.BackColor = Color.White;
                    работаDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < работаDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < работаDataGridView.RowCount - 1; j++)
                {
                    if (работаDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        работаDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        работаDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
        private System.Windows.Forms.DataGridViewColumn COL;
        private void button2_Click(object sender, EventArgs e)
        {
            //создает переменную COL для хранения имени выбранного столбца таблицы
            COL = new System.Windows.Forms.DataGridViewColumn();
            //блок switch, записывающий в
            //переменную Col имя выбранного столбца таблицы в зависимости от номера
            //выбранного пункта списка (ListBox1.SelectedIndex).
            //Нумерация пунктов списка начинается с нуля, а нумерация столбцов с единицы.
            //Первый столбец в списке ListBox1 - «Фамилия» носит в таблице имя
            // DataGridViewTextBoxColumn3, указанное в свойствах полей
            //в Меню действий таблицы.
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn4;
                    break;
                
            }
            //Блок If выполняет следующую операцию: если включён

            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю, заданному в переменной Col по возрастанию
            //(studentsDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (studentsDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) работаDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else работаDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            работаBindingSource.Filter = "Дата='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            работаBindingSource.Filter = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private F12 A;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            A = new F12();
            A.Visible = true;
        }
        private F13 Avto;
        private void button6_Click(object sender, EventArgs e)
        {
            Avto = new F13();
            Avto.Visible = true;
        }
    }
}
