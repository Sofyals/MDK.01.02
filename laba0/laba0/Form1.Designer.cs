namespace laba0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox = new RichTextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            печатьToolStripMenuItem = new ToolStripMenuItem();
            предварительныйПросмотрToolStripMenuItem = new ToolStripMenuItem();
            настройкаПринтераToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            вырезатьToolStripMenuItem = new ToolStripMenuItem();
            копироватьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            очиститьToolStripMenuItem = new ToolStripMenuItem();
            сервисToolStripMenuItem = new ToolStripMenuItem();
            цветToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            arialToolStripMenuItem = new ToolStripMenuItem();
            timesNewRomanToolStripMenuItem = new ToolStripMenuItem();
            выравниваниеToolStripMenuItem = new ToolStripMenuItem();
            поЦентруToolStripMenuItem = new ToolStripMenuItem();
            поЛевомуКраюToolStripMenuItem = new ToolStripMenuItem();
            поПравомуКраюToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem1 = new ToolStripMenuItem();
            Cut = new Button();
            Copy = new Button();
            Paste = new Button();
            Clean = new Button();
            Highlight = new Button();
            Color = new Button();
            font = new Button();
            Open = new Button();
            Save = new Button();
            Exite = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            pageSetupDialog1 = new PageSetupDialog();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(12, 75);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(658, 669);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, редактироватьToolStripMenuItem, сервисToolStripMenuItem, оПрограммеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(937, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, печатьToolStripMenuItem, предварительныйПросмотрToolStripMenuItem, настройкаПринтераToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(90, 38);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(465, 44);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(465, 44);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // печатьToolStripMenuItem
            // 
            печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            печатьToolStripMenuItem.Size = new Size(465, 44);
            печатьToolStripMenuItem.Text = "Печать";
            печатьToolStripMenuItem.Click += печатьToolStripMenuItem_Click;
            // 
            // предварительныйПросмотрToolStripMenuItem
            // 
            предварительныйПросмотрToolStripMenuItem.Name = "предварительныйПросмотрToolStripMenuItem";
            предварительныйПросмотрToolStripMenuItem.Size = new Size(465, 44);
            предварительныйПросмотрToolStripMenuItem.Text = "Предварительный просмотр";
            предварительныйПросмотрToolStripMenuItem.Click += предварительныйПросмотрToolStripMenuItem_Click;
            // 
            // настройкаПринтераToolStripMenuItem
            // 
            настройкаПринтераToolStripMenuItem.Name = "настройкаПринтераToolStripMenuItem";
            настройкаПринтераToolStripMenuItem.Size = new Size(465, 44);
            настройкаПринтераToolStripMenuItem.Text = "Настройка принтера";
            настройкаПринтераToolStripMenuItem.Click += настройкаПринтераToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(465, 44);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вырезатьToolStripMenuItem, копироватьToolStripMenuItem, вставитьToolStripMenuItem, очиститьToolStripMenuItem });
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(196, 38);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.Size = new Size(359, 44);
            вырезатьToolStripMenuItem.Text = "Вырезать";
            вырезатьToolStripMenuItem.Click += вырезатьToolStripMenuItem_Click;
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.Size = new Size(359, 44);
            копироватьToolStripMenuItem.Text = "Копировать";
            копироватьToolStripMenuItem.Click += копироватьToolStripMenuItem_Click;
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size = new Size(359, 44);
            вставитьToolStripMenuItem.Text = "Вставить";
            вставитьToolStripMenuItem.Click += вставитьToolStripMenuItem_Click;
            // 
            // очиститьToolStripMenuItem
            // 
            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Size = new Size(359, 44);
            очиститьToolStripMenuItem.Text = "Очистить";
            очиститьToolStripMenuItem.Click += очиститьToolStripMenuItem_Click;
            // 
            // сервисToolStripMenuItem
            // 
            сервисToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { цветToolStripMenuItem, шрифтToolStripMenuItem, выравниваниеToolStripMenuItem });
            сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            сервисToolStripMenuItem.Size = new Size(114, 38);
            сервисToolStripMenuItem.Text = "Сервис";
            // 
            // цветToolStripMenuItem
            // 
            цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            цветToolStripMenuItem.Size = new Size(311, 44);
            цветToolStripMenuItem.Text = "Цвет";
            цветToolStripMenuItem.Click += цветToolStripMenuItem_Click;
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arialToolStripMenuItem, timesNewRomanToolStripMenuItem });
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(311, 44);
            шрифтToolStripMenuItem.Text = "Шрифт";
            шрифтToolStripMenuItem.Click += шрифтToolStripMenuItem_Click;
            // 
            // arialToolStripMenuItem
            // 
            arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            arialToolStripMenuItem.Size = new Size(332, 44);
            arialToolStripMenuItem.Text = "Arial";
            arialToolStripMenuItem.Click += arialToolStripMenuItem_Click;
            // 
            // timesNewRomanToolStripMenuItem
            // 
            timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            timesNewRomanToolStripMenuItem.Size = new Size(332, 44);
            timesNewRomanToolStripMenuItem.Text = "TimesNewRoman";
            timesNewRomanToolStripMenuItem.Click += timesNewRomanToolStripMenuItem_Click;
            // 
            // выравниваниеToolStripMenuItem
            // 
            выравниваниеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поЦентруToolStripMenuItem, поЛевомуКраюToolStripMenuItem, поПравомуКраюToolStripMenuItem });
            выравниваниеToolStripMenuItem.Name = "выравниваниеToolStripMenuItem";
            выравниваниеToolStripMenuItem.Size = new Size(311, 44);
            выравниваниеToolStripMenuItem.Text = "Выравнивание";
            // 
            // поЦентруToolStripMenuItem
            // 
            поЦентруToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
            поЦентруToolStripMenuItem.Size = new Size(346, 44);
            поЦентруToolStripMenuItem.Text = "По центру";
            поЦентруToolStripMenuItem.Click += поЦентруToolStripMenuItem_Click;
            // 
            // поЛевомуКраюToolStripMenuItem
            // 
            поЛевомуКраюToolStripMenuItem.Name = "поЛевомуКраюToolStripMenuItem";
            поЛевомуКраюToolStripMenuItem.Size = new Size(346, 44);
            поЛевомуКраюToolStripMenuItem.Text = "По левому краю";
            поЛевомуКраюToolStripMenuItem.Click += поЛевомуКраюToolStripMenuItem_Click;
            // 
            // поПравомуКраюToolStripMenuItem
            // 
            поПравомуКраюToolStripMenuItem.Name = "поПравомуКраюToolStripMenuItem";
            поПравомуКраюToolStripMenuItem.Size = new Size(346, 44);
            поПравомуКраюToolStripMenuItem.Text = "По правому краю";
            поПравомуКраюToolStripMenuItem.Click += поПравомуКраюToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem1 });
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(183, 38);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            оПрограммеToolStripMenuItem1.Size = new Size(296, 44);
            оПрограммеToolStripMenuItem1.Text = "О программе";
            оПрограммеToolStripMenuItem1.Click += оПрограммеToolStripMenuItem1_Click;
            // 
            // Cut
            // 
            Cut.Location = new Point(711, 75);
            Cut.Name = "Cut";
            Cut.Size = new Size(159, 46);
            Cut.TabIndex = 2;
            Cut.Text = "Вырезать";
            Cut.UseVisualStyleBackColor = true;
            Cut.Click += Cut_Click;
            // 
            // Copy
            // 
            Copy.Location = new Point(711, 127);
            Copy.Name = "Copy";
            Copy.Size = new Size(159, 46);
            Copy.TabIndex = 3;
            Copy.Text = "Копировать";
            Copy.UseVisualStyleBackColor = true;
            Copy.Click += Copy_Click;
            // 
            // Paste
            // 
            Paste.Location = new Point(711, 179);
            Paste.Name = "Paste";
            Paste.Size = new Size(159, 46);
            Paste.TabIndex = 4;
            Paste.Text = "Вставить";
            Paste.UseVisualStyleBackColor = true;
            Paste.Click += Paste_Click;
            // 
            // Clean
            // 
            Clean.Location = new Point(711, 231);
            Clean.Name = "Clean";
            Clean.Size = new Size(159, 46);
            Clean.TabIndex = 5;
            Clean.Text = "Очистить";
            Clean.UseVisualStyleBackColor = true;
            Clean.Click += Clean_Click;
            // 
            // Highlight
            // 
            Highlight.Location = new Point(711, 283);
            Highlight.Name = "Highlight";
            Highlight.Size = new Size(159, 46);
            Highlight.TabIndex = 6;
            Highlight.Text = "Выделить";
            Highlight.UseVisualStyleBackColor = true;
            Highlight.Click += Highlight_Click;
            // 
            // Color
            // 
            Color.Location = new Point(711, 412);
            Color.Name = "Color";
            Color.Size = new Size(159, 46);
            Color.TabIndex = 7;
            Color.Text = "Цвет";
            Color.UseVisualStyleBackColor = true;
            Color.Click += Color_Click;
            // 
            // font
            // 
            font.Location = new Point(711, 482);
            font.Name = "font";
            font.Size = new Size(159, 46);
            font.TabIndex = 8;
            font.Text = "Шрифт";
            font.UseVisualStyleBackColor = true;
            font.Click += font_Click;
            // 
            // Open
            // 
            Open.Location = new Point(711, 550);
            Open.Name = "Open";
            Open.Size = new Size(159, 46);
            Open.TabIndex = 9;
            Open.Text = "Открыть";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // Save
            // 
            Save.Location = new Point(711, 619);
            Save.Name = "Save";
            Save.Size = new Size(159, 46);
            Save.TabIndex = 10;
            Save.Text = "Сохранить";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Exite
            // 
            Exite.Location = new Point(711, 698);
            Exite.Name = "Exite";
            Exite.Size = new Size(159, 46);
            Exite.TabIndex = 11;
            Exite.Text = "Выйти";
            Exite.UseVisualStyleBackColor = true;
            Exite.Click += button10_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // pageSetupDialog1
            // 
            pageSetupDialog1.Document = printDocument1;
            // 
            // printDialog1
            // 
            printDialog1.AllowSomePages = true;
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 810);
            Controls.Add(Exite);
            Controls.Add(Save);
            Controls.Add(Open);
            Controls.Add(font);
            Controls.Add(Color);
            Controls.Add(Highlight);
            Controls.Add(Clean);
            Controls.Add(Paste);
            Controls.Add(Copy);
            Controls.Add(Cut);
            Controls.Add(richTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox;
        private MenuStrip menuStrip1;
        private Button Cut;
        private Button Copy;
        private Button Paste;
        private Button Clean;
        private Button Highlight;
        private Button Color;
        private Button font;
        private Button Open;
        private Button Save;
        private Button Exite;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem сервисToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem предварительныйПросмотрToolStripMenuItem;
        private ToolStripMenuItem настройкаПринтераToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem цветToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem выравниваниеToolStripMenuItem;
        private ToolStripMenuItem поЦентруToolStripMenuItem;
        private ToolStripMenuItem поЛевомуКраюToolStripMenuItem;
        private ToolStripMenuItem поПравомуКраюToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private ToolStripMenuItem arialToolStripMenuItem;
        private ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}