using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace CourseDataWarehouse
{
    public partial class Form1 : Form
    {

        private SqlCommand myCommand;
        string connectionString = "Server=localhost;Database=CMPT391_G7_Proj1_Part2;Trusted_Connection=True;";
        //string connectionString = "Server=JASON-INTEL;Database=CMPT391_G7_Proj1_Part2;Trusted_Connection=True;";

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
                        //dataTable.Columns.Add("University_ID");
                        if (majorCheckBox.Checked == true)
                        {
                            dataTable.Columns.Add("Major");
                        }
                        if (genderCheckBox.Checked == true)
                        {
                            dataTable.Columns.Add("Gender");
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
                            //row["University_ID"] = reader["university_id"];

                            if (majorCheckBox.Checked == true)
                            {
                                row["Major"] = reader["major"];
                            }
                            if (genderCheckBox.Checked == true)
                            {
                                row["Gender"] = reader["gender"];
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

        private void ProccessFile (XmlDocument xmlDoc)
        {

        }
    }
}