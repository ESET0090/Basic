use Society22;

select * from Employee;

select * from employee_1;

select EmpID, Name_s from Employee union all
select id , names from employee_1;

select EmpID, Name_s from Employee union 
select id , names from employee_1;

select * from employee_1;

select upper(Name_s) as Upper from Employee;

select len(Name_s) from Employee;

select Lower(Name_s) from Employee;

select len('shivam    ') as hello;

select SUBSTRING (Name_s,3, 6) as substring from Employee;

select reverse (Name_s) as Reverse from Employee;

select replace('Shivam Likes Tea','Tea','Coffee') as replace_eg;

select CONCAT(EmpID, '   ' , Name_s, '   ', Department) as ID_name_Department from Employee;

-- select cast ('5000' as int) as SalaryInt;

-- Select cast(emp_id as float) form employee;

select GETDATE();

select convert (varchar(10), GETDATE(), 103);

