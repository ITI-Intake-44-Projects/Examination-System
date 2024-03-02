-- =============================================
-- Author:		<Men3m>
-- Create date: <27/2/2024>
-- Stored Name: DeleteExam
-- =============================================

use OnlineExaminationSystemDB

create proc DeleteExam @Ex_Id int
as
begin
    delete from exams
    where Ex_Id = @Ex_Id;
end;

exec DeleteExam 1

--select * from exams