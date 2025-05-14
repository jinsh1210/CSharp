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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CenterControls()
        {
            int formWidth = this.ClientSize.Width;
            label1.Left = (formWidth - label1.Width) / 2;
            comboBox1.Left = (formWidth - comboBox1.Width) / 2;
            label2.Left = (formWidth - label2.Width) / 2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 콤보박스에 1월부터 12월까지 추가
            for (int i = 1; i <= 12; i++)
            {
                comboBox1.Items.Add($"{i}월");
            }
            CenterControls();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CenterControls();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedMonth = comboBox1.SelectedItem.ToString();
                int month = int.Parse(selectedMonth.Replace("월", ""));
                string season = "";

                if (month >= 3 && month <= 5)
                {
                    season = "봄";
                }
                else if (month >= 6 && month <= 8)
                {
                    season = "여름";
                }
                else if (month >= 9 && month <= 11)
                {
                    season = "가을";
                }
                else
                {
                    season = "겨울";
                }

                label2.Text = $"당신은 {season}에 태어났군요";
            }
        }
    }
}
