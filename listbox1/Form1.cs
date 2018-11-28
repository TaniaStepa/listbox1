using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Червоний");
            listBox1.Items.Add("Помаранчовий");
            listBox1.Items.Add("Жовтий");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Зелений");
            listBox1.Items.Add("Голубий");
            listBox1.Items.Add("Синій");
            listBox1.Items.Add("Фіолетовий");

        }
    }
}
