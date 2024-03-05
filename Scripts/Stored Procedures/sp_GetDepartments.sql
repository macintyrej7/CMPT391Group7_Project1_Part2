USE [CMPT391_G7_Proj1_Part2]
GO

CREATE PROCEDURE [dbo].[sp_GetDepartments]
AS
BEGIN
	SELECT DISTINCT I.department
	FROM Instructor as I
	ORDER BY I.department
END
GO