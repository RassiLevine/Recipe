alter table Meals add MealsDesc varchar(500) not null default ''
go
ALTER TABLE dbo.Recipe ADD IsVegan VARCHAR(3) NOT NULL DEFAULT '';
go
ALTER TABLE dbo.Cookbook ADD SkillLevel int not null DEFAULT 1;
go
ALTER TABLE cookbook
ADD skillLevelDescription AS 
    CASE
        WHEN SkillLevel = 1 THEN 'Beginner'
        WHEN SkillLevel = 2 THEN 'Intermediate'
        WHEN SkillLevel = 3 THEN 'Advanced'
        ELSE 'Unknown'
    END ;
    go

