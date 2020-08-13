create proc InsertEmp
@empname varchar(20),
@empsalary float
as
begin
insert into Employeetable(empname,empsalary) values(@empname,@empsalary)
end