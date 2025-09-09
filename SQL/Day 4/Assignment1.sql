
-- Assignment 1

use Society22;

create table Customers(
CustomerId int,
Name_1 varchar(50),
Address_1 Varchar(50),
Region Varchar(50))

create table Customers1(
CustomerId int,
Name_1 varchar(50),
Address_1 Varchar(50),
Region Varchar(50))

insert into Customers1 values (4, 'Aloof C', 'SK Dam','South');

select * from Customers1

create table SMR(
MeterId int,
CustomerId int,
Location_1 varchar(50),
InstalledDate date,
ReadingDateTime datetime,
EnergyConsumed float)

select * from SMR;

insert into SMR values (304, 4,'rooftop','2024-01-16','2024-03-14', 50.00);


-- Q1. Fetch the smart meter reading where EnergyConsumed is between 10 and 50

select MeterId,ReadingDateTime,EnergyConsumed  from SMR
where EnergyConsumed between 10 and 50;

-- Q2. Fetch the smart meter reading where ReadingDateTime is between 2024-01-01 and 2024-12-31

select MeterId,ReadingDateTime,EnergyConsumed  from SMR
where ReadingDateTime between '2024-01-01 00:00:00.000' and '2024-12-31 00:00:00.000';

-- Q3. Fetch the smart meter reading where InstalledDate is after 2024-06-30 


select MeterId,ReadingDateTime,EnergyConsumed  from SMR
where InstalledDate > '2024-06-30';

select * from Customers1 C
full outer join SMR S
on C.CustomerId = S.CustomerId
where EnergyConsumed between 10 and 50 and
ReadingDateTime between '2024-01-01 00:00:00.000' and '2024-12-31 00:00:00.000' and
InstalledDate > '2024-06-30';

select * from Customers1
select * from SMR


-- Assignment 2

select * from employee_1 where salary = (select max(salary) from employee_1)

select avg(EnergyConsumed) as AvgEnergyConsumed  from SMR;

select * from SMR where EnergyConsumed = (select avg(EnergyConsumed) as AvgEnergyConsumed  from SMR);

select max(EnergyConsumed) as max_energy_consumed  from SMR;

select CustomerId, avg(EnergyConsumed) as AvgEnergyConsumed, max(EnergyConsumed) as MaxEnergyConsumed from SMR
group by CustomerId;




