# CMPT 391 - Gorup 7 - Project 1 Part 2

## Group Members: Carson, Fahad, Jason, Matt, Steve

### Dependencies
- System.Data.SqlClient package (install via "Tools" -> "NuGet Package Manager" -> "Manage NuGet Packages for Solution..."; detailed package installation instructions available here: https://learn.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio).

### ER Diagram 
[Link to ER Diagram PDF.](https://github.com/macintyrej7/CMPT391Group7_Project1_Part2/blob/254b5a0954830009b31a518c1dbabb5f03b228c7/Documentation/CMPT%20391%20Group%207%20-%20Project%201%20Part%202%20ER%20Diagram.pdf)

### Data Warehouse Description
The database that our main client program utilizes is a data warehouse for storing university courses. The data warehouse follows the star schema with a slight modification regarding the University table, resulting in a snowflake schema. There are six tables: Enrollment, Course, Date, University, Student, and Instructor. Enrollment is the central table, and takes the primary keys from the surrounding tables as foreign keys. The schema for the tables is as follows:

```
Enrollment(enrollment_id (PK), course_id (FK), instructor_id (FK), date_id (FK), student_id (FK), university_id (FK), count)
          --- Foreign Key course_id references Course(course_id)
          --- Foriegn Key date_id references Date(date_id)
          --- Foreign Key student_id references Student(student_id)
          --- Foreign Key instructor_id references Instructor(instructor_id)
          --- Foreign Key university_id references University(university_id)

Course(course_id (PK), title, department, faculty, univesity_id (FK))
          --- Foreign Key university_id references University(university_id)

Instructor(instructor_id (PK), rank, department, faculty, university_id (FK))
          --- Foreign Key university_id references University(university_id)

Date(date_id (PK), year, semester)

Student(student_id (PK), major, gender)

University(university_id (PK), university_name)
```

