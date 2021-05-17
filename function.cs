using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CourseWeb1
{
    class function
    {
        protected MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Server=localhost;Uid=root;password=root;Database=itpm;";
            return con;
        }

        public DataSet getData(String query)
        {
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query)
        {
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
