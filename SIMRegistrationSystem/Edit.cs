using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRegistrationSystem
{
    public partial class Form4 : Form
    {
        List<Sim> simL = new List<Sim>();

        public Form4()
        {
            InitializeComponent();
            this.dateTimePicker1.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Sim s3 = new Sim();
             Int32 rows = (e.RowIndex);
             DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[rows];
             s3.userID= Convert.ToInt32(row.Cells[0].Value);
             string select = "SELECT * FROM sim_registaration.sim where SIM_Id='"+s3.userID+"';";
             DataBase_connector db1 = new DataBase_connector();
             DataTable dt = db1.read(select);
            foreach (DataRow dr in dt.Rows)
            {
               
                Form3 f1 = new Form3();
                f1.textBox1.Text = dr[2].ToString();
                if (row.Cells[1].Value.ToString() == "")
                {
                    f1.textBox2.Enabled = false;
                }
                else
                {
                    f1.textBox2.Text = dr[1].ToString();
                }
                f1.textBox3.Text = dr[3].ToString();
                f1.textBox4.Text = dr[4].ToString();
                f1.textBox5.Text = dr[5].ToString();
                f1.textBox6.Text = dr[6].ToString();
                f1.label9.Text = dr[8].ToString();
                f1.label10.Text = dr[0].ToString();
                string mobiletype = dr[8].ToString();
                f1.Text = "SIMRegistration ["+ mobiletype + "]";
                f1.textBox8.Text= dr[10].ToString();
                f1.textBox7.Text= dr[11].ToString();
                string img1location = dr[10].ToString();
                string img2location = dr[11].ToString();
                
                f1.pictureBox1.Image = Image.FromFile(img1location);
                f1.pictureBox2.Image = Image.FromFile(img2location);

                string Gender = dr[7].ToString();
                if (Gender == "Male")
                {
                    f1.radioButton1.Checked = true;
                }
                else
                {
                    f1.radioButton2.Checked = true;
                }
                Form2 f2 = new Form2();
                {
                    f1.button1.Visible = false;
                    f1.button2.Visible = true;
                }

                this.Hide();
                f1.ShowDialog();
                dataGridView1.Rows.Clear();
                this.dataload();
                this.Show();
            }
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        private void dataload()
        {
            string date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            Sim s2 = new Sim();
            Form2 f1 = new Form2();
            DataBase_connector bd1 = new DataBase_connector();
            string select = "SELECT * FROM sim_registaration.sim where Date = '"+date+"' ;";
            DataTable dt1 = bd1.read(select);
            foreach (DataRow dr in dt1.Rows)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = dr[0].ToString();
                row.Cells[1].Value = dr[1].ToString();
                row.Cells[2].Value = dr[3].ToString();
                row.Cells[3].Value = dr[4].ToString();
                row.Cells[4].Value = dr[2].ToString();
                row.Cells[5].Value = dr[5].ToString();
                row.Cells[6].Value = dr[9].ToString();
                row.Cells[7].Value = "More deteils";
                dataGridView1.Rows.Add(row);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Form2 f1 = new Form2();
            this.dataload();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            this.dataload();
           
        }
    }
}
