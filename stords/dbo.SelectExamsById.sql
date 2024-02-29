-- =============================================
-- Author:		<Men3m>
-- Create date: <27/2/2024>
-- =============================================

use OnlineExaminationSystemDB

create proc SelectExamsById @examId int
as
select * from exams 
where Ex_Id = @examId

exec SelectExamsById 1