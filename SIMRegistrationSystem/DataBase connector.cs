using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SIMRegistrationSystem
{
    class DataBase_connector
    {
        private string datasource;
        private string port;
        private string username;
        private string password;
        private string database;
        private MySqlConnection conn;

        public DataBase_connector()
        {
            this.datasource = "127.0.0.1;";
            this.port = "3306;";
            this.username = "root;";
            this.password = "root;";
            this.database = "sim_registaration";
            this.conn = new MySqlConnection("datasource =" + this.datasource + "port =" + this.port + "" + "username =" + this.username + "password =" + this.password + "database =" + this.database);

        }
        public void datainput(string x)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(x, this.conn);
                MySqlDataReader mr;
                this.conn.Open();
                mr = command.ExecuteReader();
                this.conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public void dataupdate(string x)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(x, this.conn);
                MySqlDataReader mr;
                this.conn.Open();
                mr = command.ExecuteReader();
                this.conn.Close();
            }
            catch (Exception)
            {

            }

        }
         public DataTable read(string x)
         {
            DataTable dt = new DataTable();
            try
            {
                 MySqlDataAdapter da;
                 da = new MySqlDataAdapter(x, this.conn);
                 da.Fill(dt);  
             }
             catch
             {
             }
            return dt;
         }
        
    }
}
    