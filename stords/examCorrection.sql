alter proc examCorrection @crsName varchar(100), @username varchar(100)
as
begin
	declare @studId int
	select @studId = s.St_Id
	from Students s
	where s.UserName = @username
	
	declare @crsId int
	select @crsId = c.Crs_ID
	from Courses c
	where @crsName = c.Name

	declare @examId int
	select @examId = sce.Exam_Id
	from StudentCourseExam sce
	where sce.Crs_Id = @crsId and sce.St_Id = @studId

	declare @grade int
	select @grade = count(*) 
	from Exam_Ques_St a inner join Questions b
		on a.Ques_id = b.Q_Id and a.St_Answer = b.ModelAns
	where a.Ex_id = @examId
	set @grade *= 10

	if(@grade >= 60)
		update StudentCourseExam 
		set grade = @grade, passed = 1
	else 
		update StudentCourseExam 
		set grade = @grade, passed = 0

	select @grade

end