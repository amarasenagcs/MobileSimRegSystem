using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SIMRegistrationSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void SIMRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f3 = new Form4();
            f3.Show();
            this.Close();
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            OpenFileDialog img1 = new OpenFileDialog();
            img1.Filter = "Choose image(*.JPG;*.PNG;*.GIF) |*.jpg;*.png;*.gif";

            if (img1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(img1.FileName);
                textBox8.Text = img1.FileName;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog img2 = new OpenFileDialog();
            img2.Filter = "Choose image(*.JPG;*.PNG;*.GIF) |*.jpg;*.png;*.gif";

            if (img2.ShowDialog() == DialogResult.OK)
            {
                textBox7.Text = img2.FileName;
                pictureBox2.Image = Image.FromFile(img2.FileName);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && pictureBox1.Image != null && pictureBox2.Image != null && (radioButton1.Checked || radioButton2.Checked))
            {
                //pass customer details to Sim class
                Sim s1 = new Sim();
                s1.sim_num = textBox1.Text;
                s1.P_num = textBox2.Text;
                s1.F_name = textBox3.Text;
                s1.L_name = textBox4.Text;
                s1.nic = textBox5.Text;
                s1.address = textBox6.Text;
                s1.img1Loc = textBox8.Text;
                s1.img2Loc = textBox7.Text;
                string newFileName1 = s1.img1Loc.Replace("\\", "\\\\");
                string newFileName2 = s1.img2Loc.Replace("\\", "\\\\");
                if (radioButton1.Checked)
                {
                    s1.Gender = "Male";
                }
                else if (radioButton2.Checked)
                {
                    s1.Gender = "Female";
                }


                s1.SIM_Category = label9.Text;

                // pass data to database 
                s1.date = DateTime.Now.ToString("yyyy/MM/dd");
                string add = "INSERT INTO `sim_registaration`.`sim` (`phonnumbr`, `SIM_Number`, `First Name`, `Last Name`, `NIC Number`, `Address`, `Gender`, `SIM Category`, `Date`, `img1Location`, `img2Location`) VALUES ('" + s1.P_num + "', '" + s1.sim_num + "', '" + s1.F_name + "', '" + s1.L_name + "', '" + s1.nic + "', '" + s1.address + "', '" + s1.Gender + "', '" + s1.SIM_Category + "', '" + s1.date + "', '" + newFileName1 + "', '" + newFileName2 + "');";
                DataBase_connector db2 = new DataBase_connector();
                db2.datainput(add);
                MessageBox.Show("Successfuly save details");
               
                //image backup save
                //  File.Copy(textBox7.Text, Path.Combine(@"C:\Users\Chinthaka\Desktop\saveiamge\", Path.GetFileName(textBox7.Text)), true);


                //auto clear form data
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                pictureBox1.Image = null;
                pictureBox2.Image = null;

            }
            else
            {
                MessageBox.Show("Please fill the all filed");
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(groupBox1.Width, groupBox1.Height);
            groupBox1.DrawToBitmap(bm, new Rectangle(0, 0, groupBox1.Width, groupBox1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && pictureBox1.Image != null && pictureBox2.Image != null && (radioButton1.Checked||radioButton2.Checked))
            {
                //pass customer details to Sim class
                Sim s1 = new Sim();
                s1.sim_num = textBox1.Text;
                s1.P_num = textBox2.Text;
                s1.F_name = textBox3.Text;
                s1.L_name = textBox4.Text;
                s1.nic = textBox5.Text;
                s1.address = textBox6.Text;
                s1.img1Loc = textBox8.Text;
                s1.img2Loc = textBox7.Text;
                string newFileName1 = s1.img1Loc.Replace("\\", "\\\\");
                string newFileName2 = s1.img2Loc.Replace("\\", "\\\\");
               Int32 id = Convert.ToInt32(label10.Text);
                if (radioButton1.Checked)
                {
                    s1.Gender = "Male";
                }
                else if (radioButton2.Checked)
                {
                    s1.Gender = "Female";
                }


                s1.SIM_Category = label9.Text;

                // update database data
                s1.date = DateTime.Now.ToString("yyyy/MM/dd");
                string update = "UPDATE `sim_registaration`.`sim` SET `phonnumbr`='"+s1.P_num+"', `SIM_Number`='"+s1.sim_num+"', `First Name`='"+s1.F_name+"', `Last Name`='"+s1.L_name+"', `NIC Number`='"+s1.nic+"', `Address`='"+s1.address+"', `Gender`='"+s1.Gender+"', `SIM Category`='"+s1.SIM_Category+"', `Date`='"+s1.date+"', `img1Location`='"+newFileName1+"', `img2Location`='"+newFileName2+"' WHERE `SIM_Id`='"+id+"';";
                DataBase_connector db3 = new DataBase_connector();
                db3.datainput(update);

                //image backup save
               // File.Copy(textBox7.Text, Path.Combine(@"C:\Users\Chinthaka\Desktop\saveiamge\", Path.GetFileName(textBox7.Text)), true);

                //print
                printDocument1.PrintPage += printDocument1_PrintPage;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    button1.Hide();
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    button5.Hide();
                    button6.Hide();
                    button7.Hide();

                    printDocument1.Print();
                }
                //auto clear form data
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                pictureBox1.Image = null;
                pictureBox2.Image = null;

            }
            else
            {
                MessageBox.Show("Please fill the all filed");
            }
           
        }
    }
}
