﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Examination_System.Migrations
{
    /// <inheritdoc />
    public partial class v13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Passed",
                table: "StudentCourseExam",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "StudentCourseExam",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");


            migrationBuilder.Sql(@"
                create proc [dbo].[examGeneration] @crsName varchar(100), @mcq int, @tf int, @studID int
                as
                begin

	                declare @t table(quesId int, question varchar(Max), choice varchar(Max), marks int)

	                declare @t_ids table(quesId int, question varchar(Max), marks int)
	
	                declare @examID int
	                select @examID = count(*)+1
	                from Exams
	
	                insert into Exams values (@examID, @crsName, 3, 100)

	                -- crs id
	                declare @ID int
	                select @ID = c.Crs_ID
	                from Courses c
	                where c.Name = @crsName;

	                -- pick random ques ids
	                insert into @t_ids
	                select top (@mcq)
	                q.Q_Id, q.Name ,q.Marks
	                from Questions q 
	                where q.type = 'mcq' and q.Crs_Id = @ID 
	                order by NEWID()
	
	                insert into @t_ids
	                select top (@tf)
	                q.Q_Id, q.Name ,q.Marks
	                from Questions q 
	                where q.type = 'tf' and q.Crs_Id = @ID 
	                order by NEWID()


                    insert into @t
                    select tt.quesId, tt.question, qch.Choice, tt.marks
                    from @t_ids tt inner join Ques_Choices qch
                        on tt.quesId = qch.Ques_id
                    order by tt.quesId


	                insert into StudentCourseExam (Crs_Id, St_Id, Exam_Id)
	                values (@ID, @studID, @examID)

                    ;WITH RankedData AS (
                        SELECT quesId,
                            ROW_NUMBER() OVER (ORDER BY quesId) AS Rank
                        FROM @t_ids
                    )

                    insert into Exam_Ques_St (Ques_id, St_id, Ex_id)
	                select quesId, @studID , @examID
                    FROM RankedData
                    WHERE Rank <= 10;

                end
            ");

            migrationBuilder.Sql(@"
                create proc examCorrection @crsName varchar(100), @username varchar(100)
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
						where Exam_Id = @examId
	                else 
		                update StudentCourseExam 
		                set grade = @grade, passed = 0
						where Exam_Id = @examId

                end");

            migrationBuilder.Sql(@"
				create proc [dbo].[examAnswers] 
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

					declare @t table(answer varchar(100), qsID int)

					insert into @t (qsID, answer)
					select q.Ques_id, 
					case
						when rowNumber = 1 
						then @ans1
						when rowNumber = 2
						then @ans2
						when rowNumber = 3
						then @ans3
						when rowNumber = 4
						then @ans4
						when rowNumber = 5
						then @ans5
						when rowNumber = 6
						then @ans6
						when rowNumber = 7
						then @ans7
						when rowNumber = 8
						then @ans8
						when rowNumber = 9
						then @ans9
						when rowNumber = 10
						then @ans10
					end as ansVariable

					from (
						select eqs.Ques_id, ROW_NUMBER() over (order by ques_id) as rowNumber
						from Exam_Ques_St eqs
						where Ex_id = @exmID
					) as q

					update Exam_Ques_St
					set St_Answer = t.answer
					from Exam_Ques_St eqs inner join @t t
						on eqs.Ques_id = t.qsID
					where eqs.Ex_id = @exmID
				end
			");

            migrationBuilder.Sql(@"
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
			");

            migrationBuilder.Sql(@"
				create proc SelectExamsById @examId int
				as
				select * from exams 
				where Ex_Id = @examId
			");

            migrationBuilder.Sql(@"
				create proc SelectAllExams
				as
				select * from exams
			");

            migrationBuilder.Sql(@"
				create proc [dbo].[InsertExam]
					@Ex_ID int,
					@Title nvarchar(50),
					@Duration int,
					@TotalGrade int
				as
				begin
					insert into Exams (Ex_Id, Title, Duration, TotalGrade)
					values (@Ex_ID, @Title, @Duration, @TotalGrade)
				end;
			");

            migrationBuilder.Sql(@"
				create proc DeleteExam @Ex_Id int
				as
				begin
					delete from exams
					where Ex_Id = @Ex_Id;
				end;

				exec DeleteExam 1
			");



            migrationBuilder.Sql(@"
                create procedure [dbo].[InsertQuestion] 
                    @name nvarchar(max),
                    @type nvarchar(50),
                    @marks int ,
                    @modelans nvarchar(max)
                as
                Begin
                    insert into questions (name,type,marks,modelans) 
                    values (@name,@type,@marks,@modelans)
                end

            ");

            migrationBuilder.Sql(@"
                Create procedure [dbo].[DeleteQuestion] @id int 
                    as
                    Begin
                        delete from Questions
                        where Q_Id = @id
                    end

            ");

            migrationBuilder.Sql(@"
                create procedure[dbo].[SelectQuestionById] @id int 
                        as
                        Begin
                            select * from Questions
                            where Q_Id = @id
                        end

            ");

            migrationBuilder.Sql(@"
                create procedure [dbo].[UpdateQuestion]
                    @id int ,
                    @name nvarchar(max),
                    @type nvarchar(50),
                    @marks int ,
                    @modelans nvarchar(max)
                as
                begin
                    update Questions
                    set Name = @name ,
                        type = @type ,
                        Marks = @marks ,
                        modelAns = @modelans
                        where q_id = @id 
                end
            ");

            migrationBuilder.Sql(@"
                create procedure [dbo].[SelectQuestions]
                    as
                    Begin
                        select * from Questions
                    end

            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
              name: "Passed",
              table: "StudentCourseExam",
              type: "int",
              nullable: false,
              defaultValue: 0,
              oldClrType: typeof(int),
              oldType: "int",
              oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "StudentCourseExam",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);


            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS examGeneration");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS examCorrection");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS examAnswers");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS UpdateExam");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS SelectExamsById");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS SelectAllExams");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS InsertExam");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS DeleteExam");

            migrationBuilder.Sql(@"DROP PROCEDURE IF EXISTS InsertQuestion ");
            migrationBuilder.Sql(@"DROP PROCEDURE IF EXISTS DeleteQuestion ");
            migrationBuilder.Sql(@"DROP PROCEDURE IF EXISTS SelectQuestionById");
            migrationBuilder.Sql(@"DROP PROCEDURE IF EXISTS UpdateQuestion");
            migrationBuilder.Sql(@"DROP PROCEDURE IF EXISTS SelectQuestions ");
        }
    }
}
