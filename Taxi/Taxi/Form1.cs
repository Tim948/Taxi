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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private F2 avto;
        private void button1_Click(object sender, EventArgs e)
        {
            avto = new F2();
            avto.Visible = true;
        }
        private F6 avt;
        private void button2_Click(object sender, EventArgs e)
        {
            avt = new F6();
            avt.Visible = true;
        }
        private F8 av;
        private void button3_Click(object sender, EventArgs e)
        {
            av = new F8();
            av.Visible = true;
        }
        private F10 a;
        private void button4_Click(object sender, EventArgs e)
        {
            a = new F10();
            a.Visible = true;
        }
        private F12 A;
        private void button5_Click(object sender, EventArgs e)
        {
            A = new F12();
            A.Visible = true;
        }
    }
}
