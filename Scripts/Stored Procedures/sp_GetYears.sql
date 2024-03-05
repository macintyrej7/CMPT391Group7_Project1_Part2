USE [CMPT391_G7_Proj1_Part2]
GO

CREATE PROCEDURE [dbo].[sp_GetYears]
AS
BEGIN
	SELECT DISTINCT D.year
	FROM Date as D
	ORDER BY D.year ASC
END
GO