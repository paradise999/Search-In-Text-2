using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        Color colSel;
        Color colSeBack;
        string str;
        int i = 0;
        int f = 0;
        public Form1()
        {
            InitializeComponent();
            colSel = richTextBox1.SelectionColor;
            colSeBack = richTextBox1.SelectionBackColor;

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            if (f == 1)
            {
                str = textBox1.Text;
                i = 0;
                while (i != -1)
                {
                    if (i <= richTextBox1.Text.Length - str.Length)
                    {
                        i = richTextBox1.Text.IndexOf(str, i);
                        if (i >= 0)
                        {
                            richTextBox1.SelectionStart = i;
                            richTextBox1.SelectionLength = str.Length;
                            richTextBox1.SelectionBackColor = Color.Yellow;
                            richTextBox1.SelectionColor = Color.Black;
                            i += str.Length;
                            i = richTextBox1.Text.IndexOf(str, i);
                        }
                    }
                }
            }
            if (f == 2)
            {
                str = textBox1.Text;
                i = 0;
                if (i <= richTextBox1.Text.Length - str.Length)
                {
                    i = richTextBox1.Text.IndexOf(str, i);
                    if (i >= 0)
                    {
                        richTextBox1.SelectionStart = i;
                        richTextBox1.SelectionLength = str.Length;
                        richTextBox1.SelectionBackColor = Color.Yellow;
                        richTextBox1.SelectionColor = Color.Black;
                    }
                    if (i == -1)
                    {
                        MessageBox.Show("Такого в тексте нет");
                    }
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = colSel;
            richTextBox1.SelectionBackColor = colSeBack;

        }

        private void farther_Click(object sender, EventArgs e)
        {
            if (i <= richTextBox1.Text.Length - str.Length)
            {
                if (i >= 0)
                {
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = str.Length;
                    richTextBox1.SelectionBackColor = Color.White;
                    richTextBox1.SelectionColor = Color.Black;
                    i += str.Length;
                    i = richTextBox1.Text.IndexOf(str, i);
                }
                if (i >= 0)
                {
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = str.Length;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    richTextBox1.SelectionColor = Color.Black;                   
                }
                if (i == -1)
                {
                    MessageBox.Show("Далее такого в тексте нет");
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (i <= richTextBox1.Text.Length - str.Length)
            {
                if (i >= 0)
                {
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = str.Length;
                    richTextBox1.SelectionBackColor = Color.White;
                    richTextBox1.SelectionColor = Color.Black;
                    i = i - str.Length;
                    if (i > 0) i = richTextBox1.Text.IndexOf(str, i);
                }
                if (i >= 0)
                {
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = str.Length;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    richTextBox1.SelectionColor = Color.Black;
                }
                if (i == -1)
                {
                    MessageBox.Show("Ранее такого в тексте нет");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                richTextBox1.SelectAll();
                richTextBox1.SelectionColor = colSel;
                richTextBox1.SelectionBackColor = colSeBack;
                f = 1;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                richTextBox1.SelectAll();
                richTextBox1.SelectionColor = colSel;
                richTextBox1.SelectionBackColor = colSeBack;
                f = 2;
            }
        }
    }
}
