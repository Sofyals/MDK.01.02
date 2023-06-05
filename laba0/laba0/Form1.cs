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


            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют
                                                                     //только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем
                                                                                           // содержимое файла в richTextBox
            }


        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию 3
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываем
                //в файл содержимое textBox с кодировкой 1251

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

        private void предварительныйПросмрToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select(); // выравнивание только выделенного текста
                                  //richTextBox1.SelectAll(); //выделение всего текста
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            //richTextBox1.DeselectAll(); //Отмена выделения

        }

        private void поЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void поПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            richTextBox.SelectionColor = System.Drawing.Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void настройкаПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyTitleAttribute titleAttribute = assembly.GetCustomAttribute<AssemblyTitleAttribute>();



            string title = titleAttribute != null ? titleAttribute.Title : "";
            string product = "Лабораторная работа №3";
            string version = "1.0";
            string description = "Разработка текстового редактора в среде Visual Studio на \r\nязыке C#";


            string author = "Лысенко C.Н"; // Здесь можно указать автора программы или другую информацию

            string message = $"Название: {title}\n" +
                     $"Продукт: {product}\n" +
                     $"Версия: {version}\n" +
                     $"Автор: {author}\n" +
                     $"Описание: {description}";

            MessageBox.Show(message, "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют
                                                                     //только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем
                                                                                           // содержимое файла в richTextBox
            }

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию 3
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываем
                //в файл содержимое textBox с кодировкой 1251

            }
            richTextBox.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetText(richTextBox.SelectedText);
                richTextBox.SelectedText = "";
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                richTextBox.SelectedText = Clipboard.GetText();
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetText(richTextBox.SelectedText);
            }
        }
    }
}
