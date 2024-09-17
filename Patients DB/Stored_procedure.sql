CREATE PROCEDURE GetPatients
AS
BEGIN
    SELECT 
        ID, 
        Name, 
        Gender, 
        Address, 
        BloodGroup, 
        EmailAddress, 
        PhoneNumber, 
        DoctorReferred, 
        Height, 
        BMI, 
        MaritalStatus, 
        Allergies
    FROM 
        Patients
END





Select * from dbo.GenderOptions

--Insert into GenderOptions values('Male')

--delete from dbo.GenderOptions

--Insert into GenderOptions values('Female')

/*
ALTER TABLE GenderOptions
ALTER COLUMN Gender NVARCHAR(50) NOT NULL;

ALTER TABLE GenderOptions
ADD CONSTRAINT UQ_Gender UNIQUE (Gender);
*/

--INSERT INTO GenderOptions(Gender) VALUES ('Sigma');

select * from dbo.Patients

delete from GenderOptions where Gender='SSMS';

Insert into dbo.MaritalStatusOptions values('Sad')

select * from dbo.MaritalStatusOptions

delete from MaritalStatusOptions
delete from GenderOptions
delete from dbo.Patients

DBCC CHECKIDENT ('Patients', RESEED, 0);
DBCC CHECKIDENT ('GenderOptions', RESEED, 0);
DBCC CHECKIDENT ('MaritalStatusOptions', RESEED, 0);

Insert into dbo.MaritalStatusOptions values('Divorced')

Insert into dbo.GenderOptions values('Female')