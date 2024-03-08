USE [CMPT391_G7_Proj1_Part2]
GO

ALTER PROCEDURE [dbo].[sp_GetCourses]
(
	@Year INT = NULL,
	@Semester NVARCHAR(100) = NULL,
	@Major NVARCHAR(100) = NULL,
	@Gender NVARCHAR(100) = NULL,
	@Department NVARCHAR(100) = NULL,
	@Faculty NVARCHAR(100) = NULL,
	@University NVARCHAR(MAX) = NULL
)
AS
BEGIN
	/*--- @Statement is the query string, @ParamDefs will be passed to sp_executesql ---*/
	DECLARE @Statement NVARCHAR(MAX), @ParamDefs NVARCHAR(MAX)

	/*--- Parameters for sp_executesql ---*/
	SET @ParamDefs = '@Year INT,
					  @Semester NVARCHAR(100),
					  @Major NVARCHAR(100),
					  @Gender NVARCHAR(100),
					  @Department NVARCHAR(100),
					  @Faculty NVARCHAR(100),
					  @University NVARCHAR(MAX)'

	/*--- Initial query statement for all queries ---*/
	SET @Statement = 'SELECT DISTINCT C.title, D.year, D.semester, E.university_id'

	/*--- Deterime which columns to return based on passed arguments ---*/
	IF @Major IS NOT NULL AND @Major <> ''
	SET @Statement = @Statement + ', S.major'

	IF @Gender IS NOT NULL AND @Gender <> ''
	SET @Statement = @Statement + ', S.gender'

	IF @Department IS NOT NULL AND @Department <> ''
	SET @Statement = @Statement + ', I.department'

	IF @Faculty IS NOT NULL AND @Faculty <> ''
	SET @Statement = @Statement + ', I.faculty'

	IF @University IS NOT NULL AND @University <> ''
	SET @Statement = @Statement + ', U.university_name'

	/*--- Initial inner join statement for all queries ---*/
	SET @Statement = @Statement + ' FROM Enrollment as E 
								   INNER JOIN Course as C ON E.course_id = C.course_id 
								   INNER JOIN Date as D ON E.date_id = D.date_id'

	/*--- Inner join additional tables based on passed arguments ---*/
	IF @Major IS NOT NULL OR @Gender IS NOT NULL
	SET @Statement = @Statement + ' INNER JOIN Student as S on E.student_id = S.student_id'

	IF @Department IS NOT NULL OR @Faculty IS NOT NULL
	SET @Statement = @Statement + ' INNER JOIN Instructor as I on E.instructor_id = I.instructor_id'

	IF @University IS NOT NULL
	SET @Statement = @Statement + ' INNER JOIN University as U on E.university_id = U.university_id'

	/*--- Initial WHERE clause for all queries ---*/
	SET @Statement = @Statement + ' WHERE -1=-1'

	/*--- Additional filters based on passed arguments ---*/
	IF @Year IS NOT NULL AND @Year <> 0
	SET @Statement = @Statement + ' AND D.year = ' + CAST(@Year AS NVARCHAR(100))

	IF @Semester IS NOT NULL AND @Semester <> ''
	SET @Statement = @Statement + ' AND D.semester like ' + '''' + @Semester + ''''

	IF @Major IS NOT NULL AND @Major <> ''
	SET @Statement = @Statement + ' AND S.major like' + '''' + @Major + ''''

	IF @Gender IS NOT NULL AND @Gender <> ''
	SET @Statement = @Statement + ' AND S.gender like' + '''' + @Gender + ''''

	IF @Department IS NOT NULL AND @Department <> ''
	SET @Statement = @Statement + ' AND I.department like ' + '''' + @Department + ''''

	IF @Faculty IS NOT NULL AND @Faculty <> ''
	SET @Statement = @Statement + ' AND I.faculty like ' + '''' + @Faculty + ''''

	IF @University IS NOT NULL AND @University <> ''
	SET @Statement = @Statement + ' AND U.university_name like ' + '''' + @University + ''''

	/*--- Order results by year, and then alphabetically ---*/
	SET @Statement = @Statement + ' ORDER BY D.year, C.title ASC'

	/*--- Call sp_executesql based on @Statement string ---*/
	EXEC sp_executesql @Statement, @ParamDefs, @Year=@Year, @Semester=@Semester, @Major=@Major, @Gender=@Gender, @Department=@Department, @Faculty=@Faculty, @University=@University
END
GO
