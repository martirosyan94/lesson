Create table student (Id int, name nvarchar(30))

--Insert into student(Id, name)
--values
--(1, 'Gago'),
--(2, 'Mko')

--Select count(*) as totalcount,name from student where id <> 1

--Create table PC (Id INT, StudentId Int, Ip nvarchar(100))

Insert Into PC (id, studentid, Ip)
values
(1, 1, '179')

Select Student.Id, Student.NAme, Pc.Id as pcID from student Join PC on student.Id = pc.StudentId

Select * from Student Group By Id, name having name <> 'gago'

Select * from Student where name like '%g%'

Տիգրան ջան, https://ccollab01/ui#review:id=1290879 ռեվյուի քոմենթների հետ կապված հարցեր ունեի։ Հարմարացնես, նայի 
toEmptyOrReadableFileWithWarning
dpLoadWithwarn) 