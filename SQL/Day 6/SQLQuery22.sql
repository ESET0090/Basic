use Society22;

select * from student;

CREATE PROCEDURE retrive_data1
as 
begin
select * from student

end 

exec retrive_data1 

drop procedure retrive_data1

create procedure RetriveData
@id int
as 

begin

select * from student where id = @id

end

exec RetriveData @id = 4



use Society22;

select * from Employee;

create procedure CheckEmployeeSalary
@EmpID INT
as
begin

    Declare @Salary INT;

    select @Salary = Salary
    from Employee
    where EmpID = @EmpID;

    if @Salary >= 50000

       print 'High Salary Employee';

    else if @Salary >= 10000

       print 'Medium Salary Employee';

    else 

       print 'Low Salary Employee';

END;


exec CheckEmployeeSalary  @EmpID = 1;



-------------------------------------------------------------------------------------

select * from student

create trigger trg_AfterInsert_Students on student
after insert
as
begin
print 'A new student record has been inserted';
end;

insert into student values (40, 'Gaurav', 2);


select * from book;

create trigger trg_AfterInsert_book on book
after insert
as
begin
print 'A new book record has been inserted';
end;

insert into book values (500, 'Kaliyug', 300);


----------------------------------------------------------------------------------------

select * from Employee;

CREATE TABLE SalaryAudit
(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    emp_id INT,
    OldSalary INT,
    NewSalary INT,
    ChangeDate DATETIME DEFAULT GETDATE()
);

select * from SalaryAudit;


CREATE TRIGGER trg_AuditSalaryChange
ON Employee;
AFTER UPDATE
AS
BEGIN
    IF UPDATE(Salary) -- Run only if Salary column is updated
    BEGIN
        INSERT INTO SalaryAudit (emp_id, OldSalary, NewSalary)
        SELECT 
            d.emp_id,
            d.Salary AS OldSalary,
            i.Salary AS NewSalary
        FROM deleted d
        INNER JOIN inserted i ON d.emp_id = i.emp_id;
    END
END;
 
 
update Employee set Salary=100000 where EmpID = 4;
 
select * from SalaryAudit









