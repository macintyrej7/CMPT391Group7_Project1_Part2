USE [CMPT391_G7_Proj1_Part2]
GO

CREATE PROCEDURE [dbo].[sp_GetSemesters]
AS
BEGIN
	SELECT DISTINCT D.semester
	FROM Date as D
	ORDER BY D.semester
END
GO