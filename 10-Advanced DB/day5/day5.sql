--1.	Create a cursor for Employee table that increases Employee salary by 10% if Salary <3000 and increases it by 20% if Salary >=3000. Use company DB
use Company_SD


declare c1 cursor
for select salary from Employee
for update
declare @sal int
open c1
fetch c1 into @sal
while @@FETCH_STATUS=0
	begin  
		if @sal>=3000
			update Employee    --1 row affected
				set salary=@sal*1.2
			where current of c1
		else if @sal<3000
			update Employee
				set salary=@sal*1.1
			where current of c1
		else
			delete from Employee
			where current of c1
		fetch c1 into @sal
	end
close c1
deallocate c1


--2.	Display Department name with its manager name using cursor. Use ITI DB
use  ITI
declare c1 cursor
for select Dept_Name ,Ins_Name from Department d , Instructor ins
	where ins.Dept_Id = d.Dept_Id
for read only   

declare @deptName varchar(20),@Mgr varchar(20)
open c1
fetch c1 into @deptName,@Mgr
while @@FETCH_STATUS=0
	begin
		select @deptName,@Mgr
		fetch c1 into @deptName,@Mgr
	end
close c1
deallocate c1

--3.	Try to display all students first name in one cell separated by comma. Using Cursor 
declare c1 cursor
for select distinct st_fname from student where st_fname is not null
for read only

declare @name varchar(20),@all_names varchar(300)
open c1
fetch c1 into @name     
while @@FETCH_STATUS=0
	begin
		set @all_names=CONCAT(@all_names,',',@name)
		fetch c1 into @name   
	end
select @all_names
close c1
deallocate c1

--4.	Create full, differential Backup for SD DB.

--5.	Use import export wizard to display students data (ITI DB) in excel sheet
dn
--6.	Try to generate script from DB ITI that describes all tables and views in this DB
dn

--7.	Create a sequence object that allow values from 1 to 10 without cycling in a specific column and test it.

use ITI
CREATE SEQUENCE dbo.Test
AS INT
START WITH 5
INCREMENT BY 5