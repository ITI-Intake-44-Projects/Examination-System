create proc examAnswers 
	@crsName varchar(100), @username varchar(100), @ans1 varchar(100),
	@ans2 varchar(100), @ans3 varchar(100), @ans4 varchar(100),
	@ans5 varchar(100), @ans6 varchar(100), @ans7 varchar(100),
	@ans8 varchar(100), @ans9 varchar(100), @ans10 varchar(100)
as
begin
	declare @crsID int
	select @crsID = c.Crs_ID
	from Courses c
	where c.Name = @crsName;

	declare @stdID int
	select @stdID = s.St_Id
	from Students s
	where s.UserName = @username

	declare @exmID int
	select @exmID = ecs.Exam_Id
	from  StudentCourseExam ecs
	where ecs.St_Id = @stdID and ecs.Crs_Id = @crsID

	declare @t table(answer int, exID int)
	insert into @t values (@ans1, @exmID), (@ans2, @exmID),(@ans3, @exmID),(@ans4, @exmID),(@ans5, @exmID), (@ans6, @exmID), (@ans7, @exmID),(@ans8, @exmID),(@ans9, @exmID),(@ans10, @exmID)

	update eqs
	set eqs.St_Answer = t.answer
	from Exam_Ques_St eqs JOIN @t t 
		on eqs.Ex_id = t.exID
end