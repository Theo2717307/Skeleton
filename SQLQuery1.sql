USE [p2717307]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblStaff_FilterByStaff_ID]
		@Staff_ID = 1

SELECT	@return_value as 'Return Value'

GO
