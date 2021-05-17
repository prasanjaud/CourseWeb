
namespace CourseWeb1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblBuildingName = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.rdBtnLectureHall = new System.Windows.Forms.RadioButton();
            this.rdBtnLaboratory = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpBoxTab = new System.Windows.Forms.GroupBox();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnStatic = new System.Windows.Forms.Button();
            this.btnStudentGrp = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnWorkingDandH = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.btnTag = new System.Windows.Forms.Button();
            this.btnLecture = new System.Windows.Forms.Button();
            this.btnManageLocation = new System.Windows.Forms.Button();
            this.grpBoxTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.ForeColor = System.Drawing.Color.Yellow;
            this.lblHeading.Location = new System.Drawing.Point(12, 62);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(299, 29);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Add Rooms Building Wise:";
            // 
            // lblBuildingName
            // 
            this.lblBuildingName.AutoSize = true;
            this.lblBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuildingName.Location = new System.Drawing.Point(152, 129);
            this.lblBuildingName.Name = "lblBuildingName";
            this.lblBuildingName.Size = new System.Drawing.Size(159, 24);
            this.lblBuildingName.TabIndex = 1;
            this.lblBuildingName.Text = "Building Name :";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoomName.Location = new System.Drawing.Point(152, 180);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(138, 24);
            this.lblRoomName.TabIndex = 2;
            this.lblRoomName.Text = "Room Name :";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoomType.Location = new System.Drawing.Point(152, 235);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(130, 24);
            this.lblRoomType.TabIndex = 3;
            this.lblRoomType.Text = "Room Type :";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCapacity.Location = new System.Drawing.Point(152, 296);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(101, 24);
            this.lblCapacity.TabIndex = 4;
            this.lblCapacity.Text = "Capacity :";
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(361, 129);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(213, 23);
            this.txtBuildingName.TabIndex = 5;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(361, 180);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(213, 23);
            this.txtRoomName.TabIndex = 6;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(361, 296);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(213, 23);
            this.txtCapacity.TabIndex = 7;
            // 
            // rdBtnLectureHall
            // 
            this.rdBtnLectureHall.AutoSize = true;
            this.rdBtnLectureHall.Checked = true;
            this.rdBtnLectureHall.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdBtnLectureHall.Location = new System.Drawing.Point(361, 239);
            this.rdBtnLectureHall.Name = "rdBtnLectureHall";
            this.rdBtnLectureHall.Size = new System.Drawing.Size(105, 27);
            this.rdBtnLectureHall.TabIndex = 8;
            this.rdBtnLectureHall.TabStop = true;
            this.rdBtnLectureHall.Text = "Lecture Hall";
            this.rdBtnLectureHall.UseVisualStyleBackColor = true;
            this.rdBtnLectureHall.CheckedChanged += new System.EventHandler(this.rdBtnLectureHall_CheckedChanged);
            // 
            // rdBtnLaboratory
            // 
            this.rdBtnLaboratory.AutoSize = true;
            this.rdBtnLaboratory.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdBtnLaboratory.Location = new System.Drawing.Point(470, 239);
            this.rdBtnLaboratory.Name = "rdBtnLaboratory";
            this.rdBtnLaboratory.Size = new System.Drawing.Size(98, 27);
            this.rdBtnLaboratory.TabIndex = 9;
            this.rdBtnLaboratory.Text = "Laboratory";
            this.rdBtnLaboratory.UseVisualStyleBackColor = true;
            this.rdBtnLaboratory.CheckedChanged += new System.EventHandler(this.rdBtnLaboratory_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClear.Location = new System.Drawing.Point(260, 361);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSave.Location = new System.Drawing.Point(437, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.grpBoxTab.ForeColor = System.Drawing.Color.Black;
            this.grpBoxTab.Location = new System.Drawing.Point(0, 3);
            this.grpBoxTab.Name = "grpBoxTab";
            this.grpBoxTab.Size = new System.Drawing.Size(784, 41);
            this.grpBoxTab.TabIndex = 27;
            this.grpBoxTab.TabStop = false;
            // 
            // btnLocation
            // 
            this.btnLocation.BackColor = System.Drawing.Color.Gray;
            this.btnLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocation.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLocation.Location = new System.Drawing.Point(349, 6);
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
            this.btnStatic.Location = new System.Drawing.Point(443, 6);
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
            this.btnStudentGrp.Location = new System.Drawing.Point(82, 6);
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
            this.btnSubject.Location = new System.Drawing.Point(204, 6);
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
            this.btnWorkingDandH.Location = new System.Drawing.Point(607, 6);
            this.btnWorkingDandH.Name = "btnWorkingDandH";
            this.btnWorkingDandH.Size = new System.Drawing.Size(178, 33);
            this.btnWorkingDandH.TabIndex = 3;
            this.btnWorkingDandH.Text = "Working Days and Hours";
            this.btnWorkingDandH.UseVisualStyleBackColor = false;
            // 
            // btnSession
            // 
            this.btnSession.BackColor = System.Drawing.Color.Silver;
            this.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSession.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSession.Location = new System.Drawing.Point(526, 6);
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
            this.btnTag.Location = new System.Drawing.Point(281, 6);
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
            this.btnLecture.Location = new System.Drawing.Point(0, 6);
            this.btnLecture.Name = "btnLecture";
            this.btnLecture.Size = new System.Drawing.Size(84, 33);
            this.btnLecture.TabIndex = 0;
            this.btnLecture.Text = "Lectures";
            this.btnLecture.UseVisualStyleBackColor = false;
            // 
            // btnManageLocation
            // 
            this.btnManageLocation.BackColor = System.Drawing.Color.Gray;
            this.btnManageLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManageLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnManageLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageLocation.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnManageLocation.Location = new System.Drawing.Point(603, 62);
            this.btnManageLocation.Name = "btnManageLocation";
            this.btnManageLocation.Size = new System.Drawing.Size(126, 33);
            this.btnManageLocation.TabIndex = 28;
            this.btnManageLocation.Text = "Manage Location";
            this.btnManageLocation.UseVisualStyleBackColor = false;
            this.btnManageLocation.Click += new System.EventHandler(this.btnManageLocation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.btnManageLocation);
            this.Controls.Add(this.grpBoxTab);
            this.Controls.Add(this.btnSave);
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
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Rooms";
            this.grpBoxTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblBuildingName;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.RadioButton rdBtnLectureHall;
        private System.Windows.Forms.RadioButton rdBtnLaboratory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpBoxTab;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Button btnStudentGrp;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnWorkingDandH;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Button btnTag;
        private System.Windows.Forms.Button btnLecture;
        private System.Windows.Forms.Button btnManageLocation;
    }
}

