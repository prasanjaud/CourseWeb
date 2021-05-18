using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWeb1
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        String roomType = "Lecture Hall";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            query = "insert into rooms (buildingName, roomName, roomType, capacity) values ('" + txtBuildingName.Text + "','" + txtRoomName.Text + "','"+roomType+"'," + txtCapacity.Text + ")";
            fn.setData(query);
            ClearAll();
        }

        private void rdBtnLectureHall_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "Lecture Hall";
        }

        private void rdBtnLaboratory_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "Laboratory";
        }

        public void ClearAll()
        {
            txtBuildingName.Clear();
            txtRoomName.Clear();
            txtCapacity.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnManageLocation_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ManageLocation form2 = new ManageLocation();
            //form2.Show();
        }

        private void btnLecture_Click(object sender, EventArgs e)
        {
            Form2 obj1 = new Form2();
            obj1.Show();
            this.Hide();
        }
    }
}
