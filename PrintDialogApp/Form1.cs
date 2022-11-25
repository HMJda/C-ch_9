using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PrintDialogApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrinterSettings printer = new PrinterSettings();
            printDialog1.PrinterSettings = printer; // 기본 프린터 설정
            printDialog1.Document = printDocument1; // 컴포넌트로 추가된 printDocument 객체: 인쇄할 문서 객체 : 설정
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printDocument1.DocumentName = textBox1.Text; // 인쇄할 내용 : TextBox내용 지정
            Font printFont = new Font("Arial", 10, FontStyle.Regular);
            e.Graphics.DrawString(printDocument1.DocumentName, printFont, Brushes.Black, 10, 10);
        }
    }
}
