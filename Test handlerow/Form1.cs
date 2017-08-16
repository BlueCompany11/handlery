using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_handlerow
{
    public partial class Form1 : Form
    {
        MyClass w = new MyClass();

        public Form1()
        {
            InitializeComponent();
            w.ValueChanged += button2_Click;
            w.someInt = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            w.Fun();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(w.someInt.ToString());

        }
    }
}
