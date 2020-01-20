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
    public partial class Form5 : Form
    {
        Userclass u1 = new Userclass();

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                
                string nic_num = textBox2.Text;
                DataBase_connector dc = new DataBase_connector();
                string check = "SELECT * FROM sim_registaration.user where nic_num='" + nic_num + "';";
                DataTable dt = dc.read(check);
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        textBox1.Text = row[1].ToString(); ;
                        groupBox2.Visible = true;
                        label9.Text = row[8].ToString();
                        u1.c_answer = row[9].ToString();
                        u1.userID = Convert.ToInt32(row[0]);
                    }
                }
                else
                {
                    MessageBox.Show("User name or NIC incorrect");
                }
            }
            else
            {
                MessageBox.Show("Empty user name or password");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {

                string answer = textBox5.Text;
                if (answer == u1.c_answer)
                {
                    label3.Visible = true;
                    label4.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    button2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid answer");
                }
            }
        

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                if (textBox3.Text == textBox4.Text)
                {
                    u1.password = textBox3.Text;
                    DataBase_connector dc = new DataBase_connector();
                    string update = "UPDATE `sim_registaration`.`user` SET `Password`='" + u1.password + "' WHERE `UserID`='" + u1.userID + "';";
                    dc.datainput(update);
                    MessageBox.Show("Succsessfully reset you password");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = ""; 
                }
                else
                {
                    MessageBox.Show("Password not match please re check");
                }
            }
            else
            {
                MessageBox.Show("fill the all fields");
            }
        }
    }
}
