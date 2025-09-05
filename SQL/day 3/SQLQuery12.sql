use Society22;

create table employee_1(
id int primary key,
names varchar(50),
branch varchar(50),
salary float)

select * from employee_1

insert into employee_1 values (5,'Bhavesh','computer',1200000)
insert into employee_1 (id, names, branch ) values (6,'Vikram','IT')

select * from employee_1 where id = 1
select * from employee_1 where id != 1
select * from employee_1 where id > 1
select * from employee_1 where id <= 1

select * from employee_1 where salary is NULL
select * from employee_1 where salary is not NULL

select * from employee_1 where names like 'L%'
select * from employee_1 where names like '%i'

select * from employee_1 where names like 'v%m' and names not like 'p%'

select max(salary) from employee_1
select sum(salary) from employee_1
select * from employee_1

select * from employee_1 where salary = (select max(salary) from employee_1)

select * from employee_1 where salary in (select salary from employee_1 where salary between 10000 and 5000000)
select * from employee_1 where salary between 100 and 1200000

select max(salary) as max_salary from employee_1

select count(*) as count from employee_1 where salary >= 700000
select * from employee_1

select * from employee_1 order by names


