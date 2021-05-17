
namespace CourseWeb1
{
    partial class ManageLocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdBtnLaboratory = new System.Windows.Forms.RadioButton();
            this.rdBtnLectureHall = new System.Windows.Forms.RadioButton();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblBuildingName = new System.Windows.Forms.Label();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpBoxTab = new System.Windows.Forms.GroupBox();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnStatic = new System.Windows.Forms.Button();
            this.btnStudentGrp = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnWorkingDandH = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.btnTag = new System.Windows.Forms.Button();
            this.btnLecture = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnAddLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.grpBoxTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(375, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(661, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rdBtnLaboratory
            // 
            this.rdBtnLaboratory.AutoSize = true;
            this.rdBtnLaboratory.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdBtnLaboratory.Location = new System.Drawing.Point(653, 394);
            this.rdBtnLaboratory.Name = "rdBtnLaboratory";
            this.rdBtnLaboratory.Size = new System.Drawing.Size(114, 32);
            this.rdBtnLaboratory.TabIndex = 21;
            this.rdBtnLaboratory.Text = "Laboratory";
            this.rdBtnLaboratory.UseVisualStyleBackColor = true;
            this.rdBtnLaboratory.CheckedChanged += new System.EventHandler(this.rdBtnLaboratory_CheckedChanged);
            // 
            // rdBtnLectureHall
            // 
            this.rdBtnLectureHall.AutoSize = true;
            this.rdBtnLectureHall.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdBtnLectureHall.Location = new System.Drawing.Point(533, 394);
            this.rdBtnLectureHall.Name = "rdBtnLectureHall";
            this.rdBtnLectureHall.Size = new System.Drawing.Size(124, 32);
            this.rdBtnLectureHall.TabIndex = 20;
            this.rdBtnLectureHall.Text = "Lecture Hall";
            this.rdBtnLectureHall.UseVisualStyleBackColor = true;
            this.rdBtnLectureHall.CheckedChanged += new System.EventHandler(this.rdBtnLectureHall_CheckedChanged);
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(534, 457);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(222, 23);
            this.txtCapacity.TabIndex = 19;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(179, 457);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(200, 23);
            this.txtRoomName.TabIndex = 18;
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(179, 399);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(200, 23);
            this.txtBuildingName.TabIndex = 17;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCapacity.Location = new System.Drawing.Point(388, 457);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(91, 24);
            this.lblCapacity.TabIndex = 16;
            this.lblCapacity.Text = "Capacity :";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoomType.Location = new System.Drawing.Point(388, 396);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(119, 24);
            this.lblRoomType.TabIndex = 15;
            this.lblRoomType.Text = "Room Type :";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoomName.Location = new System.Drawing.Point(19, 457);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(127, 24);
            this.lblRoomName.TabIndex = 14;
            this.lblRoomName.Text = "Room Name :";
            // 
            // lblBuildingName
            // 
            this.lblBuildingName.AutoSize = true;
            this.lblBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuildingName.Location = new System.Drawing.Point(19, 399);
            this.lblBuildingName.Name = "lblBuildingName";
            this.lblBuildingName.Size = new System.Drawing.Size(144, 24);
            this.lblBuildingName.TabIndex = 13;
            this.lblBuildingName.Text = "Building Name :";
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRoom.Location = new System.Drawing.Point(19, 136);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.RowTemplate.Height = 25;
            this.dataGridViewRoom.Size = new System.Drawing.Size(737, 188);
            this.dataGridViewRoom.TabIndex = 24;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
            this.dataGridViewRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(524, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpBoxTab
            // 
            this.grpBoxTab.Controls.Add(this.btnLocation);
            this.grpBoxTab.Controls.Add(this.btnStatic);
            this.grpBoxTab.Controls.Add(this.btnStudentGrp);
            this.grpBoxTab.Controls.Add(this.btnSubject);
            this.grpBoxTab.Controls.Add(this.btnWorkingDandH);
            this.grpBoxTab.Controls.Add(this.btnSession);
            this.grpBoxTab.Controls.Add(this.btnTag);
            this.grpBoxTab.Controls.Add(this.btnLecture);
            this.grpBoxTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpBoxTab.Location = new System.Drawing.Point(0, 10);
            this.grpBoxTab.Name = "grpBoxTab";
            this.grpBoxTab.Size = new System.Drawing.Size(791, 41);
            this.grpBoxTab.TabIndex = 26;
            this.grpBoxTab.TabStop = false;
            // 
            // btnLocation
            // 
            this.btnLocation.BackColor = System.Drawing.Color.Gray;
            this.btnLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocation.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLocation.Location = new System.Drawing.Point(351, 6);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(95, 33);
            this.btnLocation.TabIndex = 7;
            this.btnLocation.Text = "Locations";
            this.btnLocation.UseVisualStyleBackColor = false;
            // 
            // btnStatic
            // 
            this.btnStatic.BackColor = System.Drawing.Color.Silver;
            this.btnStatic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStatic.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStatic.Location = new System.Drawing.Point(445, 6);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(84, 33);
            this.btnStatic.TabIndex = 6;
            this.btnStatic.Text = "Statics";
            this.btnStatic.UseVisualStyleBackColor = false;
            // 
            // btnStudentGrp
            // 
            this.btnStudentGrp.BackColor = System.Drawing.Color.Silver;
            this.btnStudentGrp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudentGrp.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStudentGrp.Location = new System.Drawing.Point(84, 6);
            this.btnStudentGrp.Name = "btnStudentGrp";
            this.btnStudentGrp.Size = new System.Drawing.Size(123, 33);
            this.btnStudentGrp.TabIndex = 5;
            this.btnStudentGrp.Text = "Student Groups";
            this.btnStudentGrp.UseVisualStyleBackColor = false;
            // 
            // btnSubject
            // 
            this.btnSubject.BackColor = System.Drawing.Color.Silver;
            this.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubject.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubject.Location = new System.Drawing.Point(206, 6);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(78, 33);
            this.btnSubject.TabIndex = 4;
            this.btnSubject.Text = "Subjects";
            this.btnSubject.UseVisualStyleBackColor = false;
            // 
            // btnWorkingDandH
            // 
            this.btnWorkingDandH.BackColor = System.Drawing.Color.Silver;
            this.btnWorkingDandH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWorkingDandH.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWorkingDandH.Location = new System.Drawing.Point(611, 6);
            this.btnWorkingDandH.Name = "btnWorkingDandH";
            this.btnWorkingDandH.Size = new System.Drawing.Size(174, 33);
            this.btnWorkingDandH.TabIndex = 3;
            this.btnWorkingDandH.Text = "Working Days and Hours";
            this.btnWorkingDandH.UseVisualStyleBackColor = false;
            this.btnWorkingDandH.Click += new System.EventHandler(this.btnWorkingDandH_Click);
            // 
            // btnSession
            // 
            this.btnSession.BackColor = System.Drawing.Color.Silver;
            this.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSession.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSession.Location = new System.Drawing.Point(528, 6);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(84, 33);
            this.btnSession.TabIndex = 2;
            this.btnSession.Text = "Sessions";
            this.btnSession.UseVisualStyleBackColor = false;
            // 
            // btnTag
            // 
            this.btnTag.BackColor = System.Drawing.Color.Silver;
            this.btnTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTag.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTag.Location = new System.Drawing.Point(283, 6);
            this.btnTag.Name = "btnTag";
            this.btnTag.Size = new System.Drawing.Size(69, 33);
            this.btnTag.TabIndex = 1;
            this.btnTag.Text = "Tags";
            this.btnTag.UseVisualStyleBackColor = false;
            // 
            // btnLecture
            // 
            this.btnLecture.BackColor = System.Drawing.Color.Silver;
            this.btnLecture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLecture.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLecture.Location = new System.Drawing.Point(1, 6);
            this.btnLecture.Name = "btnLecture";
            this.btnLecture.Size = new System.Drawing.Size(84, 33);
            this.btnLecture.TabIndex = 0;
            this.btnLecture.Text = "Lectures";
            this.btnLecture.UseVisualStyleBackColor = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.ForeColor = System.Drawing.Color.Yellow;
            this.lblHeading.Location = new System.Drawing.Point(15, 82);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(183, 29);
            this.lblHeading.TabIndex = 27;
            this.lblHeading.Text = "Manage Rooms";
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.BackColor = System.Drawing.Color.Gray;
            this.btnAddLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddLocation.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddLocation.Location = new System.Drawing.Point(627, 84);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(120, 33);
            this.btnAddLocation.TabIndex = 8;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = false;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // ManageLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(785, 499);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.grpBoxTab);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewRoom);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rdBtnLaboratory);
            this.Controls.Add(this.rdBtnLectureHall);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.lblBuildingName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Location";
            this.Load += new System.EventHandler(this.ManageLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.grpBoxTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdBtnLaboratory;
        private System.Windows.Forms.RadioButton rdBtnLectureHall;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblBuildingName;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpBoxTab;
        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Button btnStudentGrp;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnWorkingDandH;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Button btnTag;
        private System.Windows.Forms.Button btnLecture;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnAddLocation;
    }
}