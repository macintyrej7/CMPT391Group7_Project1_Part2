using Microsoft.VisualBasic.Devices;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Xml;
using static CourseDataWarehouse.Form1;

namespace CourseDataWarehouse
{
    public partial class Form1 : Form
    {

        private SqlCommand myCommand;
        //string connectionString = "Server=localhost;Database=CMPT391_G7_Proj1_Part2;Trusted_Connection=True;";
        string connectionString = "Server=JASON-INTEL;Database=CMPT391_G7_Proj1_Part2;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = sqlConnection;
                //MessageBox.Show( "Database Connected");

                // Populate search tab at app launch
                PopulateComboBoxes();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void PopulateYearComboBox()
        {
            // helper function for populating year combo box based on data from data warehouse
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                try
                {
                    yearComboBox.Items.Clear();

                    SqlCommand command = new SqlCommand("sp_GetYears", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int year = int.Parse(reader["year"].ToString());

                        yearComboBox.Items.Add(year);
                    }

                    reader.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Failure adding items to Year combo box.");
                }

                sqlConnection.Close();
            }
        }

        private void PopulateSemesterComboBox()
        {
            // helper function for populating semester combo box based on data from data warehouse
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                try
                {
                    semesterComboBox.Items.Clear();

                    SqlCommand command = new SqlCommand("sp_GetSemesters", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        String semester = reader["semester"].ToString();

                        semesterComboBox.Items.Add(semester);
                    }

                    reader.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Failure adding items to Semester combo box.");
                }

                sqlConnection.Close();
            }
        }

        private void PopulateMajorComboBox()
        {
            // helper function for populating major combo box based on data from data warehouse
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                try
                {
                    majorComboBox.Items.Clear();

                    SqlCommand command = new SqlCommand("sp_GetMajors", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        String major = reader["major"].ToString();

                        majorComboBox.Items.Add(major);
                    }

                    reader.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Failure adding items to Major combo box.");
                }

                sqlConnection.Close();
            }
        }

        private void PopulateGenderComboBox()
        {
            // helper function for populating gender combo box based on data from data warehouse
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                try
                {
                    genderComboBox.Items.Clear();

                    SqlCommand command = new SqlCommand("sp_GetGenders", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        String gender = reader["gender"].ToString();

                        genderComboBox.Items.Add(gender);
                    }

                    reader.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Failure adding items to Gender combo box.");
                }

                sqlConnection.Close();
            }
        }

        private void PopulateDepartmentComboBox()
        {
            // helper function for populating department combo box based on data from data warehouse
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                try
                {
                    departmentComboBox.Items.Clear();

                    SqlCommand command = new SqlCommand("sp_GetDepartments", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        String department = reader["department"].ToString();

                        departmentComboBox.Items.Add(department);
                    }

                    reader.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Failure adding items to Department combo box.");
                }

                sqlConnection.Close();
            }
        }

        private void PopulateFacultyComboBox()
        {
            // helper function for populating faculty combo box based on data from data warehouse
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                try
                {
                    facultyComboBox.Items.Clear();

                    SqlCommand command = new SqlCommand("sp_GetFaculties", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        String faculty = reader["faculty"].ToString();

                        facultyComboBox.Items.Add(faculty);
                    }

                    reader.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Failure adding items to Faculty combo box.");
                }

                sqlConnection.Close();
            }
        }

        private void PopulateUniversityComboBox()
        {
            // helper function for populating university combo box based on data from data warehouse
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                try
                {
                    universityComboBox.Items.Clear();

                    SqlCommand command = new SqlCommand("sp_GetUniversities", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        String university = reader["university_name"].ToString();

                        universityComboBox.Items.Add(university);
                    }

                    reader.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Failure adding items to University combo box.");
                }

                sqlConnection.Close();
            }
        }

        private void PopulateComboBoxes()
        {
            // helper function for initializing the combo boxes
            PopulateYearComboBox();
            PopulateSemesterComboBox();
            PopulateMajorComboBox();
            PopulateGenderComboBox();
            PopulateDepartmentComboBox();
            PopulateFacultyComboBox();
            PopulateUniversityComboBox();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int? selectedYear = (int?)yearComboBox.SelectedItem;
            string selectedSemester = semesterComboBox.Text;
            string selectedMajor = majorComboBox.Text;
            string selectedGender = genderComboBox.Text;
            string selectedDepartment = departmentComboBox.Text;
            string selectedFaculty = facultyComboBox.Text;
            string selectedUniversity = universityComboBox.Text;

            if (!IsFilterOptionSelected())
            {
                MessageBox.Show("Please select at least one filter option.", "Warning! No Filters Selected.");
                return;
            }
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("sp_GetCourses", sqlConnection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Year", yearCheckBox.Checked ? selectedYear ?? (object)DBNull.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@Semester", semesterCheckBox.Checked ? selectedSemester ?? (object)DBNull.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@Major", majorCheckBox.Checked ? selectedMajor ?? (object)DBNull.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@Gender", genderCheckBox.Checked ? selectedGender ?? (object)DBNull.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@Department", departmentCheckBox.Checked ? selectedDepartment ?? (object)DBNull.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@Faculty", facultyCheckBox.Checked ? selectedFaculty ?? (object)DBNull.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@University", universityCheckBox.Checked ? selectedUniversity ?? (object)DBNull.Value : DBNull.Value);

                        sqlConnection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dataTable = new DataTable();

                        // add columns based on checked boxes
                        dataTable.Columns.Add("Course Title");
                        dataTable.Columns.Add("Year");
                        dataTable.Columns.Add("Semester");
                        dataTable.Columns.Add("University_ID");
                        if (majorCheckBox.Checked == true)
                        {
                            dataTable.Columns.Add("Student Major");
                        }
                        if (genderCheckBox.Checked == true)
                        {
                            dataTable.Columns.Add("Student Gender");
                        }
                        if (departmentCheckBox.Checked == true)
                        {
                            dataTable.Columns.Add("Instructor Dept.");
                        }
                        if (facultyCheckBox.Checked == true)
                        {
                            dataTable.Columns.Add("Instructor Faculty");
                        }
                        if (universityCheckBox.Checked == true)
                        {
                            dataTable.Columns.Add("University");
                        }

                        while (reader.Read())
                        {
                            DataRow row = dataTable.NewRow();

                            // add data to rows based on checked boxes / dynamic columns
                            row["Course Title"] = reader["title"];
                            row["Year"] = reader["year"];
                            row["Semester"] = reader["semester"];
                            row["University_ID"] = reader["university_id"];

                            if (majorCheckBox.Checked == true)
                            {
                                row["student Major"] = reader["major"];
                            }
                            if (genderCheckBox.Checked == true)
                            {
                                row["Student Gender"] = reader["gender"];
                            }
                            if (departmentCheckBox.Checked == true)
                            {
                                row["Instructor Dept."] = reader["department"];
                            }
                            if (facultyCheckBox.Checked == true)
                            {
                                row["Instructor Faculty"] = reader["faculty"];
                            }
                            if (universityCheckBox.Checked == true)
                            {
                                row["University"] = reader["university_name"];
                            }

                            dataTable.Rows.Add(row);
                        }

                        coursesDataView.DataSource = dataTable;
                        numberOfCoursesTextBox.Text = dataTable.Rows.Count.ToString();

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error with results: " + ex.Message);
                    }
                }
            }
        }

        private bool IsFilterOptionSelected()
        {
            bool filterByYear = yearCheckBox.Checked;
            bool filterBySemester = semesterCheckBox.Checked;
            bool filterByMajor = majorCheckBox.Checked;
            bool filterByGender = genderCheckBox.Checked;
            bool filterByDepartment = departmentCheckBox.Checked;
            bool filterByFaculty = facultyCheckBox.Checked;
            bool filterByUniversity = universityCheckBox.Checked;

            return filterByYear || filterBySemester || filterByMajor || filterByGender || filterByDepartment || filterByFaculty || filterByUniversity;
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C://Desktop";
            openFileDialog.Title = "Select file to be upload.";
            openFileDialog.Filter = "Select Valid Document (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            try
            {
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog.FileName);

                        XmlDocument xmlDoc = new XmlDocument();
                            
                        xmlDoc.Load(path);

                        ProccessFile(xmlDoc);

                        MessageBox.Show("Upload completed successfully!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload Failed! Error: " + ex.Message);
            }
        }

        private void ProccessFile(XmlDocument xmlDoc)
        {

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            List<Student> studentList = new List<Student>();
            List<Enrollment> enrollmentList = new List<Enrollment>();

            foreach (XmlNode rootNode in xmlDoc.DocumentElement.ChildNodes)
            {
                Course newCourse = null;
                Student newStudent = null;
                Date newDate = null;
                Instructor newInstructor = null;
                University newUniversity = null;

                Boolean validCourse = false;
                Boolean validStudent = false;
                Boolean validDate = false;
                Boolean validInstructor = false;
                Boolean validUniversity = false;

                foreach (XmlNode node in rootNode)
                {

                    if (node.Name == "Course")
                    {
                        string titleString = "";
                        string departmentString = "";
                        string facultyString = "";
                        int universityID = -1;

                        foreach (XmlNode leafNode in node)
                        {

                            if (leafNode.Name == "title")
                            {
                                titleString = textInfo.ToTitleCase(leafNode.InnerText.ToString());
                            }

                            if (leafNode.Name == "department")
                            {
                                departmentString = textInfo.ToTitleCase(leafNode.InnerText.ToString());
                            }

                            if (leafNode.Name == "faculty")
                            {
                                facultyString = textInfo.ToTitleCase(leafNode.InnerText.ToString());
                            }

                            if ((leafNode.Name == "university_id") && (!leafNode.InnerText.Equals("")))
                            {
                                universityID = Convert.ToInt32(leafNode.InnerText);
                            }
                        }

                        if ((!titleString.Equals("")) && (!departmentString.Equals("")) && (!facultyString.Equals("")) && (universityID != -1))
                        {

                            newCourse = new Course(titleString, departmentString, facultyString, universityID);
                            validCourse = true;
                        }
                    }

                    if (node.Name == "Student")
                    {
                        string majorString = "";
                        string genderString = "";

                        foreach (XmlNode leafNode in node)
                        {

                            if (leafNode.Name == "major")
                            {
                                majorString = textInfo.ToTitleCase(leafNode.InnerText.ToString());
                            }

                            if (leafNode.Name == "gender")
                            {
                                genderString = textInfo.ToTitleCase(leafNode.InnerText.ToString());
                            }
                        }

                        if ((!majorString.Equals("")) && (!genderString.Equals("")))
                        {

                            newStudent = new Student(majorString, genderString);
                            validStudent = true;
                        }
                    }

                    if (node.Name == "Date")
                    {
                        int year = -1;
                        string semesterString = "";

                        foreach (XmlNode leafNode in node)
                        {
                            if ((leafNode.Name == "year") && (!leafNode.InnerText.Equals("")))
                            {
                                year = Convert.ToInt32(leafNode.InnerText);
                            }

                            if (leafNode.Name == "semester")
                            {
                                semesterString = textInfo.ToTitleCase(leafNode.InnerText.ToString());
                            }
                        }

                        if ((year != -1) && (!semesterString.Equals("")))
                        {

                            newDate = new Date(year, semesterString);
                            validDate = true;
                        }
                    }

                    if (node.Name == "Instructor")
                    {
                        string rankString = "";
                        string departmentString = "";
                        string facultyString = "";
                        int universityID = -1;

                        foreach (XmlNode leafNode in node)
                        {
                            if (leafNode.Name == "rank")
                            {
                                rankString = textInfo.ToTitleCase(leafNode.InnerText.ToString());
                            }

                            if (leafNode.Name == "department")
                            {
                                departmentString = textInfo.ToTitleCase(leafNode.InnerText.ToString());
                            }

                            if (leafNode.Name == "faculty")
                            {
                                facultyString = textInfo.ToTitleCase(leafNode.InnerText.ToString());
                            }

                            if ((leafNode.Name == "university_id") && (!leafNode.InnerText.Equals("")))
                            {
                                universityID = Convert.ToInt32(leafNode.InnerText);
                            }
                        }

                        if ((!rankString.Equals("")) && (!departmentString.Equals("")) && (!facultyString.Equals("")) && (universityID != -1))
                        {

                            newInstructor = new Instructor(rankString, departmentString, facultyString, universityID);
                            validInstructor = true;
                        }
                    }

                    if (node.Name == "University")
                    {
                        string universityString = "";

                        foreach (XmlNode leafNode in node)
                        {
                            if (leafNode.Name == "university_name")
                            {
                                universityString = textInfo.ToUpper(leafNode.InnerText.ToString());
                            }
                        }

                        if (!universityString.Equals(""))
                        {
                            newUniversity = new University(universityString);
                            validUniversity = true;
                        }
                    }
                }

                if ((validCourse == true) && (validStudent == true) && (validDate == true) && (validInstructor == true) && (validUniversity == true))
                {
                    Enrollment currEnrollment = new Enrollment(newCourse, newStudent, newDate, newInstructor, newUniversity);

                    enrollmentList.Add(currEnrollment);

                    MessageBox.Show("Course: " + currEnrollment.getCourse().getTitle() + ", " + currEnrollment.getCourse().getFaculty() + ", " + currEnrollment.getCourse().getDepartment() + "\n"
                        + "Student: " + currEnrollment.getStudent().getGender() + ", " + currEnrollment.getStudent().getMajor() + "\n"
                        + "Date: " + currEnrollment.getDate().getYear() + ", " + currEnrollment.getDate().getSemester() + "\n"
                        + "Instructor: " + currEnrollment.getInstructor().getRank() + ", " +  currEnrollment.getInstructor().getDepartment() + ", " + currEnrollment.getInstructor().getFaculty() + "\n"
                        + "University: " + currEnrollment.getUniversity().getUniversityName());
                }
            }

            loadEnrollments(enrollmentList);
        }

        private void loadEnrollments(List<Enrollment> enrollmentList)
        {
            int enrollCount = -1;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("sp_GetEnrollmentCount", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    sqlConnection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        enrollCount = Convert.ToInt32(reader["EnrollmentCount"].ToString());
                    }
                    reader.Close();
                    sqlConnection.Close();
                }
                catch
                {
                    sqlConnection.Close();
                    MessageBox.Show("Error retreiving Enrollment Count.");
                }

            }

            foreach (Enrollment enroll in enrollmentList)
            {
                Course course = enroll.getCourse();
                Student student = enroll.getStudent();
                Date date = enroll.getDate();
                Instructor instructor = enroll.getInstructor();
                University university = enroll.getUniversity();

                int courseID = -1;
                int studentID = -1;
                int dateID = -1;
                int instructorID = -1;
                int universityID = -1;

                courseInsertCheck(course);

                courseID = getCourseID(course);

                studentInsertCheck(student);

                studentID = getStudentID(student);

                dateInsertCheck(date);

                dateID = getDateID(date);

                instructorInsertCheck(instructor);

                instructorID = getInstructorID(instructor);

                universityInsertCheck(university);

                universityID = getUniversityID(university);

                enrollCount = enrollmentInsertCheck(enrollCount, courseID, studentID, dateID, instructorID, universityID);
            }
        }

        public void courseInsertCheck(Course course)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    Int32 retInt = 0;

                    SqlCommand command = new SqlCommand("sp_checkCourse", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Title", course.getTitle());
                    command.Parameters.AddWithValue("@Department", course.getDepartment());
                    command.Parameters.AddWithValue("@Faculty", course.getFaculty());
                    command.Parameters.AddWithValue("@UniversityID", course.getUniversityID());
                    command.Parameters.Add("@Return", SqlDbType.Int);
                    command.Parameters["@Return"].Direction = ParameterDirection.Output;

                    sqlConnection.Open();

                    command.ExecuteNonQuery();

                    retInt = (Int32)command.Parameters["@Return"].Value;

                    int courseExists = (int)retInt;

                    sqlConnection.Close();

                    if (courseExists == 0)
                    {
                        command = new SqlCommand("sp_InsertCourse", sqlConnection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Title", course.getTitle());
                        command.Parameters.AddWithValue("@Department", course.getDepartment());
                        command.Parameters.AddWithValue("@Faculty", course.getFaculty());
                        command.Parameters.AddWithValue("@UniversityID", course.getUniversityID());

                        sqlConnection.Open();
                        command.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        public int getCourseID(Course course)
        {
            int courseID = -1;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("sp_GetCourseID", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Title", course.getTitle());
                    command.Parameters.AddWithValue("@Department", course.getDepartment());
                    command.Parameters.AddWithValue("@Faculty", course.getFaculty());
                    command.Parameters.AddWithValue("@UniversityID", course.getUniversityID());

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        courseID = Convert.ToInt32(reader["course_id"].ToString());
                    }

                    reader.Close();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Error:" + ex.Message);
                }
            }

            return courseID;
        }

        public void studentInsertCheck(Student student)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    Int32 retInt = 0;

                    SqlCommand command = new SqlCommand("sp_checkStudent", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Major", student.getMajor());
                    command.Parameters.AddWithValue("@Gender", student.getGender());
                    command.Parameters.Add("@Return", SqlDbType.Int);
                    command.Parameters["@Return"].Direction = ParameterDirection.Output;

                    sqlConnection.Open();

                    command.ExecuteNonQuery();

                    retInt = (Int32)command.Parameters["@Return"].Value;

                    int studentExists = (int)retInt;

                    sqlConnection.Close();

                    if (studentExists == 0)
                    {
                        command = new SqlCommand("sp_InsertStudent", sqlConnection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Major", student.getMajor());
                        command.Parameters.AddWithValue("@Gender", student.getGender());

                        sqlConnection.Open();
                        command.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        public int getStudentID(Student student)
        {
            int studentID = -1;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("sp_GetStudentID", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Major", student.getMajor());
                    command.Parameters.AddWithValue("@Gender", student.getGender());

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        studentID = Convert.ToInt32(reader["student_id"].ToString());
                    }

                    reader.Close();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Error:" + ex.Message);
                }
            }

            return studentID;
        }

        public void dateInsertCheck(Date date)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    Int32 retInt = 0;

                    SqlCommand command = new SqlCommand("sp_checkDate", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Year", date.getYear());
                    command.Parameters.AddWithValue("@Semester", date.getSemester());
                    command.Parameters.Add("@Return", SqlDbType.Int);
                    command.Parameters["@Return"].Direction = ParameterDirection.Output;

                    sqlConnection.Open();

                    command.ExecuteNonQuery();

                    retInt = (Int32)command.Parameters["@Return"].Value;

                    int dateExists = (int)retInt;

                    sqlConnection.Close();

                    if (dateExists == 0)
                    {
                        command = new SqlCommand("sp_InsertDate", sqlConnection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Year", date.getYear());
                        command.Parameters.AddWithValue("@Semester", date.getSemester());

                        sqlConnection.Open();
                        command.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        public int getDateID(Date date)
        {
            int dateID = -1;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("sp_GetDateID", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Year", date.getYear());
                    command.Parameters.AddWithValue("@Semester", date.getSemester());

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        dateID = Convert.ToInt32(reader["date_id"].ToString());
                    }

                    reader.Close();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Error:" + ex.Message);
                }
            }

            return dateID;
        }

        public void instructorInsertCheck(Instructor instructor)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    Int32 retInt = 0;

                    SqlCommand command = new SqlCommand("sp_checkInstructor", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Rank", instructor.getRank());
                    command.Parameters.AddWithValue("@Department", instructor.getDepartment());
                    command.Parameters.AddWithValue("@Faculty", instructor.getFaculty());
                    command.Parameters.AddWithValue("@UniversityID", instructor.getUniversityID());
                    command.Parameters.Add("@Return", SqlDbType.Int);
                    command.Parameters["@Return"].Direction = ParameterDirection.Output;

                    sqlConnection.Open();

                    command.ExecuteNonQuery();

                    retInt = (Int32)command.Parameters["@Return"].Value;

                    int instructorExists = (int)retInt;

                    sqlConnection.Close();

                    if (instructorExists == 0)
                    {
                        command = new SqlCommand("sp_InsertInstructor", sqlConnection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Rank", instructor.getRank());
                        command.Parameters.AddWithValue("@Department", instructor.getDepartment());
                        command.Parameters.AddWithValue("@Faculty", instructor.getFaculty());
                        command.Parameters.AddWithValue("@UniversityID", instructor.getUniversityID());

                        sqlConnection.Open();
                        command.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        public int getInstructorID(Instructor instructor)
        {
            int instructorID = -1;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("sp_GetInstructorID", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Rank", instructor.getRank());
                    command.Parameters.AddWithValue("@Department", instructor.getDepartment());
                    command.Parameters.AddWithValue("@Faculty", instructor.getFaculty());
                    command.Parameters.AddWithValue("@UniversityID", instructor.getUniversityID());

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        instructorID = Convert.ToInt32(reader["instructor_id"].ToString());
                    }

                    reader.Close();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Error:" + ex.Message);
                }
            }

            return instructorID;
        }

        public void universityInsertCheck(University university)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    Int32 retInt = 0;

                    SqlCommand command = new SqlCommand("sp_checkUniversity", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UniversityName", university.getUniversityName());
                    command.Parameters.Add("@Return", SqlDbType.Int);
                    command.Parameters["@Return"].Direction = ParameterDirection.Output;

                    sqlConnection.Open();

                    command.ExecuteNonQuery();

                    retInt = (Int32)command.Parameters["@Return"].Value;

                    int universityExists = (int)retInt;

                    sqlConnection.Close();

                    if (universityExists == 0)
                    {
                        command = new SqlCommand("sp_InsertUniversity", sqlConnection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UniversityName", university.getUniversityName());

                        sqlConnection.Open();
                        command.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        public int getUniversityID(University university)
        {
            int universityID = -1;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("sp_GetUniversityID", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UniversityName", university.getUniversityName());

                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        universityID = Convert.ToInt32(reader["university_id"].ToString());
                    }

                    reader.Close();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Error:" + ex.Message);
                }
            }

            return universityID;
        }

        public int enrollmentInsertCheck(int enrollmentCount, int courseID, int studentID, int dateID, int instructorID, int universityID)
        {
            if ((courseID != -1) && (studentID != -1) && (dateID != -1) && (instructorID != -1) && (universityID != -1))
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    try
                    {
                        Int32 retInt = 0;

                        SqlCommand command = new SqlCommand("sp_checkEnrollment", sqlConnection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CourseID", courseID);
                        command.Parameters.AddWithValue("@StudentID", studentID);
                        command.Parameters.AddWithValue("@DateID", dateID);
                        command.Parameters.AddWithValue("@InstructorID", instructorID);
                        command.Parameters.AddWithValue("@UniversityID", universityID);
                        command.Parameters.Add("@Return", SqlDbType.Int);
                        command.Parameters["@Return"].Direction = ParameterDirection.Output;

                        sqlConnection.Open();

                        command.ExecuteNonQuery();

                        retInt = (Int32)command.Parameters["@Return"].Value;

                        int enrollmentExists = (int)retInt;

                        sqlConnection.Close();

                        if (enrollmentExists == 0)
                        {
                            enrollmentCount += 1;
                            command = new SqlCommand("sp_InsertEnrollment", sqlConnection);
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@EnrollmentCount", enrollmentCount);
                            command.Parameters.AddWithValue("@CourseID", courseID);
                            command.Parameters.AddWithValue("@StudentID", studentID);
                            command.Parameters.AddWithValue("@DateID", dateID);
                            command.Parameters.AddWithValue("@InstructorID", instructorID);
                            command.Parameters.AddWithValue("@UniversityID", universityID);

                            sqlConnection.Open();
                            command.ExecuteNonQuery();
                            sqlConnection.Close();

                            MessageBox.Show("New Enrollment Inserted\n\nCourse ID: " + courseID.ToString() + "\nStudent ID: " + studentID.ToString()
                               + "\nInstructor ID: " + instructorID.ToString() + "\nUniversity ID: " + universityID.ToString() + "\nDate ID: " + dateID.ToString());
                        }

                        else
                        {
                            MessageBox.Show("Enrollment already exists.");
                        }
                    }
                    catch (Exception ex)
                    {
                        sqlConnection.Close();
                        MessageBox.Show("Error:" + ex.Message);
                    }
                }
            }

            return enrollmentCount;
        }
    }

    public class Course 
    {
        private string title;
        private string department;
        private string faculty;
        private int universityID;

        public Course(string title, string department, string faculty, int universityID)
        {
            this.title = title;
            this.department = department;
            this.faculty = faculty;
            this.universityID = universityID;
        }

        public string getTitle()
        {
            return title;
        }

        public string getDepartment()
        {
            return department;
        }

        public string getFaculty()
        {
            return faculty;
        }

        public int getUniversityID()
        {
            return universityID;
        }
    }

    public class Student
    {

        private string major;
        private string gender;

        public Student(string major, string gender)
        {
            this.major = major;
            this.gender = gender;
        }

        public string getMajor()
        {
            return major;
        }

        public string getGender()
        {
            return gender;
        }
    }

    public class Date
    {
        private int year;
        private string semester;

        public Date(int year, string semester)
        {
            this.year = year;
            this.semester = semester;
        }

        public int getYear()
        {
            return year;
        }

        public string getSemester()
        {
            return semester;
        }
    }

    public class Instructor
    {
        private string rank;
        private string department;
        private string faculty;
        private int universityID;

        public Instructor(string rank, string department, string faculty, int universityID)
        {
            this.rank = rank;
            this.department = department;
            this.faculty = faculty;
            this.universityID = universityID;
        }

        public string getRank()
        {
            return rank;
        }

        public string getDepartment()
        {
            return department;
        }

        public string getFaculty()
        {
            return faculty;
        }

        public int getUniversityID()
        {
            return universityID;
        }
    }

    public class University
    {
        private string universityName;

        public University(string universityName)
        {
            this.universityName = universityName;
        }

        public string getUniversityName()
        {
            return universityName;
        }
    }

    public class Enrollment
    {
        private Course course;
        private Student student;
        private Date date;
        private Instructor instructor;
        private University university;
        
        public Enrollment(Course course, Student student, Date date, Instructor instructor, University university)
        {
            this.course = course;
            this.student = student;
            this.date = date;
            this.instructor = instructor;
            this.university = university;
        }

        public Course getCourse() 
        { 
            return course;
        }

        public void setCourse(Course newCourse)
        {
            this.course = newCourse;
        }

        public Student getStudent() 
        { 
            return student;
        }

        public void setStudent(Student newStudent)
        {
            this.student = newStudent;
        }

        public Date getDate() 
        {
            return date;
        }

        public void setDate(Date newDate)
        {
            this.date = newDate;
        }

        public Instructor getInstructor() 
        {
            return instructor;
        }

        public void setInstructor(Instructor newInstructor)
        {
            this.instructor = newInstructor;
        }

        public University getUniversity()
        {
            return university;
        }

        public void setUniversity(University newUniversity)
        {
            this.university = newUniversity;
        }
    }
}