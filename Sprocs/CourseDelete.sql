create or alter proc dbo.CourseDelete(
    @CourseId int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    delete crcm
    from CourseRecipeCourseMeal crcm
    join CourseMeal cm
    on crcm.courseMealId = cm.CourseMealId
    join Course c
    on c.CourseId = cm.CourseId
    where c.CourseId = @CourseId

    delete cm
    from CourseMeal cm
    join Course c
    on cm.CourseId = c.CourseId
    where c.CourseId = @CourseId

    delete Course
    where CourseId = @CourseId

    return @return
end
go
