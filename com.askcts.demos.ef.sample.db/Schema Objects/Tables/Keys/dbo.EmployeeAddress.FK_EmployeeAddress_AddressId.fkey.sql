ALTER TABLE [dbo].[EmployeeAddress]
	ADD CONSTRAINT [FK_EmployeeAddress_Address] 
	FOREIGN KEY (AddressId)
	REFERENCES [Address] (Id)	

