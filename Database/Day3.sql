--    Dep(Dname,Dnum,MGRSSN,MGRstartDate)  Emp(Fname,Lname,ssn,bdate,address ,sex,salary,superssn,Dno)
--	  project(pname,pnum,ploc,city,dnum)   workfor(Essn,pno,hours)

--1.	Display the Department id, name and id and the name of its manager.
		select Dnum,Dname,SSN,Fname
		from Departments inner join Employee
		on MGRSSN=Employee.SSN

--2.	Display the name of the departments and the name of the projects under its control.
	select  Departments.Dname,Project.Pname
	from Departments inner join Project
	on Departments.Dnum=Project.Dnum

--3.	Display the full data about all the dependence associated with the name of the employee they depend on him/her.
		select  Dependent.* ,Employee.Fname
		from Dependent inner join Employee
		on Dependent.ESSN = Employee.SSN

--4.	Display the Id, name and location of the projects in Cairo or Alex city.////
	select  Pnumber ,Pname, Plocation
	from  Project
	where City in ('cairo','alex')

--5.	Display the Projects full data of the projects with a name starts with "a" letter.
	select * from Project
	where Pname like 'a%'

--6.	display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select * from Employee 
where Dno=30 and Salary  between 1000 and 2000

--7.	Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
select Fname ,Lname from Employee e  ,Works_for w ,Project p
where e.SSN=w.ESSn and Pno = Pnumber 
and Dno=10 and (Pname = 'AL Rabwah') and Hours>=10



--8.	Find the names of the employees who directly supervised with Kamel Mohamed.
Select E.Fname ,S.Fname from Employee E,Employee S
where E.Superssn=S.SSN and S.Fname='kamel' and S.Lname='mohamed'


--9.	Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select Fname , Pname
from Employee , Works_for , Project
where SSN = ESSn and Pno = Pnumber 
order by Pname
--select *from project
--10.	For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.0 //////
	Select p.Pname ,D.Dname ,E.Lname ,E.address,E.bdate
	from Project p 
	inner join Departments D on p.dnum=D.Dnum
	inner join Employee E on MGRSSN=SSN
	where p.City='cairo'

	--select * from Employee
--11.	Display All Data of the managers/////
	select  em.*
	from Employee Em , Departments d
	where Em.Superssn = d.MGRSSN
	----------


--12.	Display All Employees data and the data of their dependents even if they have no dependents
select E.* ,D.*
from Employee E left join Dependent D
on E.SSN =D.ESSN

--13.	Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
insert into Employee (Fname,Lname,SSN,Address,Sex,salary,Superssn,Dno)
values ('shahenda','hamdy',102672,'STREAT' ,'f',3000,112233,30)

--14.	Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660,
--but don’t enter any value for salary or supervisor number to him.
insert into Employee (Dno,SSN)
values (30,102660)


--15.	Upgrade your salary by 20 % of its last value.////
update Employee 
set Salary = Salary * 1.2
where Employee.Fname='shahenda'
