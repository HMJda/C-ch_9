using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snap
{
    public partial class Form1 : Form
    {
        Random randomColour = new Random(); // random object 선언
        int randomNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == pictureBox2.BackColor) // 색깔이 동일할 경우
            {
                timer1.Enabled = false; // 색이 동일할 경우, timer를 중지하고
                MessageBox.Show("Snap!"); // “Snap”이라는 message를 표시
                timer1.Enabled = true; // 메시지의 OK버튼을 클릭하는 경우 타이머를 다시 시작
            }
            // Generate new colours
            randomNumber = randomColour.Next(3); // random number : 0 ~ 2
                                                 // pictureBox1의 색을 변경
            if (randomNumber == 0) pictureBox1.BackColor = Color.Blue;
            if (randomNumber == 1) pictureBox1.BackColor = Color.Green;
            if (randomNumber == 2) pictureBox1.BackColor = Color.Red;
            randomNumber = randomColour.Next(3); // random number: 0 ~ 2
                                                 // pictureBox2의 색을 변경
            if (randomNumber == 0) pictureBox2.BackColor = Color.Blue;
            if (randomNumber == 1) pictureBox2.BackColor = Color.Green;
            if (randomNumber == 2) pictureBox2.BackColor = Color.Red;
        }
    }
}
