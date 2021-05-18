using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPM2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            {


                try
                {
                    //con.Open();
                    //string sql = "INSERT INTO lectureinfo(lecturer_Name,emp_Id,faculty,department,center,building,level,rank) VALUES" +
                    //    "('" + lname.Text.Trim() + "','" + eid.Text.Trim() + "','" + faculty.Text.Trim() + "','" + department.Text.Trim() + "','" + center.Text.Trim() + "','" + building.Text.Trim() + "','" + level.Text.Trim() + "','" + rank.Text.Trim() + "')";
                    //SqlCommand cmd = new SqlCommand(sql, con);
                    //int r = cmd.ExecuteNonQuery();

                   //// if (r > 0)
                   // {
                   //     MessageBox.Show("Successfully Added");
                   // }
                   // else
                   // {
                   //     MessageBox.Show("Failed!");
                   // }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //con.Close();
                }

                lname.Text = "";
                eid.Text = "";
                faculty.Text = "";
                department.Text = "";
                center.Text = "";
                building.Text = "";
                level.Text = "";
                rank.Text = "";


            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lname.Text = "";
            eid.Text = "";
            faculty.Text = "";
            department.Text = "";
            center.Text = "";
            building.Text = "";
            level.Text = "";
            rank.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {

            String num1 = eid.Text;
            String num2 = level.Text;
            int val = 0;


            switch (num2)
            {
                case "Professor":
                    val = 1;
                    break;
                case "Assistant Professor":
                    val = 2;
                    break;
                case "Senior Lecturer(HG)":
                    val = 3;
                    break;
                case "Senior Lecturer":
                    val = 4;
                    break;
                case "Lecturer":
                    val = 5;
                    break;
                case "Assistant Lecturer":
                    val = 6;
                    break;
                default:
                    break;


            }
            rank.Text = val + "." + num1;
        }
    }
}
