-- examGeneration
exec examGeneration 'C#', 8, 2, 2

-- examAnswers
exec examAnswers 'C#', 'men3m', 'true', 'true', 'v', 'd', 'e', 'f', 'g', 'h', 'i', 'k'

select * from Exam_Ques_St

select * from StudentCourseExam

delete from Exam_Ques_St

delete from StudentCourseExam


-- examCorrection
exec examCorrection 'C#', 'men3m'

alter table instructors
add Password varchar(100) null, 
	Username varchar(100) null