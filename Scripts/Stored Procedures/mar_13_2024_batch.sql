USE [CMPT391_G7_Proj1_Part2]
GO

CREATE PROCEDURE [dbo].[sp_GetEnrollmentCount]
AS
BEGIN
	SELECT MAX(enrollment_id) as EnrollmentCount
	FROM Enrollment
END

/*--- Courses ---*/

CREATE PROCEDURE [dbo].[sp_checkCourse]
(
	@Title NVARCHAR(100),
	@Department NVARCHAR(100),
	@Faculty NVARCHAR(100),
	@UniversityID int,
	@Return int OUTPUT
)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM Course as C WHERE C.title=@Title and C.department=@Department and C.faculty=@Faculty and C.university_id=@UniversityID)
		BEGIN
			SET @Return = 1
		END
	ELSE
		BEGIN
			SET @Return = 0
		END
	RETURN @Return
END

CREATE PROCEDURE [dbo].[sp_InsertCourse]
(
	@Title NVARCHAR(100),
	@Department NVARCHAR(100),
	@Faculty NVARCHAR(100),
	@UniversityID int
)
AS
BEGIN
	INSERT INTO Course (title, department, faculty, university_id) VALUES (@Title, @Department, @Faculty, @UniversityID);
END

CREATE PROCEDURE [dbo].[sp_GetCourseID]
(
	@Title NVARCHAR(100),
	@Department NVARCHAR(100),
	@Faculty NVARCHAR(100),
	@UniversityID int
)
AS
BEGIN
	SELECT C.course_id FROM Course as C WHERE C.title=@Title and C.department=@Department and C.faculty=@Faculty and C.university_id=@UniversityID
END

/*--- Students ---*/

CREATE PROCEDURE [dbo].[sp_checkStudent]
(
	@Major NVARCHAR(100),
	@Gender NVARCHAR(100),
	@Return int OUTPUT
)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM Student as S WHERE S.major=@Major and S.gender=@Gender)
		BEGIN
			SET @Return = 1
		END
	ELSE
		BEGIN
			SET @Return = 0
		END
	RETURN @Return
END

CREATE PROCEDURE [dbo].[sp_InsertStudent]
(
	@Major NVARCHAR(100),
	@Gender NVARCHAR(100)
)
AS
BEGIN
	INSERT INTO Student (major, gender) VALUES (@Major, @Gender);
END

CREATE PROCEDURE [dbo].[sp_GetStudentID]
(
	@Major NVARCHAR(100),
	@Gender NVARCHAR(100)
)
AS
BEGIN
	SELECT S.student_id FROM Student as S WHERE S.major=@Major and S.gender=@Gender
END

/*--- Dates ---*/

CREATE PROCEDURE [dbo].[sp_checkDate]
(
	@Year int,
	@Semester NVARCHAR(100),
	@Return int OUTPUT
)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM Date as D WHERE D.year=@Year and D.semester=@Semester)
		BEGIN
			SET @Return = 1
		END
	ELSE
		BEGIN
			SET @Return = 0
		END
	RETURN @Return
END

CREATE PROCEDURE [dbo].[sp_InsertDate]
(
	@Year int,
	@Semester NVARCHAR(100)
)
AS
BEGIN
	INSERT INTO Date (year, semester) VALUES (@Year, @Semester);
END

CREATE PROCEDURE [dbo].[sp_GetDateID]
(
	@Year int,
	@Semester NVARCHAR(100)
)
AS
BEGIN
	SELECT D.date_id FROM Date as D WHERE D.year=@Year and D.semester=@Semester
END

/*--- Instructors ---*/

CREATE PROCEDURE [dbo].[sp_checkInstructor]
(
	@Rank NVARCHAR(100),
	@Department NVARCHAR(100),
	@Faculty NVARCHAR(100),
	@UniversityID int,
	@Return int OUTPUT
)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM Instructor as I WHERE I.rank=@Rank and I.department=@Department and I.faculty=@Faculty and I.university_id=@UniversityID)
		BEGIN
			SET @Return = 1
		END
	ELSE
		BEGIN
			SET @Return = 0
		END
	RETURN @Return
END

CREATE PROCEDURE [dbo].[sp_InsertInstructor]
(
	@Rank NVARCHAR(100),
	@Department NVARCHAR(100),
	@Faculty NVARCHAR(100),
	@UniversityID int
)
AS
BEGIN
	INSERT INTO Instructor (rank, department, faculty, university_id) VALUES (@Rank, @Department, @Faculty, @UniversityID);
END

CREATE PROCEDURE [dbo].[sp_GetInstructorID]
(
	@Rank NVARCHAR(100),
	@Department NVARCHAR(100),
	@Faculty NVARCHAR(100),
	@UniversityID int
)
AS
BEGIN
	SELECT I.instructor_id FROM Instructor as I WHERE I.rank=@Rank and I.department=@Department and I.faculty=@Faculty and I.university_id=@UniversityID
END

/*--- Universities ---*/

CREATE PROCEDURE [dbo].[sp_checkUniversity]
(
	@UniversityName NVARCHAR(100),
	@Return int OUTPUT
)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM University as U WHERE U.university_name=@UniversityName)
		BEGIN
			SET @Return = 1
		END
	ELSE
		BEGIN
			SET @Return = 0
		END
	RETURN @Return
END

CREATE PROCEDURE [dbo].[sp_InsertUniversity]
(
	@UniversityName NVARCHAR(100)
)
AS
BEGIN
	INSERT INTO University (university_name) VALUES (@UniversityName);
END

CREATE PROCEDURE [dbo].[sp_GetUniversityID]
(
	@UniversityName NVARCHAR(100)
)
AS
BEGIN
	SELECT U.university_id FROM University as U WHERE U.university_name=@UniversityName
END

DROP PROCEDURE [sp_checkEnrollment]

/*--- Enrollments ---*/
CREATE PROCEDURE [dbo].[sp_checkEnrollment]
(
	@CourseID int,
	@StudentID int,
	@DateID int,
	@InstructorID int,
	@UniversityID int,
	@Return int OUTPUT
)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM Enrollment as E WHERE E.course_id=@CourseID and E.student_id=@StudentID and E.date_id=@DateID and E.instructor_id=@InstructorID and E.university_id=@UniversityID)
		BEGIN
			SET @Return = 1
		END
	ELSE
		BEGIN
			SET @Return = 0
		END
	RETURN @Return
END

CREATE PROCEDURE [dbo].[sp_InsertEnrollment]
(
	@EnrollmentCount int,
	@CourseID int,
	@StudentID int,
	@DateID int,
	@InstructorID int,
	@UniversityID int
)
AS
BEGIN
	INSERT INTO Enrollment (enrollment_id, student_id, course_id, instructor_id, university_id, date_id, total_count) VALUES (@EnrollmentCount, @StudentID, @CourseID, @InstructorID, @UniversityID, @DateID, 1);
END