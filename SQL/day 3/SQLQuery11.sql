use Society22;

create table student(
id int primary key,
names varchar(50))

select * from student

insert into student values (3, 'raj', null);

alter table student
add number int unique

create table teachers (id int, subjects varchar(50),
foreign key (id) references student(id))

insert into teachers values (1, 'Math')

select * from teachers
select * from student

delete from teachers where id = 1
delete from student where id = 1

insert into student values (4, 'rajjj', null);
insert into teachers values (4, 'Math')

create table users(
user__id int primary key,
email varchar(50),
names varchar(100))

select * from users

create table book(
product__id int primary key,
title varchar(50),
prices int)

select * from users
select * from book

insert into users values (4, 'ganesh@gmail.com', 'ganesh');

insert into book values (40, 'Kaliyug', 300);

create table orders (user___id int, product___id int,
foreign key (user___id) references users(user__id),
foreign key (product___id) references book(product__id),
order_no int)

select * from orders
select * from users
select * from book

insert into orders values (1, 10, 103);

select order_no,product_id,user___id from orders;