select *from Employee
select *from Dependent

select *from Departments
select *from Dependent
select *from Project
select *from Works_for

-- 1.	Display (Using Union Function)
--a.	 The name and the gender of the dependence that's gender is Female and depending on Female Employee.
--b.	 And the male dependence that depends on Male Employee.
select  d.Dependent_name ,d.Sex
from Dependent d  , Employee e
where e.SSN=d.ESSN and e.Sex='f' and d.Sex='f'
union
select  d.Dependent_name ,d.Sex
from Dependent d  , Employee e
where e.SSN=d.ESSN and e.Sex='m' and d.Sex='m'

--2.	For each project, list the project name and the total hours per week (for all employees) spent on that project.
select p.Pname,sum(w.Hours)
from Project p ,Works_for w
where p.Pnumber=w.Pno
group by Pno,Pname


--3.	Display the data of the department which has the smallest employee ID over all employees' ID.

select d.*
from Departments d
where  d.Dnum = ( select Dno from Employee e , Departments d where Dno=Dnum and e.ssn =(select min(SSN) from employee  ))

select d.*
from  Employee e , Departments  d
where Dno=Dnum and e.ssn =(select min(SSN) from employee  )
			

--4.	For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
select d.Dname,max(salary),min(salary),avg(salary)
from Departments d, Employee e
where d.Dnum=e.Dno
group by D.Dname

--5.	List the full name of all managers who have no dependents.
select ssn
from Employee e ,Departments d 
where e.SSN= d.MGRSSN  and  d.MGRSSN not in (select ESSN from Dependent)


select distinct Fname + ' '+Lname
from Employee e,Dependent dd
where e.SSN!=dd.ESSN
and 
e.SSN in(select ssn
	from Employee e ,Departments d 
	where e.SSN= d.MGRSSN )

--6.	For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.
select  d.Dnum ,d.Dname,count(e.SSN)
from Departments d,Employee e 
where d.Dnum=e.Dno
group by d.Dnum,d.Dname
having Avg(salary)<(select AVG(Salary) from employee)



--7.	Retrieve a list of employees names and the projects names they are working on ordered by department number and within each department,
--ordered alphabetically by last name, first name.
select e.Fname,e.Lname,p.Pname
from Project p ,Employee e ,Works_for w
where w.ESSn=e.SSN and w.Pno=p.Pnumber
order by e.Dno ,e.Lname,e.Fname



--8.	Try to get the max 2 salaries using subquery
select max(salary) 
from Employee
union all
select max(salary) 
from Employee where Salary not in (select max(salary) 
from Employee)

--9.	Get the full name of employees that is similar to any dependent name
select  e.Fname +' '+e.Lname
from   Employee e
intersect
select  d.Dependent_name
from Dependent d  

--10.	Display the employee number and name if at least one of them have dependents (use exists keyword) self-study.
select e.SSN,e.Fname,e.Lname
from   Employee e
where EXISTS (select Dependent_name from Dependent where SSN = ESSN)


--11.	In the department table insert new department called "DEPT IT" , with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'

insert into Departments
values('DEPT IT',100,112233, '1-11-2006')

--12.	Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager) 

--a.	First try to update her record in the department table
update Departments
set MGRSSN=968574 where Dnum=100

--b.	Update your record to be department 20 manager.
update Departments
set MGRSSN=102672 where Dnum=20

--c.	Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
update Employee
set Superssn=102672 where SSN=102660



--13.	Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database 
--in case you know that you will be temporarily in his position.
--Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handle these cases).

update Employee set Superssn= 102672 where Superssn=223344
update Dependent set ESSN=102672 where ESSN=223344
update Works_for set ESSn=102672 where ESSn=223344
delete from Employee where (SSN = 223344) 

--14.	Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%
update Employee 
set Salary=Salary*1.3
from Works_for w ,Project p
where p.Pnumber=w.Pno and  w.ESSn=SSN and (Pname = 'Al Rabwah')
