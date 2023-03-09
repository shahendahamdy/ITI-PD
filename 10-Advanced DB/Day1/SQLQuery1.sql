---Create a new user data type named loc with the following Criteria:
--•	nchar(2)
--•	default:NY 
--•	create a rule for this Datatype :values in (NY,DS,KW)) and associate it to the 
create rule r1 as @x in ('NY','DS','KW')

create default def1 as 'NY'

sp_addtype loc,'varchar(2)'  

sp_bindrule r1,loc

sp_bindefault def1,loc
----------------------------------------------------------
create table Department
(
DeptNo varchar(5) primary key,
DeptName varchar(20),
location loc
)

--------------------------------------------------------------------
--Create a rule on Salary column to ensure that it is less than 6000 
create rule r2 as @y<6000
---------------------------------------------
create table Employee
(
EmpNo  int primary key,
EmpFname varchar(20) not null, 
EmpLname varchar(20) not null,
DeptNo varchar(5) foreign key references SD(DeptNo) ,
Salary int unique,
)
sp_bindrule r2, 'Employee.salary'

----------------------------------------------------------
--Table modification

--1-Add  TelephoneNumber column to the employee table[programmatically]

alter table Employee
add TelephoneNumber  varchar(20)

--2-drop this column[programmatically]

alter table Employee
drop column TelephoneNumber  

--3-Bulid A diagram to show Relations between tables
--DN
------------------------------------------------------------------
--2.Create the following schema and transfer the following tables to it 
--a.	Company Schema 
create schema Company

--i.	Department table (Programmatically)
alter schema Company transfer Department

--ii.	Project table (using wizard)
--DN
--b.	Human Resource Schema
create schema HR

--i.	  Employee table (Programmatically)

alter schema HR transfer Employee

--3.	 Write query to display the constraints for the Employee table.
sp_helpconstraint 'hr.EMPLOYEE'

--4.	Create Synonym for table Employee as Emp and then run the following queries and describe the results
CREATE SYNONYM emp   FOR HR.EMPLOYEE

	Select * from Employee
	Select * from [HR].Employee
	Select * from emp
	Select * from [HR].Emp
	--the first and last won't work

--5.	Increase the budget of the project where the manager number is 10102 by 10%.
UPDATE Company.project  
SET budget =budget *1.1
from Company.project , works_on
where Company.project.projectNo=works_on.projectNo and EmpNo=10102 and job='manager'

--6.	Change the name of the department for which the employee named James works.The new department name is Sales.
UPDATE Company.department   
SET deptName = 'Sales'
from  Company.department c ,HR.Employee h
where c.deptNo=h.deptNo

--7.	Change the enter date for the projects for those employees who work in project p1 and belong to department ‘Sales’. The new date is 12.12.2007.
UPDATE Works_on
SET Enter_Date = '12.12.2007'
from  Works_on w  , company.project p ,Company.department d ,hr.employee e
where w.ProjectNo=p.projectNo 
	and e.deptNo=d.deptNo
	and w.EmpNo=e.empNo
	and projectName='p1'
	and DeptName='Sales'

--8.	Delete the information in the works_on table for all employees who work for the department located in KW.

delete  w from Works_on w
	 inner join  hr.employee e
	INNER JOIN   Company.department d
	on W.empNo=.e.empNo
	and e.deptNo=d.deptNo
where location ='KW'


delete  from Works_on 
where empNo in (
	select w.EmpNo from
	Works_on w ,   hr.employee e ,  Company.department d
	where W.empNo=e.empNo
	and e.deptNo=d.deptNo
	And location ='KW'

	)

--9.	Try to Create Login Named(ITIStud) who can access Only student and Course tablesfrom ITI DB then allow him to select and insert data into tables and deny Delete and update .(Use ITI DB)

select* from Company.Department
----------------------------------------------------------------


-----------------------------------------------------------
