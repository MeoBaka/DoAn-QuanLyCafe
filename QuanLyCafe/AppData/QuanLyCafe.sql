CREATE DATABASE QUANLYCAFE
GO
USE QUANLYCAFE
GO
CREATE TABLE M3_ACCOUNT(
	ID INT PRIMARY KEY,
	USERS NVARCHAR(18),
	PASSWORD NVARCHAR(100),
	ROLE TEXT
)
GO
CREATE TABLE M3_LOGS(
	ID INT,
	USERS NVARCHAR(18),
	LGTIME DATETIME,
	STATUS TEXT
)

-- PROCEDURE
CREATE PROCEDURE USP_CHECKLOGIN
	@tk NVARCHAR(18),
	@mk NVARCHAR(100)
AS
BEGIN
	select count(*) from M3_ACCOUNT where ((USERS=@tk) and (PASSWORD=@mk))
end

USP_CHECKLOGIN 'lap', '123123';
SELECT * FROM M3_ACCOUNT
-- DATA
INSERT INTO M3_ACCOUNT VALUES
('1', 'admin', '123321', 'staff'),
('2', 'lap', '123123', 'staff')