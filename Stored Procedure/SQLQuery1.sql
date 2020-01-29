create database UserDetails;
use UserDetails;
create table Details(name varchar(10), mobile numeric(10), Id numeric(7) );
insert into Details values('Madhu',5374746362,7140);
insert into Details values('Renu', 9346246774, 7142);
insert into Details values('Ram',9364212246,7143);
-- creating stored procedure--
--input parameter--
CREATE PROC spCustomer
@Id numeric
as
begin
select name,Id from Details where Id=@Id
end

------execution--------
exec spCustomer 7140

-------sp_helptext shows the stored procedure definition---
sp_helptext spCustomer

---- sp_help shows the procedure type, owner to it , created date and time ------
sp_help spCustomer

---Execution with output parameter---
ALTER PROCEDURE spGetCustomerCountById
@Id numeric,
@name varchar Output
AS
BEGIN
SELECT CustomerCount = COUNT(Id) FROM Details WHERE Id = @Id
END

DECLARE @name varchar 
EXECUTE spGetCustomerCountById   @Id = 7140,@name='Madhu' 
PRINT @CustomerCount


 


