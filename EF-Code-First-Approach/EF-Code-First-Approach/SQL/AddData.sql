delete from [dbo].Courses
DBCC CHECKIDENT ('courses', RESEED, 0);
delete from [dbo].[Catagories]
DBCC CHECKIDENT ('Catagories', RESEED, 0);
Delete from [dbo].[students]
DBCC CHECKIDENT ('students', RESEED, 0);
Delete from [dbo].[Exams]
DBCC CHECKIDENT ('Exams', RESEED, 0);

insert into [dbo].[Catagories] values ('Software Development','Software Development')
insert into [dbo].[Catagories] values ('Machine Learning','Machine Learning')
insert into [dbo].[Catagories] values ('Database Management System','Database Management System')
insert into [dbo].[Catagories] values ('Netwroking','Netwroking')


insert into [dbo].[students] values ('Olivia','Linz')
insert into [dbo].[students] values ('Emma','Linz')
insert into [dbo].[students] values ('Sophia','Vienna')
insert into [dbo].[students] values ('Isabella','copenhagen')
insert into [dbo].[students] values ('Lucas','copenhagen')
insert into [dbo].[students] values ('Markus','Paris')
insert into [dbo].[students] values ('Jan','Paris')
insert into [dbo].[students] values ('Benjamin','Paris')
insert into [dbo].[students] values ('Ahmad','Linz')
insert into [dbo].[students] values ('Rami','Munich')
insert into [dbo].[students] values ('David','copenhagen')
insert into [dbo].[students] values ('Gerhard','copenhagen')
insert into [dbo].[students] values ('Oliver','Berlin')


insert into [dbo].Courses values ('C#','Microsoft C#',1)
insert into [dbo].Courses values ('Java','Microsoft C#',1)
insert into [dbo].Courses values ('Python','Microsoft C#',1)


insert into  [dbo].Exams values ('11.01.2022',4,1,1)
insert into  [dbo].Exams values ('11.01.2022',3,2,1)
insert into  [dbo].Exams values ('11.01.2022',1,3,1)
insert into  [dbo].Exams values ('11.01.2022',1,4,1)
insert into  [dbo].Exams values ('11.01.2022',2,5,1)

insert into  [dbo].Exams values ('01.04.2022',4,1,2)
insert into  [dbo].Exams values ('01.04.2022',4,2,2)
insert into  [dbo].Exams values ('01.04.2022',1,3,2)
insert into  [dbo].Exams values ('01.04.2022',2,4,2)
insert into  [dbo].Exams values ('01.04.2022',3,5,2)
