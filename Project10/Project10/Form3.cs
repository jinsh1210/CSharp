using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10
{
    public partial class Form3 : Form
    {
        private Dictionary<string, int> menuPrices;

        public Form3()
        {
            InitializeComponent();
            InitializeMenuPrices();
            UpdateTime();
        }

        private void InitializeMenuPrices()
        {
            menuPrices = new Dictionary<string, int>
            {
                { "짜장면", 8000 },
                { "치킨", 25000 },
                { "햄버거", 10000 },
                { "국밥", 11000 },
                { "브리또", 7000 },
                { "갈비찜", 15000 }
            };
        }

        private void UpdateTime()
        {
            DateTime now = DateTime.Now;
            label2.Text = $"{now.Hour:D2}시 {now.Minute:D2}분 {now.Second:D2}초";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedMenus = new[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 }
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text)
                .ToList();

            if (selectedMenus.Count == 0)
            {
                MessageBox.Show("메뉴를 하나 이상 선택하세요.");
            }
            else
            {
                int total = selectedMenus.Sum(menu => menuPrices[menu]);
                string message = $"선택한 메뉴:\n{string.Join("\n", selectedMenus)}\n\n합계: {total:N0}원";
                MessageBox.Show(message, "주문 내역");
            }
        }
    }
}
