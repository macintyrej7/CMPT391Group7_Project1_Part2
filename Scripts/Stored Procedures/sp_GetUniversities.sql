USE [CMPT391_G7_Proj1_Part2]
GO

CREATE PROCEDURE [dbo].[sp_GetUniversities]
AS
BEGIN
	SELECT DISTINCT U.university_name
	FROM University as U
	ORDER BY U.university_name
END
GO