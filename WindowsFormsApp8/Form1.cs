using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            fontDialog1.ShowColor = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            label1.Font = fontDialog1.Font;
            label1.ForeColor = fontDialog1.Color;

            label1.Text = textBox1.Text;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, label1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            label1.Text = fileText;
        }
    }
}
