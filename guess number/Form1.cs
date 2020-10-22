using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guess_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int a = new Random().Next(100);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int b = int.Parse(textBox1.Text);
                if (a == b)
                {
                    MessageBox.Show("恭喜猜中", "答案", MessageBoxButtons.OK);
                }
                if (a > b)
                {
                    MessageBox.Show("再大一點", "答案", MessageBoxButtons.OK);
                }
                if (a < b)
                {
                    MessageBox.Show("再小一點", "答案", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("不要輸入數字以外的文字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
