create procedure UpdateEmp
@empname varchar(20),
@empsalary float,
@empid int
as
begin
update Employeetable set empname=@empname,empsalary=@empsalary where empid=@empid
end