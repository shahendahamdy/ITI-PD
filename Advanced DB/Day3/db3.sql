--Note: Use ITI DB
--1.	 Create a view that displays student full name, course name if the student has a grade more than 50. 

create view studentData as 
select concat(St_Fname,St_Lname)as fullName ,crs_name 
from Student s, Course c ,Stud_Course sc
where c.Crs_Id=sc.crs_id  and s.St_Id =sc.St_Id
	and sc.Grade<50

--2.	 Create an Encrypted view that displays manager names and the topics they teach. 
create view MgrData  
WITH ENCRYPTION
AS
select  i.Ins_Name ,t.Top_Name
FROM Department d, Instructor i ,Topic t ,Course c, Ins_Course ic
where t.Top_Id=c.Top_Id and c.Crs_Id=ic.Crs_Id and ic.Ins_Id=i.Ins_Id and i.Ins_Id = d.Dept_Manager

--3.	Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department 
create view InsData as 
select i.Ins_Name ,d.Dept_Name 
FROM Department d, Instructor i 
where i.Ins_Id = d.Dept_Manager and d.Dept_Name in('SD','Java')

--4.	 Create a view “V1” that displays student data for student who lives in Alex or Cairo. 
--Note: Prevent the users to run the following query 
--Update V1 set st_address=’tanta’
--Where st_address=’alex’;
alter view v1 as 
select * from Student
where Student.St_Address in( 'Alex' , 'Cairo')
with check option

--5.	Create a view that will display the project name and the number of employees work on it. “Use SD database”
create view project_Data as 
select p.ProjectName ,count(e.EmpNo)
from company.project p ,HR.Employee e, Works_on w
where p.ProjectNo=w.ProjectNo and e.EmpNo=w.EmpNo
group by p.ProjectName

--6.	Create index on column (Hiredate) that allow u to cluster the data in table Department. What will happen?

create clustered index i1
on Department(manager_hiredate) --Cannot create more than one clustered index on table 'Department'

--7.	Create index that allow u to enter unique ages in student table. What will happen? 
create unique index i2  
on student(st_age)
--error
--The CREATE UNIQUE INDEX statement terminated because a duplicate key was found for the object name 'dbo.Student' and the index name 'i2'. The duplicate key value is (21).

--8.	Using Merge statement between the following two tables [User ID, Transaction Amount]


create table DailyTransction(
	id int  primary key ,
	quantity int
)	

create table LastTransction(
	id int  primary key ,
	quantity int
)	
merge  DailyTransction as DT
using LastTransction as LT
on DT.id = LT.id
when matched and (LT.quantity >  DT.quantity )
	then update 
	set DT.quantity = LT.quantity  
when not matched 
	then insert 
	values(LT.id,LT.quantity);

select * from DailyTransction
