USE [CMPT391_G7_Proj1_Part2]
GO

CREATE PROCEDURE [dbo].[sp_GetFaculties]
AS
BEGIN
	SELECT DISTINCT I.faculty
	FROM Instructor as I
	ORDER BY I.faculty
END
GO