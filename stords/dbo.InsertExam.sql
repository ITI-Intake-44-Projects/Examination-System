USE [OnlineExaminationSystemDB]
GO
/****** Object:  StoredProcedure [dbo].[InsertExam]    Script Date: 2/28/2024 10:30:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter proc [dbo].[InsertExam]
	@Ex_ID int,
    @Title nvarchar(50),
    @Duration int,
    @TotalGrade int
as
begin
    insert into Exams (Ex_Id, Title, Duration, TotalGrade)
	values (@Ex_ID, @Title, @Duration, @TotalGrade)
end;
