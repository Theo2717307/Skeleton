CREATE PROCEDURE sproc_tblStaff_Insert

--create the parameters to the stored procedures

@FirstName  VARCHAR (50), 
@LastName   VARCHAR (50), 
@Position   VARCHAR (50), 
@Department VARCHAR (50), 
@StartDate  DATE,         
@IsManager  BIT         


AS	
	--insert the new record
	INSERT INTO tblStaff (FirstName, LastName, Position, Department, StartDate, IsManager)
	values (@FirstName, @LastName, @Position, @Department, @StartDate, @IsManager)
