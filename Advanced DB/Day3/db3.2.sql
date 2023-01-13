--Part2: use SD_DB
--1)	Create view named   “v_clerk” that will display employee#,project#, the date of hiring of all the jobs of the type 'Clerk'.

alter view v_clerk as
select e.EmpNo as empno  ,p.ProjectName , w.Enter_Date
from HR.Employee e,Company.Project p ,Works_on w
where e.EmpNo=w.EmpNo and p.ProjectNo=w.ProjectNo
	and  job='clerk'

--2)	 Create view named  “v_without_budget” that will display all the projects data 
--without budget

create view v_without_budget as
select * 
from Company.Project 
where Budget is null


--3)	Create view named  “v_count “ that will display the project name and the # of jobs in it

create view v_count as 
select p.ProjectName , COUNT(w.Job)as jobNum
from Company.Project p ,Works_on w
where  p.ProjectNo=w.ProjectNo
group by p.ProjectName

--4)	 Create view named ” v_project_p2” that will display the emp#  for the project# ‘p2’
--use the previously created view  “v_clerk”

create view v_project_p2 as
select EmpNo as 'emp' , ProjectName as 'project'
	from v_clerk
	where ProjectName = 'p2'
--5)	modifey the view named  “v_without_budget”  to display all DATA in project p1 and p2 

alter view v_without_budget as
select * from Company.Project
where ProjectNo in('p1','p2')

--6)	Delete the views  “v_ clerk” and “v_count”
drop view v_clerk
drop view v_count



--7)	Create view that will display the emp# and emp lastname who works on dept# is ‘d2’

alter view disp1 as
select  e.EmpNo ,e.EmpLname as lastt
from HR.Employee e 
where  DeptNo='d2'

--8)	Display the employee  lastname that contains letter “J”
--Use the previous view created in Q#7

create view v_clerk as
select lastt
from disp1 
where lastt like '%j%'



--9)	Create view named “v_dept” that will display the department# and department name.

create view v_dept as
select d.DeptNo ,d.DeptName
from Company.Department d



--10)	using the previous view try enter new department data where dept# is ’d4’ and dept name is ‘Development’

insert into v_dept
values('d4' , 'Development')


--11)	Create view name “v_2006_check” that will display employee#, the project #where he works and the date of joining 
--the project which must be from the first of January and the last of December 2006.

create view v_2006_check as
select e.EmpNo ,w.ProjectNo , w.Enter_Date
from HR.Employee e ,Works_on w
where e.EmpNo=w.EmpNo
and year(w.Enter_Date) =2006