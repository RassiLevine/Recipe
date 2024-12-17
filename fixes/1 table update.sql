alter table Meals add MealsDesc varchar(500) not null default ''

ALTER TABLE dbo.Recipe ADD IsVegan BIT NOT NULL DEFAULT 0;

ALTER TABLE dbo.Cookbook ADD SkillLevel varchar(20);
select * from meals