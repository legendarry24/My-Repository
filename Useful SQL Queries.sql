-- Applying Select Distinct to One Column Only
SELECT *
FROM (
	SELECT [ID],
		   [Name],
		   ROW_NUMBER() OVER(PARTITION BY [Name] ORDER BY [ID] DESC) RowNumber
	FROM [UserRole]
) a
WHERE RowNumber = 1


-- Verify if SQL command is correct before executing
BEGIN TRAN
	DELETE MyTable WHERE ID = 1
ROLLBACK


-- Displays the definition of a stored procedure
sp_helpText MyProcedure


ALTER AUTHORIZATION ON DATABASE::[DataBaseName] TO sa; -- устранить ошибку dbo не существует

DBCC CHECKIDENT ("[dbo].[TableName]", RESEED, 0) -- Изменяем значение IDENTITY на 0
GO

SELECT * FROM INFORMATION_SCHEMA.TABLES;
GO

SELECT * FROM INFORMATION_SCHEMA.COLUMNS;
GO

SELECT
   ORDINAL_POSITION
  ,TABLE_CATALOG
  ,TABLE_NAME
  ,COLUMN_NAME
  ,DATA_TYPE
  ,CHARACTER_MAXIMUM_LENGTH
  ,IS_NULLABLE
  ,COLUMN_DEFAULT
FROM INFORMATION_SCHEMA.COLUMNS
ORDER BY TABLE_NAME
GO

-- по умолчанию у всех таблиц префикс [dbo]. Но можно создать пользовательский префикс,
-- для более удобной группировки таблиц.
-- также в папке [DatabaseName]/Security/Schemas есть список всех доступных схем,
-- которые we can use в качестве префикса.
CREATE SCHEMA [SchemaName]
GO
CREATE TABLE SchemaName.[TableName] (
  
)
GO

SELECT @@VERSION

SELECT
	CASE 
		 WHEN CONVERT(VARCHAR(128), SERVERPROPERTY ('productversion')) like '8%' THEN 'SQL2000'
		 WHEN CONVERT(VARCHAR(128), SERVERPROPERTY ('productversion')) like '9%' THEN 'SQL2005'
		 WHEN CONVERT(VARCHAR(128), SERVERPROPERTY ('productversion')) like '10.0%' THEN 'SQL2008'
		 WHEN CONVERT(VARCHAR(128), SERVERPROPERTY ('productversion')) like '10.5%' THEN 'SQL2008 R2'
		 WHEN CONVERT(VARCHAR(128), SERVERPROPERTY ('productversion')) like '11%' THEN 'SQL2012'
		 WHEN CONVERT(VARCHAR(128), SERVERPROPERTY ('productversion')) like '12%' THEN 'SQL2014'
		 WHEN CONVERT(VARCHAR(128), SERVERPROPERTY ('productversion')) like '13%' THEN 'SQL2016'
		 WHEN CONVERT(VARCHAR(128), SERVERPROPERTY ('productversion')) like '14%' THEN 'SQL2017'
		 WHEN CONVERT(VARCHAR(128), SERVERPROPERTY ('productversion')) like '15%' THEN 'SQL2019'
		 ELSE 'unknown'
	END AS MajorVersion,
	SERVERPROPERTY('ProductLevel') AS ProductLevel,
	SERVERPROPERTY('Edition') AS Edition,
	SERVERPROPERTY('ProductVersion') AS ProductVersion


SELECT GETDATE() as 'local time'
SELECT GETUTCDATE() as 'UTC'
SELECT CURRENT_TIMESTAMP


-- this script will list the number of rows and the space used by data rows (and the total space used) 
-- for all tables in your database
SELECT 
 t.NAME AS TableName,
 i.name AS indexName,
 SUM(p.rows) AS RowCounts,
 SUM(a.total_pages) AS TotalPages, 
 SUM(a.used_pages) AS UsedPages, 
 SUM(a.data_pages) AS DataPages,
 (SUM(a.total_pages) * 8) / 1024 AS TotalSpaceMB, 
 (SUM(a.used_pages) * 8) / 1024 AS UsedSpaceMB, 
 (SUM(a.data_pages) * 8) / 1024 AS DataSpaceMB
FROM 
 sys.tables t
INNER JOIN  
 sys.indexes i ON t.OBJECT_ID = i.object_id
INNER JOIN 
 sys.partitions p ON i.object_id = p.OBJECT_ID AND i.index_id = p.index_id
INNER JOIN 
 sys.allocation_units a ON p.partition_id = a.container_id
WHERE t.NAME NOT LIKE 'dt%' 
	AND i.OBJECT_ID > 255 
	AND i.index_id <= 1
GROUP BY t.NAME, i.object_id, i.index_id, i.name 
ORDER BY TotalSpaceMB DESC

SELECT physical_name FROM [sys].[master_files] WHERE name = 'master'

CHECKPOINT
DBCC DROPCLEANBUFFERS
DECLARE @myDb AS INT = DB_ID(); DBCC FLUSHPROCINDB(@myDb);

-- Drop the database 'DbName'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Uncomment the ALTER DATABASE statement below to set the database to SINGLE_USER mode if the drop database command fails because the database is in use.
-- ALTER DATABASE DbName SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
-- Drop the database if it exists
IF EXISTS (
	SELECT name
	FROM sys.databases
	WHERE name = N'DbName'
)
DROP DATABASE DbName
GO

SELECT COLUMN_NAME AS 'ColumnName',
			 TABLE_NAME AS  'TableName',
			 TABLE_CATALOG,
			 TABLE_SCHEMA
FROM INFORMATION_SCHEMA.COLUMNS
WHERE COLUMN_NAME LIKE '%column_name%'


-- script to change DB name
ALTER DATABASE [OldDbName]
SET SINGLE_USER WITH ROLLBACK IMMEDIATE

ALTER DATABASE [OldDbName]
MODIFY NAME = NewDbName

ALTER DATABASE [NewDbName]
SET MULTI_USER WITH ROLLBACK IMMEDIATE
GO


-- delete last row (works if ID type is int)
DELETE FROM tableName
WHERE ID = (SELECT MAX(ID) FROM tableName)
GO

-- Добавить к текстовой переменной '%', чтобы его не пришлось вводить при вызове процедуры
SELECT @Name = RTRIM(@Name)	+ '%'; 
GO