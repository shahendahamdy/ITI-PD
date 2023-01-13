--1.	Create a stored procedure without parameters to show the number of students per department name.[use ITI DB] 
use ITI
alter proc StperDep
as
select s.Dept_Id,count(s.St_Id)
From Student s
where s.Dept_Id is  not null
group by s.Dept_Id

StperDep

--2.	Create a stored procedure that will check for the # of employees in the project p1 
--if they are more than 3 print message to the user “'The number of employees in the project p1 is 3 or more'” 
--if they are less display a message to the user “'The following employees work for the project p1'” 
--in addition to the first name and last name of each one. [Company DB] 
use SD
create proc  noOfEmp
as
declare @cnt int
select @cnt= count(e.EmpNo)
from Works_on w ,Company.Project p , Hr.Employee e
where w.EmpNo=e.EmpNo and p.ProjectNo=w.ProjectNo and p.ProjectNo = 'p1'

if (@cnt>3) select 'The number of employees in the project p1 is 3 or more'
else
select 'The following employees work for the project p1'  ,e.EmpFname ,e.EmpLname
from Works_on w ,Company.Project p , Hr.Employee e
where w.EmpNo=e.EmpNo and p.ProjectNo=w.ProjectNo and p.ProjectNo='p1'

noOfEmp

--3.	Create a stored procedure that will be used in case there is an old employee has left the project 
--and a new one become instead of him.
--The procedure should take 3 parameters (old Emp. number, new Emp. number and the project number)
--and it will be used to update works_on table. [Company DB]

alter proc P1 @old int ,@new int , @pno varchar(5)
 as
 BEGIN TRY  
update Works_on
	set EmpNo = @new 
	where (EmpNo = @old) and (ProjectNo = @pno)
end try
begin catch
select 'error'
end catch


 P1  9031, 29346 ,'p3'

--4.	add column budget in project table and insert any draft values in it then 
--then Create an Audit table with the following structure 
--ProjectNo 	UserName 	ModifiedDate 	Budget_Old 	Budget_New 
--p2 	Dbo 	2008-01-31	95000 	200000 
create table Audit(
ProjectNo varchar(20),
UserName varchar(20),
ModifiedDate date,
Budget_Old int,
Budget_New int
)

create trigger tr
on Company.Project 
for update 
as 
	declare @pno varchar(5) , @old int ,  @new int 
	select @pno = ProjectNo , @old = budget from deleted 
	select @new = budget from inserted 

	insert into Audit
	values(@pno, SUSER_NAME() , GETDATE() , @old , @new)

update Company.Project
set Budget = 5000
where ProjectNo='p3'
--This table will be used to audit the update trials on the Budget column (Project table, Company DB)
--Example:
--If a user updated the budget column then the project number, user name that made that update, the date of the modification and the value of the old and the new budget will be inserted into the Audit table
--Note: This process will take place only if the user updated the budget column

--5.	Create a trigger to prevent anyone from inserting a new record in the Department table [ITI DB]
--“Print a message for user to tell him that he can’t insert a new record in that table”


use ITI

create trigger tr_prevent_Delete
on Department
instead of insert
as
	select 'not allowed'

insert into Department values (15	, 'SD'	, 'SD'	, 'Cairo',	1	,'2000-01-01')


--6 Create a trigger that prevents the insertion Process for Employee table in March [Company DB].
use SD
create trigger tr_prevent_Insert
on Hr.Employee
instead of insert
as
	if DATENAME(mm , GETDATE()) = 'March'
		select 'not allowed'
	else 
		insert into Employee select * from inserted

insert into HR.Employee values (20,'emp1','x','d3',2000)



--7.	Create a trigger on student table after insert to add Row in Student Audit table (Server User Name , Date, Note) where note will be “[username] Insert New Row with Key=[Key Value] in table [table name]”
--Server User Name		Date 
	--Note 
use ITI
create table St_Audit(
UserName varchar(20),
datee date,
Note varchar(20)
)


alter trigger tr_insert
on Student 
after insert 
as 
	declare @stNo int , @stName varchar(100) 
	select @stNo = St_Id , @stName = St_Fname  from inserted 

	insert into St_Audit
	values( SUSER_NAME() , GETDATE() , @stName + ' Insert New Row with Key= ' + convert(varchar(20) , @stNo )+ ' in table Student' )

insert into Student values(23	, 'daaa'	, 'Saleh2'   , 'Tanta',	30	, NULL	,NULL)

select * from St_Audit

--8.	 Create a trigger on student table instead of delete to add Row in Student Audit table (Server User Name, Date, Note) where note will be“ try to delete Row with Key=[Key Value]”
create trigger tr_insert_2
on Student 
instead of delete 
as 
	declare @stNo int 
	select @stNo = St_Id from deleted 

	insert into St_Audit
	values( SUSER_NAME() , GETDATE() , ' try to delete Row with with Key= ' + convert(varchar(20) , @stNo ))

delete from Student
where St_Id = 6


select * from St_Audit


-- 9.	Display all the data from the Employee table (HumanResources Schema) 
-- As an XML document “Use XML Raw”. “Use Adventure works DB” 
use SD
-- A)	Elements

select * from HR.Employee	
for xml raw('Employee'),ELEMENTS,ROOT('Employees')
-- B)	Attributes
select * from  HR.Employee	
for xml raw('Employee'),Root('Employees')

-- 10.	Display Each Department Name with its instructors. “Use ITI DB”
use ITI

-- A)	Use XML Auto
select dept.Dept_Name ,  ins.Ins_Name
from Department dept , Instructor ins
where dept.Dept_Id = ins.Dept_Id
for xml auto,elements,root('Instructors_Inside_Department')

-- B)	Use XML Path

select dept.Dept_Name "@Dept_Name",
	(select ins.Ins_Name 
	from Instructor ins
	where dept.Dept_Id = ins.Dept_Id
	for xml path('Instructor'),TYPE,root('Instructors')
	)
from Department dept
for xml path('Department'),root('Instructors_Inside_Department')

--11.	Use the following variable to create a new table “customers” inside the company DB. Use OpenXML
use ITI

declare @docs xml ='<customers>
              <customer FirstName="Bob" Zipcode="91126">
                     <order ID="12221">Laptop</order>
              </customer>
              <customer FirstName="Judy" Zipcode="23235">
                     <order ID="12221">Workstation</order>
              </customer>
              <customer FirstName="Howard" Zipcode="20009">
                     <order ID="3331122">Laptop</order>
              </customer>
              <customer FirstName="Mary" Zipcode="12345">
                     <order ID="555555">Server</order>
              </customer>
       </customers>'

--3)declare document handle
declare @hdocs int

--4)create memory tree
Exec sp_xml_preparedocument @hdocs output, @docs

--5)process document 'read tree from memory'
SELECT * FROM OPENXML (@hdocs, '//customer') 
WITH (FirstName varchar(20) '@FirstName' , ZipCode int '@Zipcode' ,
orderItem  varchar(20) 'order',
orderID int 'order/@ID' 
)

--5)remove memory tree
Exec sp_xml_removedocument @hdocs