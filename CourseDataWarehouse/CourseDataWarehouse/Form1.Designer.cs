namespace CourseDataWarehouse
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
            yearComboBox = new ComboBox();
            semesterComboBox = new ComboBox();
            genderComboBox = new ComboBox();
            majorComboBox = new ComboBox();
            departmentComboBox = new ComboBox();
            facultyComboBox = new ComboBox();
            universityComboBox = new ComboBox();
            titleLabel = new Label();
            listOfCoursesLabel = new Label();
            numberOfCoursesTextBox = new TextBox();
            label1 = new Label();
            yearCheckBox = new CheckBox();
            semesterCheckBox = new CheckBox();
            majorCheckBox = new CheckBox();
            genderCheckBox = new CheckBox();
            departmentCheckBox = new CheckBox();
            facultyCheckBox = new CheckBox();
            universityCheckBox = new CheckBox();
            searchBtn = new Button();
            instructorGroupBox = new GroupBox();
            studentGroupBox = new GroupBox();
            institutionGroupBox = new GroupBox();
            dateGroupBox = new GroupBox();
            coursesDataView = new DataGridView();
            instructorGroupBox.SuspendLayout();
            studentGroupBox.SuspendLayout();
            institutionGroupBox.SuspendLayout();
            dateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coursesDataView).BeginInit();
            SuspendLayout();
            // 
            // yearComboBox
            // 
            yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(109, 27);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(151, 28);
            yearComboBox.TabIndex = 7;
            // 
            // semesterComboBox
            // 
            semesterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            semesterComboBox.FormattingEnabled = true;
            semesterComboBox.Location = new Point(109, 73);
            semesterComboBox.Name = "semesterComboBox";
            semesterComboBox.Size = new Size(151, 28);
            semesterComboBox.TabIndex = 8;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(97, 75);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(151, 28);
            genderComboBox.TabIndex = 9;
            // 
            // majorComboBox
            // 
            majorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            majorComboBox.FormattingEnabled = true;
            majorComboBox.Location = new Point(97, 27);
            majorComboBox.Name = "majorComboBox";
            majorComboBox.Size = new Size(151, 28);
            majorComboBox.TabIndex = 10;
            // 
            // departmentComboBox
            // 
            departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(130, 27);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(151, 28);
            departmentComboBox.TabIndex = 11;
            // 
            // facultyComboBox
            // 
            facultyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            facultyComboBox.FormattingEnabled = true;
            facultyComboBox.Location = new Point(130, 75);
            facultyComboBox.Name = "facultyComboBox";
            facultyComboBox.Size = new Size(151, 28);
            facultyComboBox.TabIndex = 12;
            // 
            // universityComboBox
            // 
            universityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            universityComboBox.FormattingEnabled = true;
            universityComboBox.Location = new Point(113, 35);
            universityComboBox.Name = "universityComboBox";
            universityComboBox.Size = new Size(151, 28);
            universityComboBox.TabIndex = 13;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(411, 23);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(352, 41);
            titleLabel.TabIndex = 14;
            titleLabel.Text = "Course Data Warehouse";
            // 
            // listOfCoursesLabel
            // 
            listOfCoursesLabel.AutoSize = true;
            listOfCoursesLabel.Location = new Point(43, 365);
            listOfCoursesLabel.Name = "listOfCoursesLabel";
            listOfCoursesLabel.Size = new Size(107, 20);
            listOfCoursesLabel.TabIndex = 16;
            listOfCoursesLabel.Text = "List of Courses:";
            // 
            // numberOfCoursesTextBox
            // 
            numberOfCoursesTextBox.Location = new Point(189, 320);
            numberOfCoursesTextBox.Name = "numberOfCoursesTextBox";
            numberOfCoursesTextBox.ReadOnly = true;
            numberOfCoursesTextBox.Size = new Size(125, 27);
            numberOfCoursesTextBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 323);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 18;
            label1.Text = "Number of Courses:";
            // 
            // yearCheckBox
            // 
            yearCheckBox.AutoSize = true;
            yearCheckBox.Location = new Point(9, 27);
            yearCheckBox.Name = "yearCheckBox";
            yearCheckBox.Size = new Size(62, 24);
            yearCheckBox.TabIndex = 19;
            yearCheckBox.Text = "Year:";
            yearCheckBox.UseVisualStyleBackColor = true;
            // 
            // semesterCheckBox
            // 
            semesterCheckBox.AutoSize = true;
            semesterCheckBox.Location = new Point(9, 73);
            semesterCheckBox.Name = "semesterCheckBox";
            semesterCheckBox.Size = new Size(95, 24);
            semesterCheckBox.TabIndex = 20;
            semesterCheckBox.Text = "Semester:";
            semesterCheckBox.UseVisualStyleBackColor = true;
            // 
            // majorCheckBox
            // 
            majorCheckBox.AutoSize = true;
            majorCheckBox.Location = new Point(10, 28);
            majorCheckBox.Name = "majorCheckBox";
            majorCheckBox.Size = new Size(73, 24);
            majorCheckBox.TabIndex = 21;
            majorCheckBox.Text = "Major:";
            majorCheckBox.UseVisualStyleBackColor = true;
            // 
            // genderCheckBox
            // 
            genderCheckBox.AutoSize = true;
            genderCheckBox.Location = new Point(10, 75);
            genderCheckBox.Name = "genderCheckBox";
            genderCheckBox.Size = new Size(82, 24);
            genderCheckBox.TabIndex = 22;
            genderCheckBox.Text = "Gender:";
            genderCheckBox.UseVisualStyleBackColor = true;
            // 
            // departmentCheckBox
            // 
            departmentCheckBox.AutoSize = true;
            departmentCheckBox.Location = new Point(10, 28);
            departmentCheckBox.Name = "departmentCheckBox";
            departmentCheckBox.Size = new Size(114, 24);
            departmentCheckBox.TabIndex = 23;
            departmentCheckBox.Text = "Department:";
            departmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // facultyCheckBox
            // 
            facultyCheckBox.AutoSize = true;
            facultyCheckBox.Location = new Point(10, 75);
            facultyCheckBox.Name = "facultyCheckBox";
            facultyCheckBox.Size = new Size(79, 24);
            facultyCheckBox.TabIndex = 24;
            facultyCheckBox.Text = "Faculty:";
            facultyCheckBox.UseVisualStyleBackColor = true;
            // 
            // universityCheckBox
            // 
            universityCheckBox.AutoSize = true;
            universityCheckBox.Location = new Point(9, 35);
            universityCheckBox.Name = "universityCheckBox";
            universityCheckBox.Size = new Size(98, 24);
            universityCheckBox.TabIndex = 25;
            universityCheckBox.Text = "University:";
            universityCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(1002, 323);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(152, 60);
            searchBtn.TabIndex = 26;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // instructorGroupBox
            // 
            instructorGroupBox.Controls.Add(departmentComboBox);
            instructorGroupBox.Controls.Add(facultyComboBox);
            instructorGroupBox.Controls.Add(departmentCheckBox);
            instructorGroupBox.Controls.Add(facultyCheckBox);
            instructorGroupBox.Location = new Point(597, 117);
            instructorGroupBox.Name = "instructorGroupBox";
            instructorGroupBox.Size = new Size(287, 115);
            instructorGroupBox.TabIndex = 27;
            instructorGroupBox.TabStop = false;
            instructorGroupBox.Text = "Instructor";
            // 
            // studentGroupBox
            // 
            studentGroupBox.Controls.Add(majorComboBox);
            studentGroupBox.Controls.Add(genderComboBox);
            studentGroupBox.Controls.Add(majorCheckBox);
            studentGroupBox.Controls.Add(genderCheckBox);
            studentGroupBox.Location = new Point(303, 117);
            studentGroupBox.Name = "studentGroupBox";
            studentGroupBox.Size = new Size(287, 115);
            studentGroupBox.TabIndex = 28;
            studentGroupBox.TabStop = false;
            studentGroupBox.Text = "Student";
            // 
            // institutionGroupBox
            // 
            institutionGroupBox.Controls.Add(universityComboBox);
            institutionGroupBox.Controls.Add(universityCheckBox);
            institutionGroupBox.Location = new Point(889, 117);
            institutionGroupBox.Name = "institutionGroupBox";
            institutionGroupBox.Size = new Size(287, 115);
            institutionGroupBox.TabIndex = 29;
            institutionGroupBox.TabStop = false;
            institutionGroupBox.Text = "Institution";
            // 
            // dateGroupBox
            // 
            dateGroupBox.Controls.Add(yearCheckBox);
            dateGroupBox.Controls.Add(yearComboBox);
            dateGroupBox.Controls.Add(semesterComboBox);
            dateGroupBox.Controls.Add(semesterCheckBox);
            dateGroupBox.Location = new Point(10, 117);
            dateGroupBox.Name = "dateGroupBox";
            dateGroupBox.Size = new Size(287, 115);
            dateGroupBox.TabIndex = 30;
            dateGroupBox.TabStop = false;
            dateGroupBox.Text = "Date";
            // 
            // coursesDataView
            // 
            coursesDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursesDataView.Location = new Point(19, 413);
            coursesDataView.Margin = new Padding(3, 4, 3, 4);
            coursesDataView.Name = "coursesDataView";
            coursesDataView.RowHeadersWidth = 51;
            coursesDataView.RowTemplate.Height = 25;
            coursesDataView.Size = new Size(1135, 411);
            coursesDataView.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1182, 853);
            Controls.Add(coursesDataView);
            Controls.Add(dateGroupBox);
            Controls.Add(institutionGroupBox);
            Controls.Add(studentGroupBox);
            Controls.Add(instructorGroupBox);
            Controls.Add(searchBtn);
            Controls.Add(label1);
            Controls.Add(numberOfCoursesTextBox);
            Controls.Add(listOfCoursesLabel);
            Controls.Add(titleLabel);
            Name = "Form1";
            Text = "CourseDataWarehouse";
            instructorGroupBox.ResumeLayout(false);
            instructorGroupBox.PerformLayout();
            studentGroupBox.ResumeLayout(false);
            studentGroupBox.PerformLayout();
            institutionGroupBox.ResumeLayout(false);
            institutionGroupBox.PerformLayout();
            dateGroupBox.ResumeLayout(false);
            dateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coursesDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox yearComboBox;
        private ComboBox semesterComboBox;
        private ComboBox genderComboBox;
        private ComboBox majorComboBox;
        private ComboBox departmentComboBox;
        private ComboBox facultyComboBox;
        private ComboBox universityComboBox;
        private Label titleLabel;
        private Label listOfCoursesLabel;
        private TextBox numberOfCoursesTextBox;
        private Label label1;
        private CheckBox yearCheckBox;
        private CheckBox semesterCheckBox;
        private CheckBox majorCheckBox;
        private CheckBox genderCheckBox;
        private CheckBox departmentCheckBox;
        private CheckBox facultyCheckBox;
        private CheckBox universityCheckBox;
        private Button searchBtn;
        private GroupBox instructorGroupBox;
        private GroupBox studentGroupBox;
        private GroupBox institutionGroupBox;
        private GroupBox dateGroupBox;
        private DataGridView coursesDataView;
    }
}