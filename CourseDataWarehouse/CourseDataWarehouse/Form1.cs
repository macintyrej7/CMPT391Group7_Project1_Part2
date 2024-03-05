using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

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
            PopulateYearComboBox();
            PopulateSemesterComboBox();
            PopulateMajorComboBox();
            PopulateGenderComboBox();
            PopulateDepartmentComboBox();
            PopulateFacultyComboBox();
            PopulateUniversityComboBox();
        }
    }
}