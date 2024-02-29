-- =============================================
-- Author:		<Men3m>
-- Create date: <27/2/2024>
-- =============================================

use OnlineExaminationSystemDB

create proc SelectAllExams
as
select * from exams

exec SelectAllExams