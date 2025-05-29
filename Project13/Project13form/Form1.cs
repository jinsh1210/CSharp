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

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("새로 만들기 메뉴가 클릭되었습니다.");
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "";
            openFileDialog.InitialDirectory = @"C:\"; // 초기 디렉토리 설정
            openFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*"; // 파일 필터 설정
            openFileDialog.ShowDialog();
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("저장 메뉴가 클릭되었습니다.");
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("종료 메뉴가 클릭되었습니다.");
        }

        private void 잘라내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("잘라내기 메뉴가 클릭되었습니다.");
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("복사 메뉴가 클릭되었습니다.");
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("붙여넣기 메뉴가 클릭되었습니다.");
        }
    }
}
