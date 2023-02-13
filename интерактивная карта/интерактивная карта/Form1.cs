using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace интерактивная_карта
{
    public partial class Landmark : Form
    {
        public Landmark()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible= true;pictureBox7.Visible= true;
            pictureBox3.Visible= false;pictureBox5.Visible= false;pictureBox4.Visible= false;label11.Visible = true; label22.Visible = true; label33.Visible = false; label44.Visible = false;
            label55.Visible = false; label8.Visible = true; label8.Text = "МЦК Лужники"; pictureBox5.Location = new Point(801, 720); label55.Location = new Point(941, 773); label3.Visible = false; label4.Visible = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pictureBox3.Visible= true;pictureBox4.Visible= true;pictureBox5.Visible = true;pictureBox6.Visible= true;
            pictureBox7.Visible= true;label11.Visible= true;label22.Visible=true;label33.Visible=true;label44.Visible=true;
            label55.Visible=true; label8.Visible = true; label8.Text = "Новодевичей монастырь"; pictureBox5.Location = new Point(801, 720); label55.Location = new Point(941, 773); label3.Visible = false; label4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true; pictureBox7.Visible = true;
            pictureBox3.Visible = false; pictureBox5.Visible = false; pictureBox4.Visible = true; label11.Visible = true; label22.Visible = true; label33.Visible = true; label44.Visible = false;
            label55.Visible = false; label8.Visible = true; label8.Text = "Метро Киевская"; pictureBox5.Location = new Point(801, 720); label55.Location = new Point(941, 773); label3.Visible = false; label4.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true; pictureBox7.Visible = true;
            pictureBox3.Visible = false; pictureBox5.Visible = true; pictureBox4.Visible = true; label11.Visible = true; label22.Visible = true; label33.Visible = true; label44.Visible = false;
            label55.Visible = true; label8.Visible = true; label8.Text = "МИД"; pictureBox5.Location = new Point(801, 577); label55.Location = new Point(941, 617); label3.Visible = false; label4.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true; pictureBox7.Visible = true;
            pictureBox3.Visible = true; pictureBox5.Visible = false; pictureBox4.Visible = true; label11.Visible = true; label22.Visible = true; label33.Visible = true; label44.Visible = true;
            label55.Visible = false; label8.Visible = true; label8.Text = "Парк Горького"; pictureBox5.Location = new Point(801, 720); label55.Location = new Point(941, 773); label3.Visible = false; label4.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true; pictureBox7.Visible = true;
            pictureBox3.Visible = false; pictureBox5.Visible = false; pictureBox4.Visible = true; label11.Visible = true; label22.Visible = true; label33.Visible = true; label44.Visible = false;
            label55.Visible = false; label8.Visible = true; label8.Text = "Здания РАН"; pictureBox5.Location = new Point(801, 720); label55.Location = new Point(941, 773); label3.Visible = false; label4.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true; pictureBox6.Visible = true;
            pictureBox7.Visible = true; label11.Visible = true; label22.Visible = true; label33.Visible = true; label44.Visible = true;
            label55.Visible = true; label8.Visible = true; label8.Text = "Метро Воробьевы горы"; pictureBox5.Location = new Point(801, 720); label55.Location = new Point(941, 773); label3.Visible = false; label4.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true; pictureBox6.Visible = true;
            pictureBox7.Visible = true; label11.Visible = true; label22.Visible = true; label33.Visible = true; label44.Visible = true;
            label55.Visible = true;label8.Visible= true; label8.Text = "Стадион Лужники"; pictureBox5.Location = new Point(801, 720); label55.Location = new Point(941, 773); label3.Visible = false; label4.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox6.Visible = false;
            pictureBox7.Visible = false; label11.Visible = false; label22.Visible = false; label33.Visible = false; label44.Visible = false;
            label55.Visible = false; label8.Visible = false;label3.Visible = true; label4.Visible = true;label3.Text = "Старт марафона";
            label4.Text = "Полный маршрут:" +
                "40 километров";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox6.Visible = false;
            pictureBox7.Visible = false; label11.Visible = false; label22.Visible = false; label33.Visible = false; label44.Visible = false;
            label55.Visible = false; label8.Visible = false;
            label3.Visible = true; label4.Visible = true; label3.Text = "Старт марафона";
            label4.Text = "Часть маршрута:" +
                "20 километров";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox6.Visible = false;
            pictureBox7.Visible = false; label11.Visible = false; label22.Visible = false; label33.Visible = false; label44.Visible = false;
            label55.Visible = false; label8.Visible = false; label3.Visible = true; label4.Visible = true; label3.Text = "Старт марафона";
            label4.Text = "Часть маршрута:" +
                "5 километров";
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
