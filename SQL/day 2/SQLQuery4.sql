use Society22;

Create table Employee2
(
ID int,
Name1 varchar(30),
Dept varchar(30),
salary varchar(30),
);

select * from Employee2

Insert INTO Employee2
values (4, 'Soumya', 'IT', '100000')

update Employee2 set salary = (salary*1.4) 
where ID = 4;

ALTER TABLE Employee2
ALTER COLUMN salary float;

delete from Employee2 where ID = 4;

exec sp_rename 'Employee2' , 'Bhai'

ALTER TABLE Bhai
ALTER COLUMN salary varchar(100);

select * from Bhai

Alter Table Bhai add phone_no varchar(50);

exec sp_rename 'Bhai.Phone_No', 'mobile_no', 'column'

update Bhai 
set mobile_no = '4664465764'
where Name1 = 'Kunal'





