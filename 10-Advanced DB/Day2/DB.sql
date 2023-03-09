--Note: Use ITI DB
--1.	Create a scalar function that takes date and returns Month name of that date.

alter function getMonthFromDate(@dt date)
returns int
begin
declare @month nvarchar(20)
	set @month=month(@dt)
return @month	
end

select dbo.getMonthFromDate('2010-12-31')

--2.	 Create a multi-statements table-valued function that takes 2 integers and returns the values between them.
create function allValues(@num1 int,@num2 int) 
returns @t table
		(
		 arr int 
		)
as
begin
	declare @i int
	set @i=@num1
	while(@i>=@num1 and @i<=@num2)
	begin
		insert into @t 
		values(@i)
		set @i+=1
	end
return
end

select * from allvalues(5,10) 

--3.	 Create inline function that takes Student No and returns Department Name with Student full name
alter function getData(@sNo int)
returns table
as 
return
(
select Dept_Name,concat(st_fname,st_lname) as fullName
from student s ,Department 
where s.Dept_Id=Department.Dept_Id
	and s.St_Id=@sNo
)
select * from getData(1)


--4.	Create a scalar function that takes Student ID and returns a message to user 
--a.	If first name and Last name are null then display 'First name & last name are null'
--b.	If First name is null then display 'first name is null'
--c.	If Last name is null then display 'last name is null'
--d.	Else display 'First name & last name are not null'
alter function userMsg(@sNo int)
returns varchar(100)
begin
	declare @msg nvarchar(100)
	declare @f nvarchar(100)
	declare @l nvarchar(100)
	select @f=St_Fname ,@l=St_Lname
	from Student
	where st_id=@sNo
	if @f is null and @l is null
		set @msg='First name & last name are null'
	Else if @f is null
		set @msg='first name is null'
	Else if @l is null
		set @msg='last name is null'
	else
		set @msg='First name & last name are not null'
return @msg
end

select dbo.userMsg(1)
select dbo.userMsg(13)
select dbo.userMsg(14)

--5.	Create inline function that takes integer which represents manager ID and displays department name, Manager Name and hiring date 
create function MGRData(@mID int)
returns table
as
return(
	select Dept_Name , Ins_Name ,Manager_hiredate
	from Department d ,Instructor i
	where d.Dept_Manager=i.Ins_Id
		And d.Dept_Manager=@mID
)
select* from MGRData(1)
--6.	Create multi-statements table-valued function that takes a string
--If string='first name' returns student first name
--If string='last name' returns student last name 
--If string='full name' returns Full Name from student table 
--Note: Use “ISNULL” function
create function stringDetect(@st varchar(100))
returns @t table
		(
			namee varchar(100)
		)
as
begin
	if @st = 'first name' 
			begin
			insert into @t (namee)
			select isnull(St_Fname,'no name..') from Student
			end
	Else if @st = 'last name' 
			begin
			insert into @t (namee)
			select isnull(St_Lname,'no name..') from Student
			end
	Else if @st = 'full name' 
		begin
		insert into @t 
		(namee)select  isnull(St_Fname,'')+' '+isnull(St_Lname,'') from Student 
		end
	return
end

select * from stringDetect('first name')

--7.	Write a query that returns the Student No and Student first name without the last char
select St_Id, left(St_Fname,len(St_Fname)-1)
from student 


--8.	Wirte query to delete all grades for the students Located in SD Department 
delete s
from Stud_Course s, Department d , student st
where st.st_id = s.st_id and d.dept_id = st.dept_id and d.dept_name='SD'



-
--Bonus:
--1.	Give an example for hierarchyid Data type
--2.	Create a batch that inserts 3000 rows in the student table(ITI database). The values of the st_id column should be unique and between 3000 and 6000. All values of the columns st_fname, st_lname, should be set to 'Jane', ' Smith' respectively.

