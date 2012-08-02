ALTER TABLE [dbo].[EmployeeAddress]
	ADD CONSTRAINT [FK_EmployeeAddress_Employee] 
	FOREIGN KEY (EmployeeId)
	REFERENCES Employee (Id)	

