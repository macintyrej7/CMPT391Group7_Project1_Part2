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
            coursesListView = new ListView();
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
            SuspendLayout();
            // 
            // yearComboBox
            // 
            yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(116, 88);
            yearComboBox.Margin = new Padding(3, 2, 3, 2);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(133, 23);
            yearComboBox.TabIndex = 7;
            // 
            // semesterComboBox
            // 
            semesterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            semesterComboBox.FormattingEnabled = true;
            semesterComboBox.Location = new Point(116, 123);
            semesterComboBox.Margin = new Padding(3, 2, 3, 2);
            semesterComboBox.Name = "semesterComboBox";
            semesterComboBox.Size = new Size(133, 23);
            semesterComboBox.TabIndex = 8;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(360, 124);
            genderComboBox.Margin = new Padding(3, 2, 3, 2);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(133, 23);
            genderComboBox.TabIndex = 9;
            // 
            // majorComboBox
            // 
            majorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            majorComboBox.FormattingEnabled = true;
            majorComboBox.Location = new Point(360, 88);
            majorComboBox.Margin = new Padding(3, 2, 3, 2);
            majorComboBox.Name = "majorComboBox";
            majorComboBox.Size = new Size(133, 23);
            majorComboBox.TabIndex = 10;
            // 
            // departmentComboBox
            // 
            departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(634, 88);
            departmentComboBox.Margin = new Padding(3, 2, 3, 2);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(133, 23);
            departmentComboBox.TabIndex = 11;
            // 
            // facultyComboBox
            // 
            facultyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            facultyComboBox.FormattingEnabled = true;
            facultyComboBox.Location = new Point(634, 124);
            facultyComboBox.Margin = new Padding(3, 2, 3, 2);
            facultyComboBox.Name = "facultyComboBox";
            facultyComboBox.Size = new Size(133, 23);
            facultyComboBox.TabIndex = 12;
            // 
            // universityComboBox
            // 
            universityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            universityComboBox.FormattingEnabled = true;
            universityComboBox.Location = new Point(881, 88);
            universityComboBox.Margin = new Padding(3, 2, 3, 2);
            universityComboBox.Name = "universityComboBox";
            universityComboBox.Size = new Size(133, 23);
            universityComboBox.TabIndex = 13;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(360, 17);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(287, 32);
            titleLabel.TabIndex = 14;
            titleLabel.Text = "Course Data Warehouse";
            // 
            // coursesListView
            // 
            coursesListView.Location = new Point(29, 291);
            coursesListView.Margin = new Padding(3, 2, 3, 2);
            coursesListView.Name = "coursesListView";
            coursesListView.Size = new Size(985, 332);
            coursesListView.TabIndex = 15;
            coursesListView.UseCompatibleStateImageBehavior = false;
            // 
            // listOfCoursesLabel
            // 
            listOfCoursesLabel.AutoSize = true;
            listOfCoursesLabel.Location = new Point(38, 274);
            listOfCoursesLabel.Name = "listOfCoursesLabel";
            listOfCoursesLabel.Size = new Size(87, 15);
            listOfCoursesLabel.TabIndex = 16;
            listOfCoursesLabel.Text = "List of Courses:";
            // 
            // numberOfCoursesTextBox
            // 
            numberOfCoursesTextBox.Location = new Point(165, 240);
            numberOfCoursesTextBox.Margin = new Padding(3, 2, 3, 2);
            numberOfCoursesTextBox.Name = "numberOfCoursesTextBox";
            numberOfCoursesTextBox.Size = new Size(110, 23);
            numberOfCoursesTextBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 242);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 18;
            label1.Text = "Number of Courses:";
            // 
            // yearCheckBox
            // 
            yearCheckBox.AutoSize = true;
            yearCheckBox.Location = new Point(29, 88);
            yearCheckBox.Margin = new Padding(3, 2, 3, 2);
            yearCheckBox.Name = "yearCheckBox";
            yearCheckBox.Size = new Size(51, 19);
            yearCheckBox.TabIndex = 19;
            yearCheckBox.Text = "Year:";
            yearCheckBox.UseVisualStyleBackColor = true;
            // 
            // semesterCheckBox
            // 
            semesterCheckBox.AutoSize = true;
            semesterCheckBox.Location = new Point(29, 123);
            semesterCheckBox.Margin = new Padding(3, 2, 3, 2);
            semesterCheckBox.Name = "semesterCheckBox";
            semesterCheckBox.Size = new Size(77, 19);
            semesterCheckBox.TabIndex = 20;
            semesterCheckBox.Text = "Semester:";
            semesterCheckBox.UseVisualStyleBackColor = true;
            // 
            // majorCheckBox
            // 
            majorCheckBox.AutoSize = true;
            majorCheckBox.Location = new Point(284, 89);
            majorCheckBox.Margin = new Padding(3, 2, 3, 2);
            majorCheckBox.Name = "majorCheckBox";
            majorCheckBox.Size = new Size(60, 19);
            majorCheckBox.TabIndex = 21;
            majorCheckBox.Text = "Major:";
            majorCheckBox.UseVisualStyleBackColor = true;
            // 
            // genderCheckBox
            // 
            genderCheckBox.AutoSize = true;
            genderCheckBox.Location = new Point(284, 124);
            genderCheckBox.Margin = new Padding(3, 2, 3, 2);
            genderCheckBox.Name = "genderCheckBox";
            genderCheckBox.Size = new Size(67, 19);
            genderCheckBox.TabIndex = 22;
            genderCheckBox.Text = "Gender:";
            genderCheckBox.UseVisualStyleBackColor = true;
            // 
            // departmentCheckBox
            // 
            departmentCheckBox.AutoSize = true;
            departmentCheckBox.Location = new Point(528, 89);
            departmentCheckBox.Margin = new Padding(3, 2, 3, 2);
            departmentCheckBox.Name = "departmentCheckBox";
            departmentCheckBox.Size = new Size(92, 19);
            departmentCheckBox.TabIndex = 23;
            departmentCheckBox.Text = "Department:";
            departmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // facultyCheckBox
            // 
            facultyCheckBox.AutoSize = true;
            facultyCheckBox.Location = new Point(528, 124);
            facultyCheckBox.Margin = new Padding(3, 2, 3, 2);
            facultyCheckBox.Name = "facultyCheckBox";
            facultyCheckBox.Size = new Size(67, 19);
            facultyCheckBox.TabIndex = 24;
            facultyCheckBox.Text = "Faculty:";
            facultyCheckBox.UseVisualStyleBackColor = true;
            // 
            // universityCheckBox
            // 
            universityCheckBox.AutoSize = true;
            universityCheckBox.Location = new Point(790, 88);
            universityCheckBox.Margin = new Padding(3, 2, 3, 2);
            universityCheckBox.Name = "universityCheckBox";
            universityCheckBox.Size = new Size(81, 19);
            universityCheckBox.TabIndex = 25;
            universityCheckBox.Text = "University:";
            universityCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(29, 164);
            searchBtn.Margin = new Padding(3, 2, 3, 2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(82, 22);
            searchBtn.TabIndex = 26;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1034, 640);
            Controls.Add(searchBtn);
            Controls.Add(universityCheckBox);
            Controls.Add(facultyCheckBox);
            Controls.Add(departmentCheckBox);
            Controls.Add(genderCheckBox);
            Controls.Add(majorCheckBox);
            Controls.Add(semesterCheckBox);
            Controls.Add(yearCheckBox);
            Controls.Add(label1);
            Controls.Add(numberOfCoursesTextBox);
            Controls.Add(listOfCoursesLabel);
            Controls.Add(coursesListView);
            Controls.Add(titleLabel);
            Controls.Add(universityComboBox);
            Controls.Add(facultyComboBox);
            Controls.Add(departmentComboBox);
            Controls.Add(majorComboBox);
            Controls.Add(genderComboBox);
            Controls.Add(semesterComboBox);
            Controls.Add(yearComboBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "CourseDataWarehouse";
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
        private ListView coursesListView;
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
    }
}