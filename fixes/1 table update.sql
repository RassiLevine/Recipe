alter table Meals add MealsDesc varchar(500) not null default ''

ALTER TABLE dbo.Recipe ADD IsVegan VARCHAR(3) NOT NULL DEFAULT '';

ALTER TABLE dbo.Cookbook ADD SkillLevel varchar(20) not null DEFAULT '';

select * from meals