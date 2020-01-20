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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_lgn_Click(object sender, EventArgs e)
        {

        }

        private void Lgn_Frm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_lgn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_lgn_Click_2(object sender, EventArgs e)
        {
            
        }

        private void btn_lgn_Click_3(object sender, EventArgs e)
        {
            if (txt_user.Text!= "" && txt_pswd.Text != "")
            {
                string username = txt_user.Text;
                DataBase_connector dc = new DataBase_connector();
                string add = "SELECT * FROM sim_registaration.user where UserName='"+username+"';";
                DataTable dt= dc.read(add);
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Userclass u1 = new Userclass();
                        u1.password = row[2].ToString();
                        u1.job = row[10].ToString();
                        
                        if (u1.password == txt_pswd.Text)
                        {
                           
                            
                            
                            if (u1.job == "Admin")
                            {
                                Form2 f2 = new Form2();
                                f2.menuStripadmin.Visible = true;
                               f2.label7.Text = "Admin";
                                this.Hide();
                                f2.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                Form2 f2 = new Form2();
                                f2.menuStrip2.Visible = true;
                               f2.label7.Text = "employee";
                                this.Hide();
                                f2.ShowDialog();
                                this.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show(" passsword incorrect");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("wrong user name");
                }
            }
            else
            {
                MessageBox.Show("Empty User name or Password");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f1 = new Form5();
            f1.ShowDialog();
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_pswd.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pswd.UseSystemPasswordChar = true;
            }
        }
    }
}
