using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace click_messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBoxButtons", "Title Bar",MessageBoxButtons.OKCancel);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
