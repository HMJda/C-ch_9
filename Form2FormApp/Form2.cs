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
    public partial class Form2 : Form
    {
        Form1 parent; // Form1에 대한 참조 변수 선언
        public Form2(Form1 p)
        {
            InitializeComponent();
            parent = p;
        }
        public void setText1(string temp)
        {
            this.label1.Text = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.SetTextBox("Hello there");
            this.Close(); // 혹은 Close();
        }
    }
}
