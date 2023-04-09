using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fayllar;
using System.Runtime.InteropServices;

namespace Bloknot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Matn turi(*.txt)|*.txt|C# fayl (*.cs)|*.cs";
            saveFileDialog2.Filter = "Saqlash(*.txt)|*.txt";
            textBox1.ScrollBars = ScrollBars.Vertical;
            if (Class1.path.Length > 4)
            {
                string path = Class1.path[0].ToString() + ":\\" + Class1.path.Substring(3);
                if (File.Exists(path))
                {

                    string fileText = File.ReadAllText(path);
                    textBox1.Text = fileText;
                }

            }


        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void joylashtirishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void yaratingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void yangiOynaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
        }

        private void boshqaFormatdaSaqlashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Hujjat saqlandi!");
        }

        private void ochishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Hujjatga kirildi!");
        }

        private void chiqishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saqlashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog2.FileName;
            File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Hujjat saqlandi!");
        }

        private void shriftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void nusxalashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                textBox1.Copy();
            }
        }

        private void joylashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void kesishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void ochirishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void barchasiniBelgilashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                textBox1.SelectAll();
            }
        }

        private void qidirishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void ilovaHaqidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saqlashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog2.FileName;
            File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Hujjat saqlandi!");
        }

        private void bekorQilishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void kesishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void nusxalashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void joylashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void ochirishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "";
        }

        private void saqlashToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog2.FileName;
            File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Hujjat saqlandi!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void barchasiniBelgilashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void korinishToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
