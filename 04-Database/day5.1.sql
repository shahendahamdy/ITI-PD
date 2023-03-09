select * from Student
select * from Instructor
select * from Stud_Course
select * from Department
select * from Topic
select * from Course


--1.	Retrieve number of students who have a value in their age. 
select count(s.St_Age)
from Student s

--2.	Get all instructors Names without repetition
select distinct i.Ins_Name
from Instructor i

--3.	Display student with the following Format (use isNull function)
select  isnull(s.St_Fname,' '),isnull(s.St_Lname,' '),isnull(d.Dept_Name,' ')
from Student s,Department d
where s.Dept_Id=d.Dept_Id


--4.	Display instructor Name and Department Name 
--Note: display all the instructors if they are attached to a department or not
select isnull(i.Ins_Name,' '),isnull(d.Dept_Name,' ')
from Instructor i LEFT JOIN Department d
ON i.Dept_Id=d.Dept_Id


--5.	Display student full name and the name of the course he is taking --For only courses which have a grade  

select  isnull(s.St_Fname,' '),isnull(s.St_Lname,' '),isnull(cc.Crs_Name,' ')
from Student s,Stud_Course c ,Course cc
where s.St_Id=c.St_Id and c.Crs_Id=cc.Crs_Id and c.Grade is not null


--6.	Display number of courses for each topic name

select  t.Top_Name ,count (cc.Crs_Name)
from topic t ,Course cc
where cc.Top_Id=t.Top_Id
group by Top_Name
--order by Top_Name


--7.	Display max and min salary for instructors
select max(i.Salary),min(i.Salary)
from Instructor i

--8.	Display instructors who have salaries less than the average salary of all instructors.
select i.Ins_Name
from Instructor i
where Salary<(select avg(ISNULL(Salary,0)) from Instructor)


--9.	Display the Department name that contains the instructor who receives the minimum salary.
select d.Dept_Name
from Department d,Instructor s
where d.Dept_Id=s.Dept_Id and  s.Salary=(select top 1 s.Salary from Instructor s order by Salary asc )


--10.	 Select max two salaries in instructor table. 
select top 2 s.Salary from Instructor s order by Salary ASC 

--11.	 Select instructor name and his salary but if there is no salary display instructor bonus keyword. “use coalesce Function”

select i.Ins_Name,coalesce(convert(char,i.Salary),'bonus')
from Instructor i


--12.	Select Average Salary for instructors 
select Avg(ISNULL(salary,0))
from Instructor

--13.	Select Student first name and the data of his supervisor 
SELECT s.St_Fname ,sup.*
from Student s left join Student sup
on s.St_super=sup.St_Id

--14.	Write a query to select the highest two salaries in Each Department for instructors who have salaries. “using one of Ranking Functions”

select * FROM
	(select *,ROW_NUMBER() over(partition by dept_id order by salary desc) as DR
from Instructor  i ) as newtable
where Dr<=2

--15.	 Write a query to select a random  student from each department.  “using one of Ranking Functions”
select * FROM
	(select *,ROW_NUMBER() over(partition by dept_id order by newID()) as DR
from Instructor  i ) as newtable
where Dr=1