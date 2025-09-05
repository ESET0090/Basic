CREATE DATABASE Society22;

USE Society22;

CREATE TABLE Employee (
    EmpID INT PRIMARY KEY,
    Name_s VARCHAR(50),
    Department VARCHAR(20),
    Salary DECIMAL(10,2)
);

INSERT INTO Employee(EmpID, Name_s, Department, Salary) VALUES
(1, 'Gaurav', 'IT', 50000.00),
(2, 'Yash', 'Energy Storage', 55000.00),
(3, 'Manoj', 'Energy Storage', 60000.00),
(4, 'Pranay', 'Consultancy', 65000.00),
(5, 'Balaji', 'IT', 70000.00);

select * from Employee;

SELECT min(Salary) FROM Employee;