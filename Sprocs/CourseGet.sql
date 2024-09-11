create or alter proc dbo.CourseGet(
    @CourseId int = 0,
    @All bit = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select CourseId, CourseType, CourseSequence
    from Course
    where CourseId = @CourseId 
    or @All = 1

    return @return
end
go
