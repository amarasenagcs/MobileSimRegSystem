using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIMRegistrationSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void SIM_Category_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f1 = new Form3();
            f1.label9.Text = "Mobitel";
            f1.Text = "SIMRegistration [Mobitel]";       
            f1.ShowDialog();
            this.Show();
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f2 = new Form3();
            f2.label9.Text = "Dialog";
            f2.Text = "SIMRegistration [Dialog]";
            f2.ShowDialog();
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            User f1 = new User();
            f1.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.label9.Text = "Airtel";
            f3.Text = "SIMRegistration [Airtel]";
            f3.ShowDialog();
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f4 = new Form3();
            f4.label9.Text = "Hutch";
            f4.Text = "SIMRegistration [Hutch]";
            f4.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f5 = new Form3();
            f5.label9.Text = "Etisalt";
            f5.Text = "SIMRegistration [Etisalat]";
            f5.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f6 = new Form4();
            f6.ShowDialog();
            this.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f6 = new Form4();
            
            if (label7.Text == "employee")
            {
                f6.dataGridView1.Columns[7].Visible = false;
            }
            f6.ShowDialog();
            this.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
