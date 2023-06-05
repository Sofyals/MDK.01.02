using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetText(richTextBox.SelectedText);
                richTextBox.SelectedText = "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {


            if (openFileDialog1.ShowDialog() == DialogResult.OK) //��������� ��� �� ������ ����
            {
                richTextBox.Clear(); //������� richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //��������� ��� ��� ����������
                                                                     //������ ��������� �����
                string fileName = openFileDialog1.FileName; //�������� ������������ ���� � ���� � ����.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //��������
                                                                                           // ���������� ����� � richTextBox
            }


        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//������ ��������� ����������
            saveFileDialog1.DefaultExt = ".txt"; //������ ���������� �� ��������� 3
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //��������� ������������� ���������� ����������.
            {
                var name = saveFileDialog1.FileName; //������ ��� �����
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //����������
                //� ���� ���������� textBox � ���������� 1251

            }
            richTextBox.Clear();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            richTextBox.SelectionColor = System.Drawing.Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

        }

        private void Clean_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void ���������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select(); // ������������ ������ ����������� ������
                                  //richTextBox1.SelectAll(); //��������� ����� ������
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            //richTextBox1.DeselectAll(); //������ ���������

        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionFont = new Font("Arial", 12);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionFont = new Font("TimesNewRoman", 12);
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            richTextBox.SelectionColor = System.Drawing.Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void font_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionFont = new Font("TimesNewRoman", 12);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void �����������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void �����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void ����������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyTitleAttribute titleAttribute = assembly.GetCustomAttribute<AssemblyTitleAttribute>();



            string title = titleAttribute != null ? titleAttribute.Title : "";
            string product = "������������ ������ �3";
            string version = "1.0";
            string description = "���������� ���������� ��������� � ����� Visual Studio �� \r\n����� C#";


            string author = "������� C.�"; // ����� ����� ������� ������ ��������� ��� ������ ����������

            string message = $"��������: {title}\n" +
                     $"�������: {product}\n" +
                     $"������: {version}\n" +
                     $"�����: {author}\n" +
                     $"��������: {description}";

            MessageBox.Show(message, "� ���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //��������� ��� �� ������ ����
            {
                richTextBox.Clear(); //������� richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //��������� ��� ��� ����������
                                                                     //������ ��������� �����
                string fileName = openFileDialog1.FileName; //�������� ������������ ���� � ���� � ����.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //��������
                                                                                           // ���������� ����� � richTextBox
            }

        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//������ ��������� ����������
            saveFileDialog1.DefaultExt = ".txt"; //������ ���������� �� ��������� 3
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //��������� ������������� ���������� ����������.
            {
                var name = saveFileDialog1.FileName; //������ ��� �����
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //����������
                //� ���� ���������� textBox � ���������� 1251

            }
            richTextBox.Clear();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetText(richTextBox.SelectedText);
            }
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                richTextBox.SelectedText = Clipboard.GetText();
            }
        }

        private void Highlight_Click(object sender, EventArgs e)
        {

            richTextBox.Select(0, richTextBox.TextLength);
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetText(richTextBox.SelectedText);
                richTextBox.SelectedText = "";
            }
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                richTextBox.SelectedText = Clipboard.GetText();
            }
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetText(richTextBox.SelectedText);
            }
        }
    }
}
