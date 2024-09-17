/*CREATE TABLE Patients (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    Address NVARCHAR(255) NOT NULL,
    BloodGroup NVARCHAR(10) NOT NULL,
    EmailAddress NVARCHAR(100) NOT NULL UNIQUE,
    PhoneNumber NVARCHAR(15) NOT NULL UNIQUE,
    DoctorReferred NVARCHAR(100) NOT NULL,
    Height DECIMAL(3, 2) NOT NULL CHECK (Height BETWEEN 1.0 AND 6.0),
    BMI DECIMAL(4, 2) NOT NULL CHECK (BMI BETWEEN 18.0 AND 25.0),
    MaritalStatus NVARCHAR(10) NOT NULL,
    Allergies NVARCHAR(255) NOT NULL
);
*/

--Drop table Patients

Select * from dbo.Patients

--delete from dbo.Patients