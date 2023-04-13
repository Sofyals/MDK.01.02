namespace calculator1
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        double heightt;
        double weightt;
        double BMI;
        int m;





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labe_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            height.Text = null; x.Visible = false; g.Visible = false; n.Visible = false; dress.Visible = false; t.Visible = false;
            weight.Text = null; label8.Text = null; label8.Visible = false; label2.Text = null; label2.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

            m = 1;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            m = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            heightt = Convert.ToDouble(height.Text) / 100;
            weightt = Convert.ToDouble(weight.Text);
            BMI = Math.Round(weightt / (heightt * heightt));
            trackBar1.Value = Convert.ToInt32(BMI);
            if (trackBar1.Value < 19)
            {
                label8.Text = "Недостаточный вес"; label8.Visible = true; label2.Text = "Индекс массы тела = " + Convert.ToString(trackBar1.Value); label2.Visible = true;
                if (m == 1)
                {
                    x.Visible = true;
                }
                else 
                {
                    dress.Visible = true;
                }
            }
            else if (trackBar1.Value >= 19 && trackBar1.Value < 25)
            {
                label8.Text = "Здоровый вес"; label8.Visible = true; label2.Text = "Индекс массы тела = " + Convert.ToString(trackBar1.Value); label2.Visible = true;
                if (m == 1)
                {
                    n.Visible = true;
                }
                else 
                {
                    dress.Visible = true;
                }
            }

            else if (trackBar1.Value >= 25 && trackBar1.Value < 30)
            {
                label8.Text = "Избыточный вес"; label8.Visible = true; label2.Text = "Индекс массы тела = " + Convert.ToString(trackBar1.Value); label2.Visible = true;
                if (m == 1)
                {

                    t.Visible = true; dress.Visible = false;

                }
                else 
                {
                    dress.Visible = true; t.Visible = false;
                }
            }

            else if (trackBar1.Value >= 30)
            {
                label8.Text = "Ожирение"; label8.Visible = true; 
                label2.Text = "Индекс массы тела = " + Convert.ToString(trackBar1.Value); 
                label2.Visible = true;
                if (m == 1)
                {
                    g.Visible = true;dress.Visible = false;
                }
                else 
                {
                    dress.Visible = true; g.Visible = false;
                }
            }


        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}