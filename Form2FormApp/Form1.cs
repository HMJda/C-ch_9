using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void SetTextBox(string strText)
        {
            textBox1.Text = strText;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2Show = new Form2(this);
            form2Show.Show(); // form2를 모달리스 방식으로 띄운다.
            form2Show.setText1("Hello");
        }
    }
}
