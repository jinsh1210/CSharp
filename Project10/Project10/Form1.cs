using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project10
{
    public partial class Form1 : Form
    {
        private bool isToggled = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕히가세요. 다시 만나면 좋겠습니다. " +
                "\n메세지 창을 닫으면 윈도우 배경색이 초록색으로 변합니다.", "씨발", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.BackColor = Color.GreenYellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요 인하공전에 오신걸 환영합니다. " +
                "\n컴퓨터 시스템과 학과 사무실은 7호관입니다." +
                "\n메세지 창을 닫으면 배경색이 파랑색으로 변합니다.");
            this.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isToggled = !isToggled;
            button3.BackColor = isToggled ? Color.Orange : SystemColors.ControlDark;
            // Form2 띄우기
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
