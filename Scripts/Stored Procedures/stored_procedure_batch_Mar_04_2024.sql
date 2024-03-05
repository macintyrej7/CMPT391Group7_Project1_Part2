CREATE PROCEDURE [dbo].[sp_GetYears]
AS
BEGIN
	SELECT DISTINCT D.year
	FROM Date as D
	ORDER BY D.year ASC
END

CREATE PROCEDURE [dbo].[sp_GetSemesters]
AS
BEGIN
	SELECT DISTINCT D.semester
	FROM Date as D
	ORDER BY D.semester
END

CREATE PROCEDURE [dbo].[sp_GetMajors]
AS
BEGIN
	SELECT DISTINCT S.major
	FROM Student as S
	ORDER BY S.major
END

CREATE PROCEDURE [dbo].[sp_GetGenders]
AS
BEGIN
	SELECT DISTINCT S.gender
	FROM Student as S
	ORDER BY S.gender
END

CREATE PROCEDURE [dbo].[sp_GetDepartments]
AS
BEGIN
	SELECT DISTINCT I.department
	FROM Instructor as I
	ORDER BY I.department
END

CREATE PROCEDURE [dbo].[sp_GetFaculties]
AS
BEGIN
	SELECT DISTINCT I.faculty
	FROM Instructor as I
	ORDER BY I.faculty
END

CREATE PROCEDURE [dbo].[sp_GetUniversities]
AS
BEGIN
	SELECT DISTINCT U.university_name
	FROM University as U
	ORDER BY U.university_name
END