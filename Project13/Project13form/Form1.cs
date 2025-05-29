using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project13form
{

    public partial class Form1 : Form
    {
        class MyForm : Form1
        {
            static int num = 0;
            public MyForm()
            {
                num++;
                Text = "Form1의" + num + "번 자식 창";
                BackColor = Color.Coral;
                button1.Text = num + "번 버튼";

            }


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyForm mf = new MyForm();

            mf.Show(); // Show() 메서드를 사용하여 폼을 표시합니다.


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Form1의 부모 창";
            BackColor = Color.LightBlue;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
