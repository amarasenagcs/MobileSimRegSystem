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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&& textBox2.Text!=""&&textBox3.Text!=""&&textBox4.Text!=""&&textBox5.Text!=""&& textBox6.Text !="" && textBox7.Text!=""&& textBox8.Text !=""&&textBox9.Text !="")
            {
                if (textBox7.Text == textBox8.Text)
                {
                    //pass user input to user class
                    Userclass u1 = new Userclass();
                    u1.F_name = textBox1.Text;
                    u1.L_name = textBox2.Text;
                    u1.address = textBox3.Text;
                    u1.nic = textBox4.Text;
                    u1.contact = textBox5.Text;
                    u1.u_name = textBox6.Text;
                    u1.password = textBox7.Text;
                    u1.c_question = comboBox1.Text;
                    u1.c_answer = textBox9.Text;

                    //pass data to database
                    string add = "INSERT INTO `sim_registaration`.`user` (`UserName`, `Password`, `F_name`, `L_name`, `address`, `nic_num`, `contact_num`, `confirm_qustn`, `confirm_anwr`) VALUES('" + u1.u_name + "', '" + u1.password + "', '" + u1.F_name + "', '" + u1.L_name + "', '" + u1.address + "', '" + u1.nic + "', '" + u1.contact + "', '" + u1.c_question + "', '" + u1.c_answer + "');";
                    DataBase_connector db1 = new DataBase_connector();
                    db1.datainput(add);
                    MessageBox.Show("You have been successfuly");
                    // data clear 
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    comboBox1.Text = "Select";
                }
                else
                {
                    MessageBox.Show("not match password please recheck");
                }
                
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox1.Text = "Select";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
