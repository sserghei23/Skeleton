USE [p2669691]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblCustomer_FilterByCustomerId]
		@CustomerId = NULL

SELECT	@return_value as 'Return Value'

GO
