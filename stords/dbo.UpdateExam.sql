-- =============================================
-- Author:		<Men3m>
-- Create date: <27/2/2024>
-- =============================================

use OnlineExaminationSystemDB

create proc UpdateExam
    @Ex_Id int,
    @Title nvarchar(50),
    @Duration int,
    @TotalGrade int
as
begin
    update exams
    set Title = @Title, Duration = @Duration, TotalGrade = @TotalGrade
    where Ex_Id = @Ex_Id;
end;

exec UpdateExam 1, 'CPP', 5, 100

--select * from exams