
USE [LibraryManagement]
GO
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblReports_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblReports_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblReports_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblReports table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblReports_Get_List

AS


				
				SELECT
					[idx],
					[dep_id],
					[rep_name],
					[description],
					[procedure],
					[dep_code],
					[status],
					[checked]
				FROM
					[dbo].[tblReports]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblReports_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblReports_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblReports_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblReports table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblReports_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [idx] int 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([idx])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [idx]'
				SET @SQL = @SQL + ' FROM [dbo].[tblReports]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[idx], O.[dep_id], O.[rep_name], O.[description], O.[procedure], O.[dep_code], O.[status], O.[checked]
				FROM
				    [dbo].[tblReports] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[idx] = PageIndex.[idx]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblReports]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblReports_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblReports_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblReports_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblReports table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblReports_Insert
(

	@Idx int   ,

	@DepId int   ,

	@RepName nvarchar (255)  ,

	@Description nvarchar (255)  ,

	@Procedure nvarchar (40)  ,

	@DepCode nvarchar (1)  ,

	@Status bit   ,

	@SafeNameChecked bit   
)
AS


				
				INSERT INTO [dbo].[tblReports]
					(
					[idx]
					,[dep_id]
					,[rep_name]
					,[description]
					,[procedure]
					,[dep_code]
					,[status]
					,[checked]
					)
				VALUES
					(
					@Idx
					,@DepId
					,@RepName
					,@Description
					,@Procedure
					,@DepCode
					,@Status
					,@SafeNameChecked
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblReports_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblReports_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblReports_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblReports table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblReports_Update
(

	@Idx int   ,

	@OriginalIdx int   ,

	@DepId int   ,

	@RepName nvarchar (255)  ,

	@Description nvarchar (255)  ,

	@Procedure nvarchar (40)  ,

	@DepCode nvarchar (1)  ,

	@Status bit   ,

	@SafeNameChecked bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblReports]
				SET
					[idx] = @Idx
					,[dep_id] = @DepId
					,[rep_name] = @RepName
					,[description] = @Description
					,[procedure] = @Procedure
					,[dep_code] = @DepCode
					,[status] = @Status
					,[checked] = @SafeNameChecked
				WHERE
[idx] = @OriginalIdx 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblReports_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblReports_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblReports_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblReports table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblReports_Delete
(

	@Idx int   
)
AS


				DELETE FROM [dbo].[tblReports] WITH (ROWLOCK) 
				WHERE
					[idx] = @Idx
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblReports_GetByIdx procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblReports_GetByIdx') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblReports_GetByIdx
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblReports table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblReports_GetByIdx
(

	@Idx int   
)
AS


				SELECT
					[idx],
					[dep_id],
					[rep_name],
					[description],
					[procedure],
					[dep_code],
					[status],
					[checked]
				FROM
					[dbo].[tblReports]
				WHERE
					[idx] = @Idx
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblReports_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblReports_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblReports_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblReports table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblReports_Find
(

	@SearchUsingOR bit   = null ,

	@Idx int   = null ,

	@DepId int   = null ,

	@RepName nvarchar (255)  = null ,

	@Description nvarchar (255)  = null ,

	@Procedure nvarchar (40)  = null ,

	@DepCode nvarchar (1)  = null ,

	@Status bit   = null ,

	@SafeNameChecked bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [idx]
	, [dep_id]
	, [rep_name]
	, [description]
	, [procedure]
	, [dep_code]
	, [status]
	, [checked]
    FROM
	[dbo].[tblReports]
    WHERE 
	 ([idx] = @Idx OR @Idx IS NULL)
	AND ([dep_id] = @DepId OR @DepId IS NULL)
	AND ([rep_name] = @RepName OR @RepName IS NULL)
	AND ([description] = @Description OR @Description IS NULL)
	AND ([procedure] = @Procedure OR @Procedure IS NULL)
	AND ([dep_code] = @DepCode OR @DepCode IS NULL)
	AND ([status] = @Status OR @Status IS NULL)
	AND ([checked] = @SafeNameChecked OR @SafeNameChecked IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [idx]
	, [dep_id]
	, [rep_name]
	, [description]
	, [procedure]
	, [dep_code]
	, [status]
	, [checked]
    FROM
	[dbo].[tblReports]
    WHERE 
	 ([idx] = @Idx AND @Idx is not null)
	OR ([dep_id] = @DepId AND @DepId is not null)
	OR ([rep_name] = @RepName AND @RepName is not null)
	OR ([description] = @Description AND @Description is not null)
	OR ([procedure] = @Procedure AND @Procedure is not null)
	OR ([dep_code] = @DepCode AND @DepCode is not null)
	OR ([status] = @Status AND @Status is not null)
	OR ([checked] = @SafeNameChecked AND @SafeNameChecked is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAccount_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAccount_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAccount_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblAccount table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAccount_Get_List

AS


				
				SELECT
					[branch],
					[account_id],
					[abbreviat],
					[mof_gl],
					[cust_id],
					[name],
					[open_date],
					[prev_date],
					[last_date],
					[creamt],
					[debamt],
					[status]
				FROM
					[dbo].[tblAccount]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAccount_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAccount_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAccount_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblAccount table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAccount_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [branch] numeric(2, 0), [account_id] char(9)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([branch], [account_id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [branch], [account_id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblAccount]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[branch], O.[account_id], O.[abbreviat], O.[mof_gl], O.[cust_id], O.[name], O.[open_date], O.[prev_date], O.[last_date], O.[creamt], O.[debamt], O.[status]
				FROM
				    [dbo].[tblAccount] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[branch] = PageIndex.[branch]
					AND O.[account_id] = PageIndex.[account_id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblAccount]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAccount_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAccount_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAccount_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblAccount table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAccount_Insert
(

	@Branch numeric (2, 0)  ,

	@AccountId char (9)  ,

	@Abbreviat char (30)  ,

	@MofGl char (4)  ,

	@CustId char (5)  ,

	@Name nvarchar (200)  ,

	@OpenDate datetime   ,

	@PrevDate datetime   ,

	@LastDate datetime   ,

	@Creamt numeric (18, 2)  ,

	@Debamt numeric (18, 2)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblAccount]
					(
					[branch]
					,[account_id]
					,[abbreviat]
					,[mof_gl]
					,[cust_id]
					,[name]
					,[open_date]
					,[prev_date]
					,[last_date]
					,[creamt]
					,[debamt]
					,[status]
					)
				VALUES
					(
					@Branch
					,@AccountId
					,@Abbreviat
					,@MofGl
					,@CustId
					,@Name
					,@OpenDate
					,@PrevDate
					,@LastDate
					,@Creamt
					,@Debamt
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAccount_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAccount_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAccount_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblAccount table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAccount_Update
(

	@Branch numeric (2, 0)  ,

	@OriginalBranch numeric (2, 0)  ,

	@AccountId char (9)  ,

	@OriginalAccountId char (9)  ,

	@Abbreviat char (30)  ,

	@MofGl char (4)  ,

	@CustId char (5)  ,

	@Name nvarchar (200)  ,

	@OpenDate datetime   ,

	@PrevDate datetime   ,

	@LastDate datetime   ,

	@Creamt numeric (18, 2)  ,

	@Debamt numeric (18, 2)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblAccount]
				SET
					[branch] = @Branch
					,[account_id] = @AccountId
					,[abbreviat] = @Abbreviat
					,[mof_gl] = @MofGl
					,[cust_id] = @CustId
					,[name] = @Name
					,[open_date] = @OpenDate
					,[prev_date] = @PrevDate
					,[last_date] = @LastDate
					,[creamt] = @Creamt
					,[debamt] = @Debamt
					,[status] = @Status
				WHERE
[branch] = @OriginalBranch 
AND [account_id] = @OriginalAccountId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAccount_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAccount_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAccount_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblAccount table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAccount_Delete
(

	@Branch numeric (2, 0)  ,

	@AccountId char (9)  
)
AS


				DELETE FROM [dbo].[tblAccount] WITH (ROWLOCK) 
				WHERE
					[branch] = @Branch
					AND [account_id] = @AccountId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAccount_GetByBranchAccountId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAccount_GetByBranchAccountId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAccount_GetByBranchAccountId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblAccount table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAccount_GetByBranchAccountId
(

	@Branch numeric (2, 0)  ,

	@AccountId char (9)  
)
AS


				SELECT
					[branch],
					[account_id],
					[abbreviat],
					[mof_gl],
					[cust_id],
					[name],
					[open_date],
					[prev_date],
					[last_date],
					[creamt],
					[debamt],
					[status]
				FROM
					[dbo].[tblAccount]
				WHERE
					[branch] = @Branch
					AND [account_id] = @AccountId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAccount_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAccount_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAccount_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblAccount table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAccount_Find
(

	@SearchUsingOR bit   = null ,

	@Branch numeric (2, 0)  = null ,

	@AccountId char (9)  = null ,

	@Abbreviat char (30)  = null ,

	@MofGl char (4)  = null ,

	@CustId char (5)  = null ,

	@Name nvarchar (200)  = null ,

	@OpenDate datetime   = null ,

	@PrevDate datetime   = null ,

	@LastDate datetime   = null ,

	@Creamt numeric (18, 2)  = null ,

	@Debamt numeric (18, 2)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [branch]
	, [account_id]
	, [abbreviat]
	, [mof_gl]
	, [cust_id]
	, [name]
	, [open_date]
	, [prev_date]
	, [last_date]
	, [creamt]
	, [debamt]
	, [status]
    FROM
	[dbo].[tblAccount]
    WHERE 
	 ([branch] = @Branch OR @Branch IS NULL)
	AND ([account_id] = @AccountId OR @AccountId IS NULL)
	AND ([abbreviat] = @Abbreviat OR @Abbreviat IS NULL)
	AND ([mof_gl] = @MofGl OR @MofGl IS NULL)
	AND ([cust_id] = @CustId OR @CustId IS NULL)
	AND ([name] = @Name OR @Name IS NULL)
	AND ([open_date] = @OpenDate OR @OpenDate IS NULL)
	AND ([prev_date] = @PrevDate OR @PrevDate IS NULL)
	AND ([last_date] = @LastDate OR @LastDate IS NULL)
	AND ([creamt] = @Creamt OR @Creamt IS NULL)
	AND ([debamt] = @Debamt OR @Debamt IS NULL)
	AND ([status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [branch]
	, [account_id]
	, [abbreviat]
	, [mof_gl]
	, [cust_id]
	, [name]
	, [open_date]
	, [prev_date]
	, [last_date]
	, [creamt]
	, [debamt]
	, [status]
    FROM
	[dbo].[tblAccount]
    WHERE 
	 ([branch] = @Branch AND @Branch is not null)
	OR ([account_id] = @AccountId AND @AccountId is not null)
	OR ([abbreviat] = @Abbreviat AND @Abbreviat is not null)
	OR ([mof_gl] = @MofGl AND @MofGl is not null)
	OR ([cust_id] = @CustId AND @CustId is not null)
	OR ([name] = @Name AND @Name is not null)
	OR ([open_date] = @OpenDate AND @OpenDate is not null)
	OR ([prev_date] = @PrevDate AND @PrevDate is not null)
	OR ([last_date] = @LastDate AND @LastDate is not null)
	OR ([creamt] = @Creamt AND @Creamt is not null)
	OR ([debamt] = @Debamt AND @Debamt is not null)
	OR ([status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStaff_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStaff_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStaff_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblStaff table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStaff_Get_List

AS


				
				SELECT
					[ID],
					[Name],
					[Depart],
					[Open_date],
					[SalaryLevel],
					[address],
					[phone],
					[PersonID],
					[PersonIDdate],
					[Location],
					[contactPerson],
					[remark],
					[labelsprn],
					[status]
				FROM
					[dbo].[tblStaff]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStaff_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStaff_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStaff_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblStaff table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStaff_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [ID] nchar(7)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([ID])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [ID]'
				SET @SQL = @SQL + ' FROM [dbo].[tblStaff]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[ID], O.[Name], O.[Depart], O.[Open_date], O.[SalaryLevel], O.[address], O.[phone], O.[PersonID], O.[PersonIDdate], O.[Location], O.[contactPerson], O.[remark], O.[labelsprn], O.[status]
				FROM
				    [dbo].[tblStaff] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[ID] = PageIndex.[ID]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblStaff]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStaff_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStaff_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStaff_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblStaff table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStaff_Insert
(

	@Id nchar (7)  ,

	@Name nvarchar (50)  ,

	@Depart nchar (2)  ,

	@OpenDate datetime   ,

	@SalaryLevel decimal (18, 0)  ,

	@Address nvarchar (200)  ,

	@Phone nchar (30)  ,

	@PersonId nchar (10)  ,

	@PersonIddate datetime   ,

	@Location nvarchar (50)  ,

	@ContactPerson nvarchar (100)  ,

	@Remark nvarchar (200)  ,

	@Labelsprn nchar (15)  ,

	@Status int   
)
AS


				
				INSERT INTO [dbo].[tblStaff]
					(
					[ID]
					,[Name]
					,[Depart]
					,[Open_date]
					,[SalaryLevel]
					,[address]
					,[phone]
					,[PersonID]
					,[PersonIDdate]
					,[Location]
					,[contactPerson]
					,[remark]
					,[labelsprn]
					,[status]
					)
				VALUES
					(
					@Id
					,@Name
					,@Depart
					,@OpenDate
					,@SalaryLevel
					,@Address
					,@Phone
					,@PersonId
					,@PersonIddate
					,@Location
					,@ContactPerson
					,@Remark
					,@Labelsprn
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStaff_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStaff_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStaff_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblStaff table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStaff_Update
(

	@Id nchar (7)  ,

	@OriginalId nchar (7)  ,

	@Name nvarchar (50)  ,

	@Depart nchar (2)  ,

	@OpenDate datetime   ,

	@SalaryLevel decimal (18, 0)  ,

	@Address nvarchar (200)  ,

	@Phone nchar (30)  ,

	@PersonId nchar (10)  ,

	@PersonIddate datetime   ,

	@Location nvarchar (50)  ,

	@ContactPerson nvarchar (100)  ,

	@Remark nvarchar (200)  ,

	@Labelsprn nchar (15)  ,

	@Status int   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblStaff]
				SET
					[ID] = @Id
					,[Name] = @Name
					,[Depart] = @Depart
					,[Open_date] = @OpenDate
					,[SalaryLevel] = @SalaryLevel
					,[address] = @Address
					,[phone] = @Phone
					,[PersonID] = @PersonId
					,[PersonIDdate] = @PersonIddate
					,[Location] = @Location
					,[contactPerson] = @ContactPerson
					,[remark] = @Remark
					,[labelsprn] = @Labelsprn
					,[status] = @Status
				WHERE
[ID] = @OriginalId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStaff_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStaff_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStaff_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblStaff table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStaff_Delete
(

	@Id nchar (7)  
)
AS


				DELETE FROM [dbo].[tblStaff] WITH (ROWLOCK) 
				WHERE
					[ID] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStaff_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStaff_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStaff_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblStaff table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStaff_GetById
(

	@Id nchar (7)  
)
AS


				SELECT
					[ID],
					[Name],
					[Depart],
					[Open_date],
					[SalaryLevel],
					[address],
					[phone],
					[PersonID],
					[PersonIDdate],
					[Location],
					[contactPerson],
					[remark],
					[labelsprn],
					[status]
				FROM
					[dbo].[tblStaff]
				WHERE
					[ID] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStaff_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStaff_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStaff_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblStaff table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStaff_Find
(

	@SearchUsingOR bit   = null ,

	@Id nchar (7)  = null ,

	@Name nvarchar (50)  = null ,

	@Depart nchar (2)  = null ,

	@OpenDate datetime   = null ,

	@SalaryLevel decimal (18, 0)  = null ,

	@Address nvarchar (200)  = null ,

	@Phone nchar (30)  = null ,

	@PersonId nchar (10)  = null ,

	@PersonIddate datetime   = null ,

	@Location nvarchar (50)  = null ,

	@ContactPerson nvarchar (100)  = null ,

	@Remark nvarchar (200)  = null ,

	@Labelsprn nchar (15)  = null ,

	@Status int   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [ID]
	, [Name]
	, [Depart]
	, [Open_date]
	, [SalaryLevel]
	, [address]
	, [phone]
	, [PersonID]
	, [PersonIDdate]
	, [Location]
	, [contactPerson]
	, [remark]
	, [labelsprn]
	, [status]
    FROM
	[dbo].[tblStaff]
    WHERE 
	 ([ID] = @Id OR @Id IS NULL)
	AND ([Name] = @Name OR @Name IS NULL)
	AND ([Depart] = @Depart OR @Depart IS NULL)
	AND ([Open_date] = @OpenDate OR @OpenDate IS NULL)
	AND ([SalaryLevel] = @SalaryLevel OR @SalaryLevel IS NULL)
	AND ([address] = @Address OR @Address IS NULL)
	AND ([phone] = @Phone OR @Phone IS NULL)
	AND ([PersonID] = @PersonId OR @PersonId IS NULL)
	AND ([PersonIDdate] = @PersonIddate OR @PersonIddate IS NULL)
	AND ([Location] = @Location OR @Location IS NULL)
	AND ([contactPerson] = @ContactPerson OR @ContactPerson IS NULL)
	AND ([remark] = @Remark OR @Remark IS NULL)
	AND ([labelsprn] = @Labelsprn OR @Labelsprn IS NULL)
	AND ([status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [ID]
	, [Name]
	, [Depart]
	, [Open_date]
	, [SalaryLevel]
	, [address]
	, [phone]
	, [PersonID]
	, [PersonIDdate]
	, [Location]
	, [contactPerson]
	, [remark]
	, [labelsprn]
	, [status]
    FROM
	[dbo].[tblStaff]
    WHERE 
	 ([ID] = @Id AND @Id is not null)
	OR ([Name] = @Name AND @Name is not null)
	OR ([Depart] = @Depart AND @Depart is not null)
	OR ([Open_date] = @OpenDate AND @OpenDate is not null)
	OR ([SalaryLevel] = @SalaryLevel AND @SalaryLevel is not null)
	OR ([address] = @Address AND @Address is not null)
	OR ([phone] = @Phone AND @Phone is not null)
	OR ([PersonID] = @PersonId AND @PersonId is not null)
	OR ([PersonIDdate] = @PersonIddate AND @PersonIddate is not null)
	OR ([Location] = @Location AND @Location is not null)
	OR ([contactPerson] = @ContactPerson AND @ContactPerson is not null)
	OR ([remark] = @Remark AND @Remark is not null)
	OR ([labelsprn] = @Labelsprn AND @Labelsprn is not null)
	OR ([status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblPrice_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblPrice_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblPrice_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblPrice table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblPrice_Get_List

AS


				
				SELECT
					[goods_id],
					[rtprice],
					[averimppr],
					[lastimppr],
					[wsprice],
					[prefprice],
					[discpercent],
					[disc_frdate],
					[disc_todate]
				FROM
					[dbo].[tblPrice]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblPrice_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblPrice_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblPrice_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblPrice table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblPrice_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [goods_id] char(6)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([goods_id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [goods_id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblPrice]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[goods_id], O.[rtprice], O.[averimppr], O.[lastimppr], O.[wsprice], O.[prefprice], O.[discpercent], O.[disc_frdate], O.[disc_todate]
				FROM
				    [dbo].[tblPrice] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[goods_id] = PageIndex.[goods_id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblPrice]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblPrice_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblPrice_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblPrice_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblPrice table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblPrice_Insert
(

	@GoodsId char (6)  ,

	@Rtprice numeric (18, 2)  ,

	@Averimppr numeric (18, 2)  ,

	@Lastimppr numeric (18, 2)  ,

	@Wsprice numeric (18, 2)  ,

	@Prefprice numeric (18, 2)  ,

	@Discpercent numeric (18, 2)  ,

	@DiscFrdate datetime   ,

	@DiscTodate datetime   
)
AS


				
				INSERT INTO [dbo].[tblPrice]
					(
					[goods_id]
					,[rtprice]
					,[averimppr]
					,[lastimppr]
					,[wsprice]
					,[prefprice]
					,[discpercent]
					,[disc_frdate]
					,[disc_todate]
					)
				VALUES
					(
					@GoodsId
					,@Rtprice
					,@Averimppr
					,@Lastimppr
					,@Wsprice
					,@Prefprice
					,@Discpercent
					,@DiscFrdate
					,@DiscTodate
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblPrice_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblPrice_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblPrice_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblPrice table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblPrice_Update
(

	@GoodsId char (6)  ,

	@OriginalGoodsId char (6)  ,

	@Rtprice numeric (18, 2)  ,

	@Averimppr numeric (18, 2)  ,

	@Lastimppr numeric (18, 2)  ,

	@Wsprice numeric (18, 2)  ,

	@Prefprice numeric (18, 2)  ,

	@Discpercent numeric (18, 2)  ,

	@DiscFrdate datetime   ,

	@DiscTodate datetime   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblPrice]
				SET
					[goods_id] = @GoodsId
					,[rtprice] = @Rtprice
					,[averimppr] = @Averimppr
					,[lastimppr] = @Lastimppr
					,[wsprice] = @Wsprice
					,[prefprice] = @Prefprice
					,[discpercent] = @Discpercent
					,[disc_frdate] = @DiscFrdate
					,[disc_todate] = @DiscTodate
				WHERE
[goods_id] = @OriginalGoodsId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblPrice_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblPrice_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblPrice_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblPrice table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblPrice_Delete
(

	@GoodsId char (6)  
)
AS


				DELETE FROM [dbo].[tblPrice] WITH (ROWLOCK) 
				WHERE
					[goods_id] = @GoodsId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblPrice_GetByGoodsId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblPrice_GetByGoodsId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblPrice_GetByGoodsId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblPrice table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblPrice_GetByGoodsId
(

	@GoodsId char (6)  
)
AS


				SELECT
					[goods_id],
					[rtprice],
					[averimppr],
					[lastimppr],
					[wsprice],
					[prefprice],
					[discpercent],
					[disc_frdate],
					[disc_todate]
				FROM
					[dbo].[tblPrice]
				WHERE
					[goods_id] = @GoodsId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblPrice_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblPrice_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblPrice_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblPrice table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblPrice_Find
(

	@SearchUsingOR bit   = null ,

	@GoodsId char (6)  = null ,

	@Rtprice numeric (18, 2)  = null ,

	@Averimppr numeric (18, 2)  = null ,

	@Lastimppr numeric (18, 2)  = null ,

	@Wsprice numeric (18, 2)  = null ,

	@Prefprice numeric (18, 2)  = null ,

	@Discpercent numeric (18, 2)  = null ,

	@DiscFrdate datetime   = null ,

	@DiscTodate datetime   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [goods_id]
	, [rtprice]
	, [averimppr]
	, [lastimppr]
	, [wsprice]
	, [prefprice]
	, [discpercent]
	, [disc_frdate]
	, [disc_todate]
    FROM
	[dbo].[tblPrice]
    WHERE 
	 ([goods_id] = @GoodsId OR @GoodsId IS NULL)
	AND ([rtprice] = @Rtprice OR @Rtprice IS NULL)
	AND ([averimppr] = @Averimppr OR @Averimppr IS NULL)
	AND ([lastimppr] = @Lastimppr OR @Lastimppr IS NULL)
	AND ([wsprice] = @Wsprice OR @Wsprice IS NULL)
	AND ([prefprice] = @Prefprice OR @Prefprice IS NULL)
	AND ([discpercent] = @Discpercent OR @Discpercent IS NULL)
	AND ([disc_frdate] = @DiscFrdate OR @DiscFrdate IS NULL)
	AND ([disc_todate] = @DiscTodate OR @DiscTodate IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [goods_id]
	, [rtprice]
	, [averimppr]
	, [lastimppr]
	, [wsprice]
	, [prefprice]
	, [discpercent]
	, [disc_frdate]
	, [disc_todate]
    FROM
	[dbo].[tblPrice]
    WHERE 
	 ([goods_id] = @GoodsId AND @GoodsId is not null)
	OR ([rtprice] = @Rtprice AND @Rtprice is not null)
	OR ([averimppr] = @Averimppr AND @Averimppr is not null)
	OR ([lastimppr] = @Lastimppr AND @Lastimppr is not null)
	OR ([wsprice] = @Wsprice AND @Wsprice is not null)
	OR ([prefprice] = @Prefprice AND @Prefprice is not null)
	OR ([discpercent] = @Discpercent AND @Discpercent is not null)
	OR ([disc_frdate] = @DiscFrdate AND @DiscFrdate is not null)
	OR ([disc_todate] = @DiscTodate AND @DiscTodate is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStations_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStations_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStations_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblStations table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStations_Get_List

AS


				
				SELECT
					[id],
					[name],
					[Description],
					[login],
					[user_id],
					[pos_id],
					[prnport],
					[ipaddress],
					[message],
					[serialkey],
					[Status]
				FROM
					[dbo].[tblStations]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStations_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStations_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStations_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblStations table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStations_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] int 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblStations]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[name], O.[Description], O.[login], O.[user_id], O.[pos_id], O.[prnport], O.[ipaddress], O.[message], O.[serialkey], O.[Status]
				FROM
				    [dbo].[tblStations] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblStations]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStations_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStations_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStations_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblStations table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStations_Insert
(

	@Id int   ,

	@Name nvarchar (20)  ,

	@Description nvarchar (100)  ,

	@Login int   ,

	@UserId int   ,

	@PosId char (5)  ,

	@Prnport int   ,

	@Ipaddress nchar (100)  ,

	@Message bit   ,

	@Serialkey nchar (50)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblStations]
					(
					[id]
					,[name]
					,[Description]
					,[login]
					,[user_id]
					,[pos_id]
					,[prnport]
					,[ipaddress]
					,[message]
					,[serialkey]
					,[Status]
					)
				VALUES
					(
					@Id
					,@Name
					,@Description
					,@Login
					,@UserId
					,@PosId
					,@Prnport
					,@Ipaddress
					,@Message
					,@Serialkey
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStations_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStations_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStations_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblStations table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStations_Update
(

	@Id int   ,

	@OriginalId int   ,

	@Name nvarchar (20)  ,

	@Description nvarchar (100)  ,

	@Login int   ,

	@UserId int   ,

	@PosId char (5)  ,

	@Prnport int   ,

	@Ipaddress nchar (100)  ,

	@Message bit   ,

	@Serialkey nchar (50)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblStations]
				SET
					[id] = @Id
					,[name] = @Name
					,[Description] = @Description
					,[login] = @Login
					,[user_id] = @UserId
					,[pos_id] = @PosId
					,[prnport] = @Prnport
					,[ipaddress] = @Ipaddress
					,[message] = @Message
					,[serialkey] = @Serialkey
					,[Status] = @Status
				WHERE
[id] = @OriginalId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStations_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStations_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStations_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblStations table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStations_Delete
(

	@Id int   
)
AS


				DELETE FROM [dbo].[tblStations] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStations_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStations_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStations_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblStations table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStations_GetById
(

	@Id int   
)
AS


				SELECT
					[id],
					[name],
					[Description],
					[login],
					[user_id],
					[pos_id],
					[prnport],
					[ipaddress],
					[message],
					[serialkey],
					[Status]
				FROM
					[dbo].[tblStations]
				WHERE
					[id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStations_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStations_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStations_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblStations table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStations_Find
(

	@SearchUsingOR bit   = null ,

	@Id int   = null ,

	@Name nvarchar (20)  = null ,

	@Description nvarchar (100)  = null ,

	@Login int   = null ,

	@UserId int   = null ,

	@PosId char (5)  = null ,

	@Prnport int   = null ,

	@Ipaddress nchar (100)  = null ,

	@Message bit   = null ,

	@Serialkey nchar (50)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [name]
	, [Description]
	, [login]
	, [user_id]
	, [pos_id]
	, [prnport]
	, [ipaddress]
	, [message]
	, [serialkey]
	, [Status]
    FROM
	[dbo].[tblStations]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([name] = @Name OR @Name IS NULL)
	AND ([Description] = @Description OR @Description IS NULL)
	AND ([login] = @Login OR @Login IS NULL)
	AND ([user_id] = @UserId OR @UserId IS NULL)
	AND ([pos_id] = @PosId OR @PosId IS NULL)
	AND ([prnport] = @Prnport OR @Prnport IS NULL)
	AND ([ipaddress] = @Ipaddress OR @Ipaddress IS NULL)
	AND ([message] = @Message OR @Message IS NULL)
	AND ([serialkey] = @Serialkey OR @Serialkey IS NULL)
	AND ([Status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [name]
	, [Description]
	, [login]
	, [user_id]
	, [pos_id]
	, [prnport]
	, [ipaddress]
	, [message]
	, [serialkey]
	, [Status]
    FROM
	[dbo].[tblStations]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([name] = @Name AND @Name is not null)
	OR ([Description] = @Description AND @Description is not null)
	OR ([login] = @Login AND @Login is not null)
	OR ([user_id] = @UserId AND @UserId is not null)
	OR ([pos_id] = @PosId AND @PosId is not null)
	OR ([prnport] = @Prnport AND @Prnport is not null)
	OR ([ipaddress] = @Ipaddress AND @Ipaddress is not null)
	OR ([message] = @Message AND @Message is not null)
	OR ([serialkey] = @Serialkey AND @Serialkey is not null)
	OR ([Status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMof_sys_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMof_sys_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMof_sys_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblMof_sys table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMof_sys_Get_List

AS


				
				SELECT
					[id],
					[mof_gl],
					[mof_name],
					[mof_nameb],
					[ac_type],
					[negative],
					[master],
					[glevel],
					[last_level],
					[other_equi]
				FROM
					[dbo].[tblMof_sys]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMof_sys_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMof_sys_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMof_sys_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblMof_sys table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMof_sys_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] numeric(18, 0) 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblMof_sys]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[mof_gl], O.[mof_name], O.[mof_nameb], O.[ac_type], O.[negative], O.[master], O.[glevel], O.[last_level], O.[other_equi]
				FROM
				    [dbo].[tblMof_sys] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblMof_sys]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMof_sys_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMof_sys_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMof_sys_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblMof_sys table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMof_sys_Insert
(

	@Id numeric (18, 0)   OUTPUT,

	@MofGl char (4)  ,

	@MofName nvarchar (255)  ,

	@MofNameb varchar (200)  ,

	@AcType char (1)  ,

	@Negative char (1)  ,

	@Master bit   ,

	@Glevel int   ,

	@LastLevel bit   ,

	@OtherEqui nvarchar (255)  
)
AS


				
				INSERT INTO [dbo].[tblMof_sys]
					(
					[mof_gl]
					,[mof_name]
					,[mof_nameb]
					,[ac_type]
					,[negative]
					,[master]
					,[glevel]
					,[last_level]
					,[other_equi]
					)
				VALUES
					(
					@MofGl
					,@MofName
					,@MofNameb
					,@AcType
					,@Negative
					,@Master
					,@Glevel
					,@LastLevel
					,@OtherEqui
					)
				-- Get the identity value
				SET @Id = SCOPE_IDENTITY()
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMof_sys_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMof_sys_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMof_sys_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblMof_sys table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMof_sys_Update
(

	@Id numeric (18, 0)  ,

	@MofGl char (4)  ,

	@MofName nvarchar (255)  ,

	@MofNameb varchar (200)  ,

	@AcType char (1)  ,

	@Negative char (1)  ,

	@Master bit   ,

	@Glevel int   ,

	@LastLevel bit   ,

	@OtherEqui nvarchar (255)  
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblMof_sys]
				SET
					[mof_gl] = @MofGl
					,[mof_name] = @MofName
					,[mof_nameb] = @MofNameb
					,[ac_type] = @AcType
					,[negative] = @Negative
					,[master] = @Master
					,[glevel] = @Glevel
					,[last_level] = @LastLevel
					,[other_equi] = @OtherEqui
				WHERE
[id] = @Id 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMof_sys_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMof_sys_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMof_sys_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblMof_sys table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMof_sys_Delete
(

	@Id numeric (18, 0)  
)
AS


				DELETE FROM [dbo].[tblMof_sys] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMof_sys_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMof_sys_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMof_sys_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblMof_sys table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMof_sys_GetById
(

	@Id numeric (18, 0)  
)
AS


				SELECT
					[id],
					[mof_gl],
					[mof_name],
					[mof_nameb],
					[ac_type],
					[negative],
					[master],
					[glevel],
					[last_level],
					[other_equi]
				FROM
					[dbo].[tblMof_sys]
				WHERE
					[id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMof_sys_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMof_sys_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMof_sys_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblMof_sys table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMof_sys_Find
(

	@SearchUsingOR bit   = null ,

	@Id numeric (18, 0)  = null ,

	@MofGl char (4)  = null ,

	@MofName nvarchar (255)  = null ,

	@MofNameb varchar (200)  = null ,

	@AcType char (1)  = null ,

	@Negative char (1)  = null ,

	@Master bit   = null ,

	@Glevel int   = null ,

	@LastLevel bit   = null ,

	@OtherEqui nvarchar (255)  = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [mof_gl]
	, [mof_name]
	, [mof_nameb]
	, [ac_type]
	, [negative]
	, [master]
	, [glevel]
	, [last_level]
	, [other_equi]
    FROM
	[dbo].[tblMof_sys]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([mof_gl] = @MofGl OR @MofGl IS NULL)
	AND ([mof_name] = @MofName OR @MofName IS NULL)
	AND ([mof_nameb] = @MofNameb OR @MofNameb IS NULL)
	AND ([ac_type] = @AcType OR @AcType IS NULL)
	AND ([negative] = @Negative OR @Negative IS NULL)
	AND ([master] = @Master OR @Master IS NULL)
	AND ([glevel] = @Glevel OR @Glevel IS NULL)
	AND ([last_level] = @LastLevel OR @LastLevel IS NULL)
	AND ([other_equi] = @OtherEqui OR @OtherEqui IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [mof_gl]
	, [mof_name]
	, [mof_nameb]
	, [ac_type]
	, [negative]
	, [master]
	, [glevel]
	, [last_level]
	, [other_equi]
    FROM
	[dbo].[tblMof_sys]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([mof_gl] = @MofGl AND @MofGl is not null)
	OR ([mof_name] = @MofName AND @MofName is not null)
	OR ([mof_nameb] = @MofNameb AND @MofNameb is not null)
	OR ([ac_type] = @AcType AND @AcType is not null)
	OR ([negative] = @Negative AND @Negative is not null)
	OR ([master] = @Master AND @Master is not null)
	OR ([glevel] = @Glevel AND @Glevel is not null)
	OR ([last_level] = @LastLevel AND @LastLevel is not null)
	OR ([other_equi] = @OtherEqui AND @OtherEqui is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblPaymentOrder_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblPaymentOrder_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblPaymentOrder_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblPaymentOrder table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblPaymentOrder_Get_List

AS


				
				SELECT
					[trans_num],
					[payer],
					[payer_acc],
					[payer_bank],
					[payer_branch],
					[benef],
					[benef_acc],
					[benef_bank],
					[benef_branch],
					[amount]
				FROM
					[dbo].[tblPaymentOrder]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblPaymentOrder_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblPaymentOrder_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblPaymentOrder_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblPaymentOrder table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblPaymentOrder_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [trans_num] nchar(12)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([trans_num])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [trans_num]'
				SET @SQL = @SQL + ' FROM [dbo].[tblPaymentOrder]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[trans_num], O.[payer], O.[payer_acc], O.[payer_bank], O.[payer_branch], O.[benef], O.[benef_acc], O.[benef_bank], O.[benef_branch], O.[amount]
				FROM
				    [dbo].[tblPaymentOrder] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[trans_num] = PageIndex.[trans_num]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblPaymentOrder]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblPaymentOrder_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblPaymentOrder_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblPaymentOrder_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblPaymentOrder table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblPaymentOrder_Insert
(

	@TransNum nchar (12)  ,

	@Payer nvarchar (200)  ,

	@PayerAcc nvarchar (20)  ,

	@PayerBank nvarchar (200)  ,

	@PayerBranch nvarchar (255)  ,

	@Benef nvarchar (200)  ,

	@BenefAcc nvarchar (20)  ,

	@BenefBank nvarchar (200)  ,

	@BenefBranch nvarchar (200)  ,

	@Amount numeric (18, 2)  
)
AS


				
				INSERT INTO [dbo].[tblPaymentOrder]
					(
					[trans_num]
					,[payer]
					,[payer_acc]
					,[payer_bank]
					,[payer_branch]
					,[benef]
					,[benef_acc]
					,[benef_bank]
					,[benef_branch]
					,[amount]
					)
				VALUES
					(
					@TransNum
					,@Payer
					,@PayerAcc
					,@PayerBank
					,@PayerBranch
					,@Benef
					,@BenefAcc
					,@BenefBank
					,@BenefBranch
					,@Amount
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblPaymentOrder_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblPaymentOrder_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblPaymentOrder_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblPaymentOrder table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblPaymentOrder_Update
(

	@TransNum nchar (12)  ,

	@OriginalTransNum nchar (12)  ,

	@Payer nvarchar (200)  ,

	@PayerAcc nvarchar (20)  ,

	@PayerBank nvarchar (200)  ,

	@PayerBranch nvarchar (255)  ,

	@Benef nvarchar (200)  ,

	@BenefAcc nvarchar (20)  ,

	@BenefBank nvarchar (200)  ,

	@BenefBranch nvarchar (200)  ,

	@Amount numeric (18, 2)  
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblPaymentOrder]
				SET
					[trans_num] = @TransNum
					,[payer] = @Payer
					,[payer_acc] = @PayerAcc
					,[payer_bank] = @PayerBank
					,[payer_branch] = @PayerBranch
					,[benef] = @Benef
					,[benef_acc] = @BenefAcc
					,[benef_bank] = @BenefBank
					,[benef_branch] = @BenefBranch
					,[amount] = @Amount
				WHERE
[trans_num] = @OriginalTransNum 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblPaymentOrder_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblPaymentOrder_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblPaymentOrder_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblPaymentOrder table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblPaymentOrder_Delete
(

	@TransNum nchar (12)  
)
AS


				DELETE FROM [dbo].[tblPaymentOrder] WITH (ROWLOCK) 
				WHERE
					[trans_num] = @TransNum
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblPaymentOrder_GetByTransNum procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblPaymentOrder_GetByTransNum') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblPaymentOrder_GetByTransNum
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblPaymentOrder table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblPaymentOrder_GetByTransNum
(

	@TransNum nchar (12)  
)
AS


				SELECT
					[trans_num],
					[payer],
					[payer_acc],
					[payer_bank],
					[payer_branch],
					[benef],
					[benef_acc],
					[benef_bank],
					[benef_branch],
					[amount]
				FROM
					[dbo].[tblPaymentOrder]
				WHERE
					[trans_num] = @TransNum
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblPaymentOrder_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblPaymentOrder_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblPaymentOrder_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblPaymentOrder table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblPaymentOrder_Find
(

	@SearchUsingOR bit   = null ,

	@TransNum nchar (12)  = null ,

	@Payer nvarchar (200)  = null ,

	@PayerAcc nvarchar (20)  = null ,

	@PayerBank nvarchar (200)  = null ,

	@PayerBranch nvarchar (255)  = null ,

	@Benef nvarchar (200)  = null ,

	@BenefAcc nvarchar (20)  = null ,

	@BenefBank nvarchar (200)  = null ,

	@BenefBranch nvarchar (200)  = null ,

	@Amount numeric (18, 2)  = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [trans_num]
	, [payer]
	, [payer_acc]
	, [payer_bank]
	, [payer_branch]
	, [benef]
	, [benef_acc]
	, [benef_bank]
	, [benef_branch]
	, [amount]
    FROM
	[dbo].[tblPaymentOrder]
    WHERE 
	 ([trans_num] = @TransNum OR @TransNum IS NULL)
	AND ([payer] = @Payer OR @Payer IS NULL)
	AND ([payer_acc] = @PayerAcc OR @PayerAcc IS NULL)
	AND ([payer_bank] = @PayerBank OR @PayerBank IS NULL)
	AND ([payer_branch] = @PayerBranch OR @PayerBranch IS NULL)
	AND ([benef] = @Benef OR @Benef IS NULL)
	AND ([benef_acc] = @BenefAcc OR @BenefAcc IS NULL)
	AND ([benef_bank] = @BenefBank OR @BenefBank IS NULL)
	AND ([benef_branch] = @BenefBranch OR @BenefBranch IS NULL)
	AND ([amount] = @Amount OR @Amount IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [trans_num]
	, [payer]
	, [payer_acc]
	, [payer_bank]
	, [payer_branch]
	, [benef]
	, [benef_acc]
	, [benef_bank]
	, [benef_branch]
	, [amount]
    FROM
	[dbo].[tblPaymentOrder]
    WHERE 
	 ([trans_num] = @TransNum AND @TransNum is not null)
	OR ([payer] = @Payer AND @Payer is not null)
	OR ([payer_acc] = @PayerAcc AND @PayerAcc is not null)
	OR ([payer_bank] = @PayerBank AND @PayerBank is not null)
	OR ([payer_branch] = @PayerBranch AND @PayerBranch is not null)
	OR ([benef] = @Benef AND @Benef is not null)
	OR ([benef_acc] = @BenefAcc AND @BenefAcc is not null)
	OR ([benef_bank] = @BenefBank AND @BenefBank is not null)
	OR ([benef_branch] = @BenefBranch AND @BenefBranch is not null)
	OR ([amount] = @Amount AND @Amount is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblNon_Plu_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblNon_Plu_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblNon_Plu_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblNon_Plu table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblNon_Plu_Get_List

AS


				
				SELECT
					[nplu_code],
					[goods_id]
				FROM
					[dbo].[tblNon_Plu]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblNon_Plu_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblNon_Plu_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblNon_Plu_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblNon_Plu table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblNon_Plu_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [nplu_code] char(4) , [goods_id] nchar(6)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([nplu_code], [goods_id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [nplu_code], [goods_id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblNon_Plu]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[nplu_code], O.[goods_id]
				FROM
				    [dbo].[tblNon_Plu] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[nplu_code] = PageIndex.[nplu_code]
					AND O.[goods_id] = PageIndex.[goods_id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblNon_Plu]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblNon_Plu_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblNon_Plu_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblNon_Plu_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblNon_Plu table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblNon_Plu_Insert
(

	@NpluCode char (4)  ,

	@GoodsId nchar (6)  
)
AS


				
				INSERT INTO [dbo].[tblNon_Plu]
					(
					[nplu_code]
					,[goods_id]
					)
				VALUES
					(
					@NpluCode
					,@GoodsId
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblNon_Plu_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblNon_Plu_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblNon_Plu_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblNon_Plu table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblNon_Plu_Update
(

	@NpluCode char (4)  ,

	@OriginalNpluCode char (4)  ,

	@GoodsId nchar (6)  ,

	@OriginalGoodsId nchar (6)  
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblNon_Plu]
				SET
					[nplu_code] = @NpluCode
					,[goods_id] = @GoodsId
				WHERE
[nplu_code] = @OriginalNpluCode 
AND [goods_id] = @OriginalGoodsId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblNon_Plu_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblNon_Plu_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblNon_Plu_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblNon_Plu table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblNon_Plu_Delete
(

	@NpluCode char (4)  ,

	@GoodsId nchar (6)  
)
AS


				DELETE FROM [dbo].[tblNon_Plu] WITH (ROWLOCK) 
				WHERE
					[nplu_code] = @NpluCode
					AND [goods_id] = @GoodsId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblNon_Plu_GetByNpluCodeGoodsId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblNon_Plu_GetByNpluCodeGoodsId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblNon_Plu_GetByNpluCodeGoodsId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblNon_Plu table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblNon_Plu_GetByNpluCodeGoodsId
(

	@NpluCode char (4)  ,

	@GoodsId nchar (6)  
)
AS


				SELECT
					[nplu_code],
					[goods_id]
				FROM
					[dbo].[tblNon_Plu]
				WHERE
					[nplu_code] = @NpluCode
					AND [goods_id] = @GoodsId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblNon_Plu_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblNon_Plu_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblNon_Plu_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblNon_Plu table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblNon_Plu_Find
(

	@SearchUsingOR bit   = null ,

	@NpluCode char (4)  = null ,

	@GoodsId nchar (6)  = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [nplu_code]
	, [goods_id]
    FROM
	[dbo].[tblNon_Plu]
    WHERE 
	 ([nplu_code] = @NpluCode OR @NpluCode IS NULL)
	AND ([goods_id] = @GoodsId OR @GoodsId IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [nplu_code]
	, [goods_id]
    FROM
	[dbo].[tblNon_Plu]
    WHERE 
	 ([nplu_code] = @NpluCode AND @NpluCode is not null)
	OR ([goods_id] = @GoodsId AND @GoodsId is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStockInfo_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStockInfo_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStockInfo_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblStockInfo table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStockInfo_Get_List

AS


				
				SELECT
					[id],
					[goods_id],
					[open_date],
					[last_date],
					[minus_date],
					[stktake_dt],
					[stktake_tm],
					[begin_qty],
					[exp_qty],
					[imp_qty],
					[begin_amt],
					[exp_amt],
					[imp_amt],
					[averimppr]
				FROM
					[dbo].[tblStockInfo]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStockInfo_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStockInfo_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStockInfo_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblStockInfo table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStockInfo_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] char(5) , [goods_id] char(6)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id], [goods_id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id], [goods_id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblStockInfo]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[goods_id], O.[open_date], O.[last_date], O.[minus_date], O.[stktake_dt], O.[stktake_tm], O.[begin_qty], O.[exp_qty], O.[imp_qty], O.[begin_amt], O.[exp_amt], O.[imp_amt], O.[averimppr]
				FROM
				    [dbo].[tblStockInfo] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
					AND O.[goods_id] = PageIndex.[goods_id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblStockInfo]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStockInfo_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStockInfo_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStockInfo_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblStockInfo table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStockInfo_Insert
(

	@Id char (5)  ,

	@GoodsId char (6)  ,

	@OpenDate datetime   ,

	@LastDate datetime   ,

	@MinusDate datetime   ,

	@StktakeDt datetime   ,

	@StktakeTm nchar (10)  ,

	@BeginQty decimal (18, 2)  ,

	@ExpQty decimal (18, 2)  ,

	@ImpQty decimal (18, 2)  ,

	@BeginAmt decimal (18, 2)  ,

	@ExpAmt decimal (18, 2)  ,

	@ImpAmt decimal (18, 2)  ,

	@Averimppr decimal (18, 2)  
)
AS


				
				INSERT INTO [dbo].[tblStockInfo]
					(
					[id]
					,[goods_id]
					,[open_date]
					,[last_date]
					,[minus_date]
					,[stktake_dt]
					,[stktake_tm]
					,[begin_qty]
					,[exp_qty]
					,[imp_qty]
					,[begin_amt]
					,[exp_amt]
					,[imp_amt]
					,[averimppr]
					)
				VALUES
					(
					@Id
					,@GoodsId
					,@OpenDate
					,@LastDate
					,@MinusDate
					,@StktakeDt
					,@StktakeTm
					,@BeginQty
					,@ExpQty
					,@ImpQty
					,@BeginAmt
					,@ExpAmt
					,@ImpAmt
					,@Averimppr
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStockInfo_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStockInfo_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStockInfo_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblStockInfo table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStockInfo_Update
(

	@Id char (5)  ,

	@OriginalId char (5)  ,

	@GoodsId char (6)  ,

	@OriginalGoodsId char (6)  ,

	@OpenDate datetime   ,

	@LastDate datetime   ,

	@MinusDate datetime   ,

	@StktakeDt datetime   ,

	@StktakeTm nchar (10)  ,

	@BeginQty decimal (18, 2)  ,

	@ExpQty decimal (18, 2)  ,

	@ImpQty decimal (18, 2)  ,

	@BeginAmt decimal (18, 2)  ,

	@ExpAmt decimal (18, 2)  ,

	@ImpAmt decimal (18, 2)  ,

	@Averimppr decimal (18, 2)  
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblStockInfo]
				SET
					[id] = @Id
					,[goods_id] = @GoodsId
					,[open_date] = @OpenDate
					,[last_date] = @LastDate
					,[minus_date] = @MinusDate
					,[stktake_dt] = @StktakeDt
					,[stktake_tm] = @StktakeTm
					,[begin_qty] = @BeginQty
					,[exp_qty] = @ExpQty
					,[imp_qty] = @ImpQty
					,[begin_amt] = @BeginAmt
					,[exp_amt] = @ExpAmt
					,[imp_amt] = @ImpAmt
					,[averimppr] = @Averimppr
				WHERE
[id] = @OriginalId 
AND [goods_id] = @OriginalGoodsId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStockInfo_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStockInfo_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStockInfo_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblStockInfo table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStockInfo_Delete
(

	@Id char (5)  ,

	@GoodsId char (6)  
)
AS


				DELETE FROM [dbo].[tblStockInfo] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					AND [goods_id] = @GoodsId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStockInfo_GetByIdGoodsId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStockInfo_GetByIdGoodsId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStockInfo_GetByIdGoodsId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblStockInfo table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStockInfo_GetByIdGoodsId
(

	@Id char (5)  ,

	@GoodsId char (6)  
)
AS


				SELECT
					[id],
					[goods_id],
					[open_date],
					[last_date],
					[minus_date],
					[stktake_dt],
					[stktake_tm],
					[begin_qty],
					[exp_qty],
					[imp_qty],
					[begin_amt],
					[exp_amt],
					[imp_amt],
					[averimppr]
				FROM
					[dbo].[tblStockInfo]
				WHERE
					[id] = @Id
					AND [goods_id] = @GoodsId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStockInfo_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStockInfo_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStockInfo_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblStockInfo table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStockInfo_Find
(

	@SearchUsingOR bit   = null ,

	@Id char (5)  = null ,

	@GoodsId char (6)  = null ,

	@OpenDate datetime   = null ,

	@LastDate datetime   = null ,

	@MinusDate datetime   = null ,

	@StktakeDt datetime   = null ,

	@StktakeTm nchar (10)  = null ,

	@BeginQty decimal (18, 2)  = null ,

	@ExpQty decimal (18, 2)  = null ,

	@ImpQty decimal (18, 2)  = null ,

	@BeginAmt decimal (18, 2)  = null ,

	@ExpAmt decimal (18, 2)  = null ,

	@ImpAmt decimal (18, 2)  = null ,

	@Averimppr decimal (18, 2)  = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [goods_id]
	, [open_date]
	, [last_date]
	, [minus_date]
	, [stktake_dt]
	, [stktake_tm]
	, [begin_qty]
	, [exp_qty]
	, [imp_qty]
	, [begin_amt]
	, [exp_amt]
	, [imp_amt]
	, [averimppr]
    FROM
	[dbo].[tblStockInfo]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([goods_id] = @GoodsId OR @GoodsId IS NULL)
	AND ([open_date] = @OpenDate OR @OpenDate IS NULL)
	AND ([last_date] = @LastDate OR @LastDate IS NULL)
	AND ([minus_date] = @MinusDate OR @MinusDate IS NULL)
	AND ([stktake_dt] = @StktakeDt OR @StktakeDt IS NULL)
	AND ([stktake_tm] = @StktakeTm OR @StktakeTm IS NULL)
	AND ([begin_qty] = @BeginQty OR @BeginQty IS NULL)
	AND ([exp_qty] = @ExpQty OR @ExpQty IS NULL)
	AND ([imp_qty] = @ImpQty OR @ImpQty IS NULL)
	AND ([begin_amt] = @BeginAmt OR @BeginAmt IS NULL)
	AND ([exp_amt] = @ExpAmt OR @ExpAmt IS NULL)
	AND ([imp_amt] = @ImpAmt OR @ImpAmt IS NULL)
	AND ([averimppr] = @Averimppr OR @Averimppr IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [goods_id]
	, [open_date]
	, [last_date]
	, [minus_date]
	, [stktake_dt]
	, [stktake_tm]
	, [begin_qty]
	, [exp_qty]
	, [imp_qty]
	, [begin_amt]
	, [exp_amt]
	, [imp_amt]
	, [averimppr]
    FROM
	[dbo].[tblStockInfo]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([goods_id] = @GoodsId AND @GoodsId is not null)
	OR ([open_date] = @OpenDate AND @OpenDate is not null)
	OR ([last_date] = @LastDate AND @LastDate is not null)
	OR ([minus_date] = @MinusDate AND @MinusDate is not null)
	OR ([stktake_dt] = @StktakeDt AND @StktakeDt is not null)
	OR ([stktake_tm] = @StktakeTm AND @StktakeTm is not null)
	OR ([begin_qty] = @BeginQty AND @BeginQty is not null)
	OR ([exp_qty] = @ExpQty AND @ExpQty is not null)
	OR ([imp_qty] = @ImpQty AND @ImpQty is not null)
	OR ([begin_amt] = @BeginAmt AND @BeginAmt is not null)
	OR ([exp_amt] = @ExpAmt AND @ExpAmt is not null)
	OR ([imp_amt] = @ImpAmt AND @ImpAmt is not null)
	OR ([averimppr] = @Averimppr AND @Averimppr is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblOn_order_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblOn_order_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblOn_order_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblOn_order table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblOn_order_Get_List

AS


				
				SELECT
					[tran_date],
					[tran_time],
					[deliver_dt],
					[trans_num],
					[trans_code],
					[exp_id],
					[goods_id],
					[qty],
					[unit_symb],
					[price],
					[merc_type],
					[user_id],
					[remark],
					[recnum],
					[status],
					[end_qty]
				FROM
					[dbo].[tblOn_order]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblOn_order_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblOn_order_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblOn_order_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblOn_order table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblOn_order_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [trans_num] char(12) , [goods_id] char(6)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([trans_num], [goods_id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [trans_num], [goods_id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblOn_order]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[tran_date], O.[tran_time], O.[deliver_dt], O.[trans_num], O.[trans_code], O.[exp_id], O.[goods_id], O.[qty], O.[unit_symb], O.[price], O.[merc_type], O.[user_id], O.[remark], O.[recnum], O.[status], O.[end_qty]
				FROM
				    [dbo].[tblOn_order] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[trans_num] = PageIndex.[trans_num]
					AND O.[goods_id] = PageIndex.[goods_id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblOn_order]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblOn_order_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblOn_order_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblOn_order_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblOn_order table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblOn_order_Insert
(

	@TranDate datetime   ,

	@TranTime char (5)  ,

	@DeliverDt datetime   ,

	@TransNum char (12)  ,

	@TransCode char (2)  ,

	@ExpId char (5)  ,

	@GoodsId char (6)  ,

	@Qty decimal (12, 3)  ,

	@UnitSymb char (3)  ,

	@Price decimal (15, 2)  ,

	@MercType char (2)  ,

	@UserId decimal (3, 0)  ,

	@Remark nvarchar (200)  ,

	@Recnum decimal (6, 0)  ,

	@Status bit   ,

	@EndQty numeric (18, 2)  
)
AS


				
				INSERT INTO [dbo].[tblOn_order]
					(
					[tran_date]
					,[tran_time]
					,[deliver_dt]
					,[trans_num]
					,[trans_code]
					,[exp_id]
					,[goods_id]
					,[qty]
					,[unit_symb]
					,[price]
					,[merc_type]
					,[user_id]
					,[remark]
					,[recnum]
					,[status]
					,[end_qty]
					)
				VALUES
					(
					@TranDate
					,@TranTime
					,@DeliverDt
					,@TransNum
					,@TransCode
					,@ExpId
					,@GoodsId
					,@Qty
					,@UnitSymb
					,@Price
					,@MercType
					,@UserId
					,@Remark
					,@Recnum
					,@Status
					,@EndQty
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblOn_order_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblOn_order_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblOn_order_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblOn_order table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblOn_order_Update
(

	@TranDate datetime   ,

	@TranTime char (5)  ,

	@DeliverDt datetime   ,

	@TransNum char (12)  ,

	@OriginalTransNum char (12)  ,

	@TransCode char (2)  ,

	@ExpId char (5)  ,

	@GoodsId char (6)  ,

	@OriginalGoodsId char (6)  ,

	@Qty decimal (12, 3)  ,

	@UnitSymb char (3)  ,

	@Price decimal (15, 2)  ,

	@MercType char (2)  ,

	@UserId decimal (3, 0)  ,

	@Remark nvarchar (200)  ,

	@Recnum decimal (6, 0)  ,

	@Status bit   ,

	@EndQty numeric (18, 2)  
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblOn_order]
				SET
					[tran_date] = @TranDate
					,[tran_time] = @TranTime
					,[deliver_dt] = @DeliverDt
					,[trans_num] = @TransNum
					,[trans_code] = @TransCode
					,[exp_id] = @ExpId
					,[goods_id] = @GoodsId
					,[qty] = @Qty
					,[unit_symb] = @UnitSymb
					,[price] = @Price
					,[merc_type] = @MercType
					,[user_id] = @UserId
					,[remark] = @Remark
					,[recnum] = @Recnum
					,[status] = @Status
					,[end_qty] = @EndQty
				WHERE
[trans_num] = @OriginalTransNum 
AND [goods_id] = @OriginalGoodsId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblOn_order_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblOn_order_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblOn_order_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblOn_order table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblOn_order_Delete
(

	@TransNum char (12)  ,

	@GoodsId char (6)  
)
AS


				DELETE FROM [dbo].[tblOn_order] WITH (ROWLOCK) 
				WHERE
					[trans_num] = @TransNum
					AND [goods_id] = @GoodsId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblOn_order_GetByTransNumGoodsId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblOn_order_GetByTransNumGoodsId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblOn_order_GetByTransNumGoodsId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblOn_order table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblOn_order_GetByTransNumGoodsId
(

	@TransNum char (12)  ,

	@GoodsId char (6)  
)
AS


				SELECT
					[tran_date],
					[tran_time],
					[deliver_dt],
					[trans_num],
					[trans_code],
					[exp_id],
					[goods_id],
					[qty],
					[unit_symb],
					[price],
					[merc_type],
					[user_id],
					[remark],
					[recnum],
					[status],
					[end_qty]
				FROM
					[dbo].[tblOn_order]
				WHERE
					[trans_num] = @TransNum
					AND [goods_id] = @GoodsId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblOn_order_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblOn_order_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblOn_order_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblOn_order table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblOn_order_Find
(

	@SearchUsingOR bit   = null ,

	@TranDate datetime   = null ,

	@TranTime char (5)  = null ,

	@DeliverDt datetime   = null ,

	@TransNum char (12)  = null ,

	@TransCode char (2)  = null ,

	@ExpId char (5)  = null ,

	@GoodsId char (6)  = null ,

	@Qty decimal (12, 3)  = null ,

	@UnitSymb char (3)  = null ,

	@Price decimal (15, 2)  = null ,

	@MercType char (2)  = null ,

	@UserId decimal (3, 0)  = null ,

	@Remark nvarchar (200)  = null ,

	@Recnum decimal (6, 0)  = null ,

	@Status bit   = null ,

	@EndQty numeric (18, 2)  = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [tran_date]
	, [tran_time]
	, [deliver_dt]
	, [trans_num]
	, [trans_code]
	, [exp_id]
	, [goods_id]
	, [qty]
	, [unit_symb]
	, [price]
	, [merc_type]
	, [user_id]
	, [remark]
	, [recnum]
	, [status]
	, [end_qty]
    FROM
	[dbo].[tblOn_order]
    WHERE 
	 ([tran_date] = @TranDate OR @TranDate IS NULL)
	AND ([tran_time] = @TranTime OR @TranTime IS NULL)
	AND ([deliver_dt] = @DeliverDt OR @DeliverDt IS NULL)
	AND ([trans_num] = @TransNum OR @TransNum IS NULL)
	AND ([trans_code] = @TransCode OR @TransCode IS NULL)
	AND ([exp_id] = @ExpId OR @ExpId IS NULL)
	AND ([goods_id] = @GoodsId OR @GoodsId IS NULL)
	AND ([qty] = @Qty OR @Qty IS NULL)
	AND ([unit_symb] = @UnitSymb OR @UnitSymb IS NULL)
	AND ([price] = @Price OR @Price IS NULL)
	AND ([merc_type] = @MercType OR @MercType IS NULL)
	AND ([user_id] = @UserId OR @UserId IS NULL)
	AND ([remark] = @Remark OR @Remark IS NULL)
	AND ([recnum] = @Recnum OR @Recnum IS NULL)
	AND ([status] = @Status OR @Status IS NULL)
	AND ([end_qty] = @EndQty OR @EndQty IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [tran_date]
	, [tran_time]
	, [deliver_dt]
	, [trans_num]
	, [trans_code]
	, [exp_id]
	, [goods_id]
	, [qty]
	, [unit_symb]
	, [price]
	, [merc_type]
	, [user_id]
	, [remark]
	, [recnum]
	, [status]
	, [end_qty]
    FROM
	[dbo].[tblOn_order]
    WHERE 
	 ([tran_date] = @TranDate AND @TranDate is not null)
	OR ([tran_time] = @TranTime AND @TranTime is not null)
	OR ([deliver_dt] = @DeliverDt AND @DeliverDt is not null)
	OR ([trans_num] = @TransNum AND @TransNum is not null)
	OR ([trans_code] = @TransCode AND @TransCode is not null)
	OR ([exp_id] = @ExpId AND @ExpId is not null)
	OR ([goods_id] = @GoodsId AND @GoodsId is not null)
	OR ([qty] = @Qty AND @Qty is not null)
	OR ([unit_symb] = @UnitSymb AND @UnitSymb is not null)
	OR ([price] = @Price AND @Price is not null)
	OR ([merc_type] = @MercType AND @MercType is not null)
	OR ([user_id] = @UserId AND @UserId is not null)
	OR ([remark] = @Remark AND @Remark is not null)
	OR ([recnum] = @Recnum AND @Recnum is not null)
	OR ([status] = @Status AND @Status is not null)
	OR ([end_qty] = @EndQty AND @EndQty is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUnit_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUnit_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUnit_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblUnit table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUnit_Get_List

AS


				
				SELECT
					[id],
					[Description],
					[Status]
				FROM
					[dbo].[tblUnit]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUnit_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUnit_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUnit_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblUnit table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUnit_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] char(3)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblUnit]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[Description], O.[Status]
				FROM
				    [dbo].[tblUnit] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblUnit]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUnit_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUnit_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUnit_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblUnit table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUnit_Insert
(

	@Id char (3)  ,

	@Description nvarchar (100)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblUnit]
					(
					[id]
					,[Description]
					,[Status]
					)
				VALUES
					(
					@Id
					,@Description
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUnit_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUnit_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUnit_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblUnit table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUnit_Update
(

	@Id char (3)  ,

	@OriginalId char (3)  ,

	@Description nvarchar (100)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblUnit]
				SET
					[id] = @Id
					,[Description] = @Description
					,[Status] = @Status
				WHERE
[id] = @OriginalId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUnit_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUnit_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUnit_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblUnit table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUnit_Delete
(

	@Id char (3)  
)
AS


				DELETE FROM [dbo].[tblUnit] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUnit_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUnit_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUnit_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblUnit table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUnit_GetById
(

	@Id char (3)  
)
AS


				SELECT
					[id],
					[Description],
					[Status]
				FROM
					[dbo].[tblUnit]
				WHERE
					[id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUnit_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUnit_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUnit_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblUnit table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUnit_Find
(

	@SearchUsingOR bit   = null ,

	@Id char (3)  = null ,

	@Description nvarchar (100)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [Description]
	, [Status]
    FROM
	[dbo].[tblUnit]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([Description] = @Description OR @Description IS NULL)
	AND ([Status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [Description]
	, [Status]
    FROM
	[dbo].[tblUnit]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([Description] = @Description AND @Description is not null)
	OR ([Status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStore_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStore_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStore_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblStore table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStore_Get_List

AS


				
				SELECT
					[id],
					[Type],
					[Name],
					[fullname],
					[address],
					[phone],
					[fax],
					[bankname],
					[bank_br],
					[accnum],
					[Vatnum],
					[contactps],
					[remark],
					[open_date],
					[Status]
				FROM
					[dbo].[tblStore]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStore_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStore_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStore_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblStore table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStore_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] char(5)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblStore]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[Type], O.[Name], O.[fullname], O.[address], O.[phone], O.[fax], O.[bankname], O.[bank_br], O.[accnum], O.[Vatnum], O.[contactps], O.[remark], O.[open_date], O.[Status]
				FROM
				    [dbo].[tblStore] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblStore]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStore_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStore_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStore_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblStore table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStore_Insert
(

	@Id char (5)  ,

	@Type char (2)  ,

	@Name nvarchar (100)  ,

	@Fullname nvarchar (200)  ,

	@Address nvarchar (500)  ,

	@Phone nvarchar (100)  ,

	@Fax nvarchar (50)  ,

	@Bankname nvarchar (150)  ,

	@BankBr nvarchar (150)  ,

	@Accnum nvarchar (50)  ,

	@Vatnum nvarchar (50)  ,

	@Contactps nvarchar (50)  ,

	@Remark nvarchar (500)  ,

	@OpenDate datetime   ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblStore]
					(
					[id]
					,[Type]
					,[Name]
					,[fullname]
					,[address]
					,[phone]
					,[fax]
					,[bankname]
					,[bank_br]
					,[accnum]
					,[Vatnum]
					,[contactps]
					,[remark]
					,[open_date]
					,[Status]
					)
				VALUES
					(
					@Id
					,@Type
					,@Name
					,@Fullname
					,@Address
					,@Phone
					,@Fax
					,@Bankname
					,@BankBr
					,@Accnum
					,@Vatnum
					,@Contactps
					,@Remark
					,@OpenDate
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStore_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStore_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStore_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblStore table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStore_Update
(

	@Id char (5)  ,

	@OriginalId char (5)  ,

	@Type char (2)  ,

	@Name nvarchar (100)  ,

	@Fullname nvarchar (200)  ,

	@Address nvarchar (500)  ,

	@Phone nvarchar (100)  ,

	@Fax nvarchar (50)  ,

	@Bankname nvarchar (150)  ,

	@BankBr nvarchar (150)  ,

	@Accnum nvarchar (50)  ,

	@Vatnum nvarchar (50)  ,

	@Contactps nvarchar (50)  ,

	@Remark nvarchar (500)  ,

	@OpenDate datetime   ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblStore]
				SET
					[id] = @Id
					,[Type] = @Type
					,[Name] = @Name
					,[fullname] = @Fullname
					,[address] = @Address
					,[phone] = @Phone
					,[fax] = @Fax
					,[bankname] = @Bankname
					,[bank_br] = @BankBr
					,[accnum] = @Accnum
					,[Vatnum] = @Vatnum
					,[contactps] = @Contactps
					,[remark] = @Remark
					,[open_date] = @OpenDate
					,[Status] = @Status
				WHERE
[id] = @OriginalId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStore_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStore_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStore_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblStore table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStore_Delete
(

	@Id char (5)  
)
AS


				DELETE FROM [dbo].[tblStore] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStore_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStore_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStore_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblStore table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStore_GetById
(

	@Id char (5)  
)
AS


				SELECT
					[id],
					[Type],
					[Name],
					[fullname],
					[address],
					[phone],
					[fax],
					[bankname],
					[bank_br],
					[accnum],
					[Vatnum],
					[contactps],
					[remark],
					[open_date],
					[Status]
				FROM
					[dbo].[tblStore]
				WHERE
					[id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblStore_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblStore_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblStore_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblStore table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblStore_Find
(

	@SearchUsingOR bit   = null ,

	@Id char (5)  = null ,

	@Type char (2)  = null ,

	@Name nvarchar (100)  = null ,

	@Fullname nvarchar (200)  = null ,

	@Address nvarchar (500)  = null ,

	@Phone nvarchar (100)  = null ,

	@Fax nvarchar (50)  = null ,

	@Bankname nvarchar (150)  = null ,

	@BankBr nvarchar (150)  = null ,

	@Accnum nvarchar (50)  = null ,

	@Vatnum nvarchar (50)  = null ,

	@Contactps nvarchar (50)  = null ,

	@Remark nvarchar (500)  = null ,

	@OpenDate datetime   = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [Type]
	, [Name]
	, [fullname]
	, [address]
	, [phone]
	, [fax]
	, [bankname]
	, [bank_br]
	, [accnum]
	, [Vatnum]
	, [contactps]
	, [remark]
	, [open_date]
	, [Status]
    FROM
	[dbo].[tblStore]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([Type] = @Type OR @Type IS NULL)
	AND ([Name] = @Name OR @Name IS NULL)
	AND ([fullname] = @Fullname OR @Fullname IS NULL)
	AND ([address] = @Address OR @Address IS NULL)
	AND ([phone] = @Phone OR @Phone IS NULL)
	AND ([fax] = @Fax OR @Fax IS NULL)
	AND ([bankname] = @Bankname OR @Bankname IS NULL)
	AND ([bank_br] = @BankBr OR @BankBr IS NULL)
	AND ([accnum] = @Accnum OR @Accnum IS NULL)
	AND ([Vatnum] = @Vatnum OR @Vatnum IS NULL)
	AND ([contactps] = @Contactps OR @Contactps IS NULL)
	AND ([remark] = @Remark OR @Remark IS NULL)
	AND ([open_date] = @OpenDate OR @OpenDate IS NULL)
	AND ([Status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [Type]
	, [Name]
	, [fullname]
	, [address]
	, [phone]
	, [fax]
	, [bankname]
	, [bank_br]
	, [accnum]
	, [Vatnum]
	, [contactps]
	, [remark]
	, [open_date]
	, [Status]
    FROM
	[dbo].[tblStore]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([Type] = @Type AND @Type is not null)
	OR ([Name] = @Name AND @Name is not null)
	OR ([fullname] = @Fullname AND @Fullname is not null)
	OR ([address] = @Address AND @Address is not null)
	OR ([phone] = @Phone AND @Phone is not null)
	OR ([fax] = @Fax AND @Fax is not null)
	OR ([bankname] = @Bankname AND @Bankname is not null)
	OR ([bank_br] = @BankBr AND @BankBr is not null)
	OR ([accnum] = @Accnum AND @Accnum is not null)
	OR ([Vatnum] = @Vatnum AND @Vatnum is not null)
	OR ([contactps] = @Contactps AND @Contactps is not null)
	OR ([remark] = @Remark AND @Remark is not null)
	OR ([open_date] = @OpenDate AND @OpenDate is not null)
	OR ([Status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUser_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUser_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUser_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblUser table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUser_Get_List

AS


				
				SELECT
					[ID],
					[name],
					[full_name],
					[passw],
					[mright],
					[rpright],
					[groups],
					[Status]
				FROM
					[dbo].[tblUser]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUser_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUser_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUser_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblUser table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUser_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [ID] int 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([ID])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [ID]'
				SET @SQL = @SQL + ' FROM [dbo].[tblUser]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[ID], O.[name], O.[full_name], O.[passw], O.[mright], O.[rpright], O.[groups], O.[Status]
				FROM
				    [dbo].[tblUser] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[ID] = PageIndex.[ID]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblUser]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUser_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUser_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUser_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblUser table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUser_Insert
(

	@Id int   ,

	@Name nvarchar (50)  ,

	@FullName nvarchar (50)  ,

	@Passw nvarchar (100)  ,

	@Mright nvarchar (MAX)  ,

	@Rpright nvarchar (MAX)  ,

	@Groups char (2)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblUser]
					(
					[ID]
					,[name]
					,[full_name]
					,[passw]
					,[mright]
					,[rpright]
					,[groups]
					,[Status]
					)
				VALUES
					(
					@Id
					,@Name
					,@FullName
					,@Passw
					,@Mright
					,@Rpright
					,@Groups
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUser_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUser_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUser_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblUser table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUser_Update
(

	@Id int   ,

	@OriginalId int   ,

	@Name nvarchar (50)  ,

	@FullName nvarchar (50)  ,

	@Passw nvarchar (100)  ,

	@Mright nvarchar (MAX)  ,

	@Rpright nvarchar (MAX)  ,

	@Groups char (2)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblUser]
				SET
					[ID] = @Id
					,[name] = @Name
					,[full_name] = @FullName
					,[passw] = @Passw
					,[mright] = @Mright
					,[rpright] = @Rpright
					,[groups] = @Groups
					,[Status] = @Status
				WHERE
[ID] = @OriginalId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUser_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUser_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUser_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblUser table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUser_Delete
(

	@Id int   
)
AS


				DELETE FROM [dbo].[tblUser] WITH (ROWLOCK) 
				WHERE
					[ID] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUser_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUser_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUser_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblUser table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUser_GetById
(

	@Id int   
)
AS


				SELECT
					[ID],
					[name],
					[full_name],
					[passw],
					[mright],
					[rpright],
					[groups],
					[Status]
				FROM
					[dbo].[tblUser]
				WHERE
					[ID] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUser_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUser_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUser_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblUser table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUser_Find
(

	@SearchUsingOR bit   = null ,

	@Id int   = null ,

	@Name nvarchar (50)  = null ,

	@FullName nvarchar (50)  = null ,

	@Passw nvarchar (100)  = null ,

	@Mright nvarchar (MAX)  = null ,

	@Rpright nvarchar (MAX)  = null ,

	@Groups char (2)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [ID]
	, [name]
	, [full_name]
	, [passw]
	, [mright]
	, [rpright]
	, [groups]
	, [Status]
    FROM
	[dbo].[tblUser]
    WHERE 
	 ([ID] = @Id OR @Id IS NULL)
	AND ([name] = @Name OR @Name IS NULL)
	AND ([full_name] = @FullName OR @FullName IS NULL)
	AND ([passw] = @Passw OR @Passw IS NULL)
	AND ([mright] = @Mright OR @Mright IS NULL)
	AND ([rpright] = @Rpright OR @Rpright IS NULL)
	AND ([groups] = @Groups OR @Groups IS NULL)
	AND ([Status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [ID]
	, [name]
	, [full_name]
	, [passw]
	, [mright]
	, [rpright]
	, [groups]
	, [Status]
    FROM
	[dbo].[tblUser]
    WHERE 
	 ([ID] = @Id AND @Id is not null)
	OR ([name] = @Name AND @Name is not null)
	OR ([full_name] = @FullName AND @FullName is not null)
	OR ([passw] = @Passw AND @Passw is not null)
	OR ([mright] = @Mright AND @Mright is not null)
	OR ([rpright] = @Rpright AND @Rpright is not null)
	OR ([groups] = @Groups AND @Groups is not null)
	OR ([Status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTrcode_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTrcode_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTrcode_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblTrcode table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTrcode_Get_List

AS


				
				SELECT
					[trCode],
					[trName],
					[description],
					[trDepart],
					[frmCaption],
					[voucherFile],
					[voucherFile1],
					[voucherFile2],
					[Status]
				FROM
					[dbo].[tblTrcode]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTrcode_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTrcode_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTrcode_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblTrcode table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTrcode_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [trCode] char(2)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([trCode])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [trCode]'
				SET @SQL = @SQL + ' FROM [dbo].[tblTrcode]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[trCode], O.[trName], O.[description], O.[trDepart], O.[frmCaption], O.[voucherFile], O.[voucherFile1], O.[voucherFile2], O.[Status]
				FROM
				    [dbo].[tblTrcode] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[trCode] = PageIndex.[trCode]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblTrcode]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTrcode_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTrcode_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTrcode_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblTrcode table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTrcode_Insert
(

	@TrCode char (2)  ,

	@TrName nvarchar (200)  ,

	@Description nvarchar (MAX)  ,

	@TrDepart nchar (1)  ,

	@FrmCaption nvarchar (50)  ,

	@VoucherFile char (20)  ,

	@VoucherFile1 char (20)  ,

	@VoucherFile2 char (20)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblTrcode]
					(
					[trCode]
					,[trName]
					,[description]
					,[trDepart]
					,[frmCaption]
					,[voucherFile]
					,[voucherFile1]
					,[voucherFile2]
					,[Status]
					)
				VALUES
					(
					@TrCode
					,@TrName
					,@Description
					,@TrDepart
					,@FrmCaption
					,@VoucherFile
					,@VoucherFile1
					,@VoucherFile2
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTrcode_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTrcode_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTrcode_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblTrcode table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTrcode_Update
(

	@TrCode char (2)  ,

	@OriginalTrCode char (2)  ,

	@TrName nvarchar (200)  ,

	@Description nvarchar (MAX)  ,

	@TrDepart nchar (1)  ,

	@FrmCaption nvarchar (50)  ,

	@VoucherFile char (20)  ,

	@VoucherFile1 char (20)  ,

	@VoucherFile2 char (20)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblTrcode]
				SET
					[trCode] = @TrCode
					,[trName] = @TrName
					,[description] = @Description
					,[trDepart] = @TrDepart
					,[frmCaption] = @FrmCaption
					,[voucherFile] = @VoucherFile
					,[voucherFile1] = @VoucherFile1
					,[voucherFile2] = @VoucherFile2
					,[Status] = @Status
				WHERE
[trCode] = @OriginalTrCode 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTrcode_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTrcode_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTrcode_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblTrcode table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTrcode_Delete
(

	@TrCode char (2)  
)
AS


				DELETE FROM [dbo].[tblTrcode] WITH (ROWLOCK) 
				WHERE
					[trCode] = @TrCode
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTrcode_GetByTrCode procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTrcode_GetByTrCode') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTrcode_GetByTrCode
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblTrcode table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTrcode_GetByTrCode
(

	@TrCode char (2)  
)
AS


				SELECT
					[trCode],
					[trName],
					[description],
					[trDepart],
					[frmCaption],
					[voucherFile],
					[voucherFile1],
					[voucherFile2],
					[Status]
				FROM
					[dbo].[tblTrcode]
				WHERE
					[trCode] = @TrCode
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTrcode_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTrcode_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTrcode_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblTrcode table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTrcode_Find
(

	@SearchUsingOR bit   = null ,

	@TrCode char (2)  = null ,

	@TrName nvarchar (200)  = null ,

	@Description nvarchar (MAX)  = null ,

	@TrDepart nchar (1)  = null ,

	@FrmCaption nvarchar (50)  = null ,

	@VoucherFile char (20)  = null ,

	@VoucherFile1 char (20)  = null ,

	@VoucherFile2 char (20)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [trCode]
	, [trName]
	, [description]
	, [trDepart]
	, [frmCaption]
	, [voucherFile]
	, [voucherFile1]
	, [voucherFile2]
	, [Status]
    FROM
	[dbo].[tblTrcode]
    WHERE 
	 ([trCode] = @TrCode OR @TrCode IS NULL)
	AND ([trName] = @TrName OR @TrName IS NULL)
	AND ([description] = @Description OR @Description IS NULL)
	AND ([trDepart] = @TrDepart OR @TrDepart IS NULL)
	AND ([frmCaption] = @FrmCaption OR @FrmCaption IS NULL)
	AND ([voucherFile] = @VoucherFile OR @VoucherFile IS NULL)
	AND ([voucherFile1] = @VoucherFile1 OR @VoucherFile1 IS NULL)
	AND ([voucherFile2] = @VoucherFile2 OR @VoucherFile2 IS NULL)
	AND ([Status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [trCode]
	, [trName]
	, [description]
	, [trDepart]
	, [frmCaption]
	, [voucherFile]
	, [voucherFile1]
	, [voucherFile2]
	, [Status]
    FROM
	[dbo].[tblTrcode]
    WHERE 
	 ([trCode] = @TrCode AND @TrCode is not null)
	OR ([trName] = @TrName AND @TrName is not null)
	OR ([description] = @Description AND @Description is not null)
	OR ([trDepart] = @TrDepart AND @TrDepart is not null)
	OR ([frmCaption] = @FrmCaption AND @FrmCaption is not null)
	OR ([voucherFile] = @VoucherFile AND @VoucherFile is not null)
	OR ([voucherFile1] = @VoucherFile1 AND @VoucherFile1 is not null)
	OR ([voucherFile2] = @VoucherFile2 AND @VoucherFile2 is not null)
	OR ([Status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUserGrp_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUserGrp_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUserGrp_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblUserGrp table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUserGrp_Get_List

AS


				
				SELECT
					[ID],
					[Name],
					[Descript],
					[MenuPer],
					[rpright],
					[Status]
				FROM
					[dbo].[tblUserGrp]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUserGrp_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUserGrp_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUserGrp_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblUserGrp table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUserGrp_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [ID] char(2)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([ID])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [ID]'
				SET @SQL = @SQL + ' FROM [dbo].[tblUserGrp]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[ID], O.[Name], O.[Descript], O.[MenuPer], O.[rpright], O.[Status]
				FROM
				    [dbo].[tblUserGrp] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[ID] = PageIndex.[ID]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblUserGrp]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUserGrp_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUserGrp_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUserGrp_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblUserGrp table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUserGrp_Insert
(

	@Id char (2)  ,

	@Name nvarchar (50)  ,

	@Descript nvarchar (100)  ,

	@MenuPer nvarchar (MAX)  ,

	@Rpright nvarchar (MAX)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblUserGrp]
					(
					[ID]
					,[Name]
					,[Descript]
					,[MenuPer]
					,[rpright]
					,[Status]
					)
				VALUES
					(
					@Id
					,@Name
					,@Descript
					,@MenuPer
					,@Rpright
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUserGrp_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUserGrp_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUserGrp_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblUserGrp table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUserGrp_Update
(

	@Id char (2)  ,

	@OriginalId char (2)  ,

	@Name nvarchar (50)  ,

	@Descript nvarchar (100)  ,

	@MenuPer nvarchar (MAX)  ,

	@Rpright nvarchar (MAX)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblUserGrp]
				SET
					[ID] = @Id
					,[Name] = @Name
					,[Descript] = @Descript
					,[MenuPer] = @MenuPer
					,[rpright] = @Rpright
					,[Status] = @Status
				WHERE
[ID] = @OriginalId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUserGrp_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUserGrp_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUserGrp_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblUserGrp table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUserGrp_Delete
(

	@Id char (2)  
)
AS


				DELETE FROM [dbo].[tblUserGrp] WITH (ROWLOCK) 
				WHERE
					[ID] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUserGrp_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUserGrp_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUserGrp_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblUserGrp table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUserGrp_GetById
(

	@Id char (2)  
)
AS


				SELECT
					[ID],
					[Name],
					[Descript],
					[MenuPer],
					[rpright],
					[Status]
				FROM
					[dbo].[tblUserGrp]
				WHERE
					[ID] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUserGrp_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUserGrp_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUserGrp_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblUserGrp table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUserGrp_Find
(

	@SearchUsingOR bit   = null ,

	@Id char (2)  = null ,

	@Name nvarchar (50)  = null ,

	@Descript nvarchar (100)  = null ,

	@MenuPer nvarchar (MAX)  = null ,

	@Rpright nvarchar (MAX)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [ID]
	, [Name]
	, [Descript]
	, [MenuPer]
	, [rpright]
	, [Status]
    FROM
	[dbo].[tblUserGrp]
    WHERE 
	 ([ID] = @Id OR @Id IS NULL)
	AND ([Name] = @Name OR @Name IS NULL)
	AND ([Descript] = @Descript OR @Descript IS NULL)
	AND ([MenuPer] = @MenuPer OR @MenuPer IS NULL)
	AND ([rpright] = @Rpright OR @Rpright IS NULL)
	AND ([Status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [ID]
	, [Name]
	, [Descript]
	, [MenuPer]
	, [rpright]
	, [Status]
    FROM
	[dbo].[tblUserGrp]
    WHERE 
	 ([ID] = @Id AND @Id is not null)
	OR ([Name] = @Name AND @Name is not null)
	OR ([Descript] = @Descript AND @Descript is not null)
	OR ([MenuPer] = @MenuPer AND @MenuPer is not null)
	OR ([rpright] = @Rpright AND @Rpright is not null)
	OR ([Status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblSysvar_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblSysvar_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblSysvar_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblSysvar table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblSysvar_Get_List

AS


				
				SELECT
					[m_code],
					[m_type],
					[m_value],
					[description],
					[Type]
				FROM
					[dbo].[tblSysvar]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblSysvar_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblSysvar_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblSysvar_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblSysvar table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblSysvar_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [m_code] nvarchar(50)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([m_code])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [m_code]'
				SET @SQL = @SQL + ' FROM [dbo].[tblSysvar]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[m_code], O.[m_type], O.[m_value], O.[description], O.[Type]
				FROM
				    [dbo].[tblSysvar] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[m_code] = PageIndex.[m_code]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblSysvar]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblSysvar_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblSysvar_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblSysvar_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblSysvar table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblSysvar_Insert
(

	@MCode nvarchar (50)  ,

	@MType char (1)  ,

	@MValue nvarchar (200)  ,

	@Description nvarchar (200)  ,

	@Type char (1)  
)
AS


				
				INSERT INTO [dbo].[tblSysvar]
					(
					[m_code]
					,[m_type]
					,[m_value]
					,[description]
					,[Type]
					)
				VALUES
					(
					@MCode
					,@MType
					,@MValue
					,@Description
					,@Type
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblSysvar_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblSysvar_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblSysvar_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblSysvar table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblSysvar_Update
(

	@MCode nvarchar (50)  ,

	@OriginalMCode nvarchar (50)  ,

	@MType char (1)  ,

	@MValue nvarchar (200)  ,

	@Description nvarchar (200)  ,

	@Type char (1)  
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblSysvar]
				SET
					[m_code] = @MCode
					,[m_type] = @MType
					,[m_value] = @MValue
					,[description] = @Description
					,[Type] = @Type
				WHERE
[m_code] = @OriginalMCode 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblSysvar_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblSysvar_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblSysvar_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblSysvar table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblSysvar_Delete
(

	@MCode nvarchar (50)  
)
AS


				DELETE FROM [dbo].[tblSysvar] WITH (ROWLOCK) 
				WHERE
					[m_code] = @MCode
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblSysvar_GetByMCode procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblSysvar_GetByMCode') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblSysvar_GetByMCode
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblSysvar table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblSysvar_GetByMCode
(

	@MCode nvarchar (50)  
)
AS


				SELECT
					[m_code],
					[m_type],
					[m_value],
					[description],
					[Type]
				FROM
					[dbo].[tblSysvar]
				WHERE
					[m_code] = @MCode
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblSysvar_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblSysvar_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblSysvar_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblSysvar table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblSysvar_Find
(

	@SearchUsingOR bit   = null ,

	@MCode nvarchar (50)  = null ,

	@MType char (1)  = null ,

	@MValue nvarchar (200)  = null ,

	@Description nvarchar (200)  = null ,

	@Type char (1)  = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [m_code]
	, [m_type]
	, [m_value]
	, [description]
	, [Type]
    FROM
	[dbo].[tblSysvar]
    WHERE 
	 ([m_code] = @MCode OR @MCode IS NULL)
	AND ([m_type] = @MType OR @MType IS NULL)
	AND ([m_value] = @MValue OR @MValue IS NULL)
	AND ([description] = @Description OR @Description IS NULL)
	AND ([Type] = @Type OR @Type IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [m_code]
	, [m_type]
	, [m_value]
	, [description]
	, [Type]
    FROM
	[dbo].[tblSysvar]
    WHERE 
	 ([m_code] = @MCode AND @MCode is not null)
	OR ([m_type] = @MType AND @MType is not null)
	OR ([m_value] = @MValue AND @MValue is not null)
	OR ([description] = @Description AND @Description is not null)
	OR ([Type] = @Type AND @Type is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransValue_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransValue_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransValue_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblTransValue table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransValue_Get_List

AS


				
				SELECT
					[trans_num],
					[amount],
					[frcustomer],
					[forex]
				FROM
					[dbo].[tblTransValue]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransValue_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransValue_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransValue_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblTransValue table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransValue_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [trans_num] nchar(12)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([trans_num])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [trans_num]'
				SET @SQL = @SQL + ' FROM [dbo].[tblTransValue]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[trans_num], O.[amount], O.[frcustomer], O.[forex]
				FROM
				    [dbo].[tblTransValue] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[trans_num] = PageIndex.[trans_num]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblTransValue]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransValue_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransValue_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransValue_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblTransValue table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransValue_Insert
(

	@TransNum nchar (12)  ,

	@Amount numeric (18, 0)  ,

	@Frcustomer numeric (18, 0)  ,

	@Forex nchar (3)  
)
AS


				
				INSERT INTO [dbo].[tblTransValue]
					(
					[trans_num]
					,[amount]
					,[frcustomer]
					,[forex]
					)
				VALUES
					(
					@TransNum
					,@Amount
					,@Frcustomer
					,@Forex
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransValue_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransValue_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransValue_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblTransValue table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransValue_Update
(

	@TransNum nchar (12)  ,

	@OriginalTransNum nchar (12)  ,

	@Amount numeric (18, 0)  ,

	@Frcustomer numeric (18, 0)  ,

	@Forex nchar (3)  
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblTransValue]
				SET
					[trans_num] = @TransNum
					,[amount] = @Amount
					,[frcustomer] = @Frcustomer
					,[forex] = @Forex
				WHERE
[trans_num] = @OriginalTransNum 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransValue_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransValue_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransValue_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblTransValue table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransValue_Delete
(

	@TransNum nchar (12)  
)
AS


				DELETE FROM [dbo].[tblTransValue] WITH (ROWLOCK) 
				WHERE
					[trans_num] = @TransNum
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransValue_GetByTransNum procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransValue_GetByTransNum') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransValue_GetByTransNum
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblTransValue table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransValue_GetByTransNum
(

	@TransNum nchar (12)  
)
AS


				SELECT
					[trans_num],
					[amount],
					[frcustomer],
					[forex]
				FROM
					[dbo].[tblTransValue]
				WHERE
					[trans_num] = @TransNum
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransValue_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransValue_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransValue_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblTransValue table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransValue_Find
(

	@SearchUsingOR bit   = null ,

	@TransNum nchar (12)  = null ,

	@Amount numeric (18, 0)  = null ,

	@Frcustomer numeric (18, 0)  = null ,

	@Forex nchar (3)  = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [trans_num]
	, [amount]
	, [frcustomer]
	, [forex]
    FROM
	[dbo].[tblTransValue]
    WHERE 
	 ([trans_num] = @TransNum OR @TransNum IS NULL)
	AND ([amount] = @Amount OR @Amount IS NULL)
	AND ([frcustomer] = @Frcustomer OR @Frcustomer IS NULL)
	AND ([forex] = @Forex OR @Forex IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [trans_num]
	, [amount]
	, [frcustomer]
	, [forex]
    FROM
	[dbo].[tblTransValue]
    WHERE 
	 ([trans_num] = @TransNum AND @TransNum is not null)
	OR ([amount] = @Amount AND @Amount is not null)
	OR ([frcustomer] = @Frcustomer AND @Frcustomer is not null)
	OR ([forex] = @Forex AND @Forex is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransaction_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransaction_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransaction_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblTransaction table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransaction_Get_List

AS


				
				SELECT
					[idx],
					[tran_date],
					[tran_time],
					[trans_num],
					[trans_code],
					[voucher],
					[invoice],
					[post],
					[exp_id],
					[imp_id],
					[goods_id],
					[kit_qty],
					[kit_id],
					[qty],
					[unit_symb],
					[amount],
					[discount],
					[carddisc_amt],
					[vat_amt],
					[surplus],
					[commis_amt],
					[forex_cys],
					[forex_rate],
					[expiry_dt],
					[user_id],
					[station],
					[cs_id],
					[custax_id],
					[ref],
					[remark],
					[updated],
					[merc_type],
					[tax_code],
					[vat_incl],
					[discpervat],
					[disc_incl],
					[copies],
					[recnum],
					[card_id],
					[Shift],
					[Status]
				FROM
					[dbo].[tblTransaction]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransaction_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransaction_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransaction_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblTransaction table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransaction_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [idx] numeric(18, 0) 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([idx])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [idx]'
				SET @SQL = @SQL + ' FROM [dbo].[tblTransaction]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[idx], O.[tran_date], O.[tran_time], O.[trans_num], O.[trans_code], O.[voucher], O.[invoice], O.[post], O.[exp_id], O.[imp_id], O.[goods_id], O.[kit_qty], O.[kit_id], O.[qty], O.[unit_symb], O.[amount], O.[discount], O.[carddisc_amt], O.[vat_amt], O.[surplus], O.[commis_amt], O.[forex_cys], O.[forex_rate], O.[expiry_dt], O.[user_id], O.[station], O.[cs_id], O.[custax_id], O.[ref], O.[remark], O.[updated], O.[merc_type], O.[tax_code], O.[vat_incl], O.[discpervat], O.[disc_incl], O.[copies], O.[recnum], O.[card_id], O.[Shift], O.[Status]
				FROM
				    [dbo].[tblTransaction] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[idx] = PageIndex.[idx]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblTransaction]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransaction_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransaction_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransaction_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblTransaction table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransaction_Insert
(

	@Idx numeric (18, 0)   OUTPUT,

	@TranDate datetime   ,

	@TranTime char (5)  ,

	@TransNum char (12)  ,

	@TransCode char (2)  ,

	@Voucher varchar (15)  ,

	@Invoice char (10)  ,

	@Post bit   ,

	@ExpId char (5)  ,

	@ImpId char (5)  ,

	@GoodsId char (6)  ,

	@KitQty decimal (18, 0)  ,

	@KitId char (6)  ,

	@Qty decimal (8, 2)  ,

	@UnitSymb char (3)  ,

	@Amount decimal (18, 2)  ,

	@Discount decimal (18, 2)  ,

	@CarddiscAmt decimal (18, 2)  ,

	@VatAmt decimal (18, 2)  ,

	@Surplus decimal (18, 2)  ,

	@CommisAmt decimal (18, 2)  ,

	@ForexCys char (3)  ,

	@ForexRate decimal (18, 2)  ,

	@ExpiryDt datetime   ,

	@UserId decimal (3, 0)  ,

	@Station int   ,

	@CsId char (5)  ,

	@CustaxId nchar (30)  ,

	@SafeNameRef varchar (12)  ,

	@Remark nvarchar (100)  ,

	@Updated bit   ,

	@MercType char (2)  ,

	@TaxCode char (3)  ,

	@VatIncl bit   ,

	@Discpervat bit   ,

	@DiscIncl bit   ,

	@Copies decimal (2, 0)  ,

	@Recnum decimal (6, 0)  ,

	@CardId nchar (16)  ,

	@Shift int   ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblTransaction]
					(
					[tran_date]
					,[tran_time]
					,[trans_num]
					,[trans_code]
					,[voucher]
					,[invoice]
					,[post]
					,[exp_id]
					,[imp_id]
					,[goods_id]
					,[kit_qty]
					,[kit_id]
					,[qty]
					,[unit_symb]
					,[amount]
					,[discount]
					,[carddisc_amt]
					,[vat_amt]
					,[surplus]
					,[commis_amt]
					,[forex_cys]
					,[forex_rate]
					,[expiry_dt]
					,[user_id]
					,[station]
					,[cs_id]
					,[custax_id]
					,[ref]
					,[remark]
					,[updated]
					,[merc_type]
					,[tax_code]
					,[vat_incl]
					,[discpervat]
					,[disc_incl]
					,[copies]
					,[recnum]
					,[card_id]
					,[Shift]
					,[Status]
					)
				VALUES
					(
					@TranDate
					,@TranTime
					,@TransNum
					,@TransCode
					,@Voucher
					,@Invoice
					,@Post
					,@ExpId
					,@ImpId
					,@GoodsId
					,@KitQty
					,@KitId
					,@Qty
					,@UnitSymb
					,@Amount
					,@Discount
					,@CarddiscAmt
					,@VatAmt
					,@Surplus
					,@CommisAmt
					,@ForexCys
					,@ForexRate
					,@ExpiryDt
					,@UserId
					,@Station
					,@CsId
					,@CustaxId
					,@SafeNameRef
					,@Remark
					,@Updated
					,@MercType
					,@TaxCode
					,@VatIncl
					,@Discpervat
					,@DiscIncl
					,@Copies
					,@Recnum
					,@CardId
					,@Shift
					,@Status
					)
				-- Get the identity value
				SET @Idx = SCOPE_IDENTITY()
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransaction_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransaction_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransaction_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblTransaction table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransaction_Update
(

	@Idx numeric (18, 0)  ,

	@TranDate datetime   ,

	@TranTime char (5)  ,

	@TransNum char (12)  ,

	@TransCode char (2)  ,

	@Voucher varchar (15)  ,

	@Invoice char (10)  ,

	@Post bit   ,

	@ExpId char (5)  ,

	@ImpId char (5)  ,

	@GoodsId char (6)  ,

	@KitQty decimal (18, 0)  ,

	@KitId char (6)  ,

	@Qty decimal (8, 2)  ,

	@UnitSymb char (3)  ,

	@Amount decimal (18, 2)  ,

	@Discount decimal (18, 2)  ,

	@CarddiscAmt decimal (18, 2)  ,

	@VatAmt decimal (18, 2)  ,

	@Surplus decimal (18, 2)  ,

	@CommisAmt decimal (18, 2)  ,

	@ForexCys char (3)  ,

	@ForexRate decimal (18, 2)  ,

	@ExpiryDt datetime   ,

	@UserId decimal (3, 0)  ,

	@Station int   ,

	@CsId char (5)  ,

	@CustaxId nchar (30)  ,

	@SafeNameRef varchar (12)  ,

	@Remark nvarchar (100)  ,

	@Updated bit   ,

	@MercType char (2)  ,

	@TaxCode char (3)  ,

	@VatIncl bit   ,

	@Discpervat bit   ,

	@DiscIncl bit   ,

	@Copies decimal (2, 0)  ,

	@Recnum decimal (6, 0)  ,

	@CardId nchar (16)  ,

	@Shift int   ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblTransaction]
				SET
					[tran_date] = @TranDate
					,[tran_time] = @TranTime
					,[trans_num] = @TransNum
					,[trans_code] = @TransCode
					,[voucher] = @Voucher
					,[invoice] = @Invoice
					,[post] = @Post
					,[exp_id] = @ExpId
					,[imp_id] = @ImpId
					,[goods_id] = @GoodsId
					,[kit_qty] = @KitQty
					,[kit_id] = @KitId
					,[qty] = @Qty
					,[unit_symb] = @UnitSymb
					,[amount] = @Amount
					,[discount] = @Discount
					,[carddisc_amt] = @CarddiscAmt
					,[vat_amt] = @VatAmt
					,[surplus] = @Surplus
					,[commis_amt] = @CommisAmt
					,[forex_cys] = @ForexCys
					,[forex_rate] = @ForexRate
					,[expiry_dt] = @ExpiryDt
					,[user_id] = @UserId
					,[station] = @Station
					,[cs_id] = @CsId
					,[custax_id] = @CustaxId
					,[ref] = @SafeNameRef
					,[remark] = @Remark
					,[updated] = @Updated
					,[merc_type] = @MercType
					,[tax_code] = @TaxCode
					,[vat_incl] = @VatIncl
					,[discpervat] = @Discpervat
					,[disc_incl] = @DiscIncl
					,[copies] = @Copies
					,[recnum] = @Recnum
					,[card_id] = @CardId
					,[Shift] = @Shift
					,[Status] = @Status
				WHERE
[idx] = @Idx 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransaction_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransaction_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransaction_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblTransaction table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransaction_Delete
(

	@Idx numeric (18, 0)  
)
AS


				DELETE FROM [dbo].[tblTransaction] WITH (ROWLOCK) 
				WHERE
					[idx] = @Idx
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransaction_GetByIdx procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransaction_GetByIdx') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransaction_GetByIdx
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblTransaction table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransaction_GetByIdx
(

	@Idx numeric (18, 0)  
)
AS


				SELECT
					[idx],
					[tran_date],
					[tran_time],
					[trans_num],
					[trans_code],
					[voucher],
					[invoice],
					[post],
					[exp_id],
					[imp_id],
					[goods_id],
					[kit_qty],
					[kit_id],
					[qty],
					[unit_symb],
					[amount],
					[discount],
					[carddisc_amt],
					[vat_amt],
					[surplus],
					[commis_amt],
					[forex_cys],
					[forex_rate],
					[expiry_dt],
					[user_id],
					[station],
					[cs_id],
					[custax_id],
					[ref],
					[remark],
					[updated],
					[merc_type],
					[tax_code],
					[vat_incl],
					[discpervat],
					[disc_incl],
					[copies],
					[recnum],
					[card_id],
					[Shift],
					[Status]
				FROM
					[dbo].[tblTransaction]
				WHERE
					[idx] = @Idx
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransaction_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransaction_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransaction_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblTransaction table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransaction_Find
(

	@SearchUsingOR bit   = null ,

	@Idx numeric (18, 0)  = null ,

	@TranDate datetime   = null ,

	@TranTime char (5)  = null ,

	@TransNum char (12)  = null ,

	@TransCode char (2)  = null ,

	@Voucher varchar (15)  = null ,

	@Invoice char (10)  = null ,

	@Post bit   = null ,

	@ExpId char (5)  = null ,

	@ImpId char (5)  = null ,

	@GoodsId char (6)  = null ,

	@KitQty decimal (18, 0)  = null ,

	@KitId char (6)  = null ,

	@Qty decimal (8, 2)  = null ,

	@UnitSymb char (3)  = null ,

	@Amount decimal (18, 2)  = null ,

	@Discount decimal (18, 2)  = null ,

	@CarddiscAmt decimal (18, 2)  = null ,

	@VatAmt decimal (18, 2)  = null ,

	@Surplus decimal (18, 2)  = null ,

	@CommisAmt decimal (18, 2)  = null ,

	@ForexCys char (3)  = null ,

	@ForexRate decimal (18, 2)  = null ,

	@ExpiryDt datetime   = null ,

	@UserId decimal (3, 0)  = null ,

	@Station int   = null ,

	@CsId char (5)  = null ,

	@CustaxId nchar (30)  = null ,

	@SafeNameRef varchar (12)  = null ,

	@Remark nvarchar (100)  = null ,

	@Updated bit   = null ,

	@MercType char (2)  = null ,

	@TaxCode char (3)  = null ,

	@VatIncl bit   = null ,

	@Discpervat bit   = null ,

	@DiscIncl bit   = null ,

	@Copies decimal (2, 0)  = null ,

	@Recnum decimal (6, 0)  = null ,

	@CardId nchar (16)  = null ,

	@Shift int   = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [idx]
	, [tran_date]
	, [tran_time]
	, [trans_num]
	, [trans_code]
	, [voucher]
	, [invoice]
	, [post]
	, [exp_id]
	, [imp_id]
	, [goods_id]
	, [kit_qty]
	, [kit_id]
	, [qty]
	, [unit_symb]
	, [amount]
	, [discount]
	, [carddisc_amt]
	, [vat_amt]
	, [surplus]
	, [commis_amt]
	, [forex_cys]
	, [forex_rate]
	, [expiry_dt]
	, [user_id]
	, [station]
	, [cs_id]
	, [custax_id]
	, [ref]
	, [remark]
	, [updated]
	, [merc_type]
	, [tax_code]
	, [vat_incl]
	, [discpervat]
	, [disc_incl]
	, [copies]
	, [recnum]
	, [card_id]
	, [Shift]
	, [Status]
    FROM
	[dbo].[tblTransaction]
    WHERE 
	 ([idx] = @Idx OR @Idx IS NULL)
	AND ([tran_date] = @TranDate OR @TranDate IS NULL)
	AND ([tran_time] = @TranTime OR @TranTime IS NULL)
	AND ([trans_num] = @TransNum OR @TransNum IS NULL)
	AND ([trans_code] = @TransCode OR @TransCode IS NULL)
	AND ([voucher] = @Voucher OR @Voucher IS NULL)
	AND ([invoice] = @Invoice OR @Invoice IS NULL)
	AND ([post] = @Post OR @Post IS NULL)
	AND ([exp_id] = @ExpId OR @ExpId IS NULL)
	AND ([imp_id] = @ImpId OR @ImpId IS NULL)
	AND ([goods_id] = @GoodsId OR @GoodsId IS NULL)
	AND ([kit_qty] = @KitQty OR @KitQty IS NULL)
	AND ([kit_id] = @KitId OR @KitId IS NULL)
	AND ([qty] = @Qty OR @Qty IS NULL)
	AND ([unit_symb] = @UnitSymb OR @UnitSymb IS NULL)
	AND ([amount] = @Amount OR @Amount IS NULL)
	AND ([discount] = @Discount OR @Discount IS NULL)
	AND ([carddisc_amt] = @CarddiscAmt OR @CarddiscAmt IS NULL)
	AND ([vat_amt] = @VatAmt OR @VatAmt IS NULL)
	AND ([surplus] = @Surplus OR @Surplus IS NULL)
	AND ([commis_amt] = @CommisAmt OR @CommisAmt IS NULL)
	AND ([forex_cys] = @ForexCys OR @ForexCys IS NULL)
	AND ([forex_rate] = @ForexRate OR @ForexRate IS NULL)
	AND ([expiry_dt] = @ExpiryDt OR @ExpiryDt IS NULL)
	AND ([user_id] = @UserId OR @UserId IS NULL)
	AND ([station] = @Station OR @Station IS NULL)
	AND ([cs_id] = @CsId OR @CsId IS NULL)
	AND ([custax_id] = @CustaxId OR @CustaxId IS NULL)
	AND ([ref] = @SafeNameRef OR @SafeNameRef IS NULL)
	AND ([remark] = @Remark OR @Remark IS NULL)
	AND ([updated] = @Updated OR @Updated IS NULL)
	AND ([merc_type] = @MercType OR @MercType IS NULL)
	AND ([tax_code] = @TaxCode OR @TaxCode IS NULL)
	AND ([vat_incl] = @VatIncl OR @VatIncl IS NULL)
	AND ([discpervat] = @Discpervat OR @Discpervat IS NULL)
	AND ([disc_incl] = @DiscIncl OR @DiscIncl IS NULL)
	AND ([copies] = @Copies OR @Copies IS NULL)
	AND ([recnum] = @Recnum OR @Recnum IS NULL)
	AND ([card_id] = @CardId OR @CardId IS NULL)
	AND ([Shift] = @Shift OR @Shift IS NULL)
	AND ([Status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [idx]
	, [tran_date]
	, [tran_time]
	, [trans_num]
	, [trans_code]
	, [voucher]
	, [invoice]
	, [post]
	, [exp_id]
	, [imp_id]
	, [goods_id]
	, [kit_qty]
	, [kit_id]
	, [qty]
	, [unit_symb]
	, [amount]
	, [discount]
	, [carddisc_amt]
	, [vat_amt]
	, [surplus]
	, [commis_amt]
	, [forex_cys]
	, [forex_rate]
	, [expiry_dt]
	, [user_id]
	, [station]
	, [cs_id]
	, [custax_id]
	, [ref]
	, [remark]
	, [updated]
	, [merc_type]
	, [tax_code]
	, [vat_incl]
	, [discpervat]
	, [disc_incl]
	, [copies]
	, [recnum]
	, [card_id]
	, [Shift]
	, [Status]
    FROM
	[dbo].[tblTransaction]
    WHERE 
	 ([idx] = @Idx AND @Idx is not null)
	OR ([tran_date] = @TranDate AND @TranDate is not null)
	OR ([tran_time] = @TranTime AND @TranTime is not null)
	OR ([trans_num] = @TransNum AND @TransNum is not null)
	OR ([trans_code] = @TransCode AND @TransCode is not null)
	OR ([voucher] = @Voucher AND @Voucher is not null)
	OR ([invoice] = @Invoice AND @Invoice is not null)
	OR ([post] = @Post AND @Post is not null)
	OR ([exp_id] = @ExpId AND @ExpId is not null)
	OR ([imp_id] = @ImpId AND @ImpId is not null)
	OR ([goods_id] = @GoodsId AND @GoodsId is not null)
	OR ([kit_qty] = @KitQty AND @KitQty is not null)
	OR ([kit_id] = @KitId AND @KitId is not null)
	OR ([qty] = @Qty AND @Qty is not null)
	OR ([unit_symb] = @UnitSymb AND @UnitSymb is not null)
	OR ([amount] = @Amount AND @Amount is not null)
	OR ([discount] = @Discount AND @Discount is not null)
	OR ([carddisc_amt] = @CarddiscAmt AND @CarddiscAmt is not null)
	OR ([vat_amt] = @VatAmt AND @VatAmt is not null)
	OR ([surplus] = @Surplus AND @Surplus is not null)
	OR ([commis_amt] = @CommisAmt AND @CommisAmt is not null)
	OR ([forex_cys] = @ForexCys AND @ForexCys is not null)
	OR ([forex_rate] = @ForexRate AND @ForexRate is not null)
	OR ([expiry_dt] = @ExpiryDt AND @ExpiryDt is not null)
	OR ([user_id] = @UserId AND @UserId is not null)
	OR ([station] = @Station AND @Station is not null)
	OR ([cs_id] = @CsId AND @CsId is not null)
	OR ([custax_id] = @CustaxId AND @CustaxId is not null)
	OR ([ref] = @SafeNameRef AND @SafeNameRef is not null)
	OR ([remark] = @Remark AND @Remark is not null)
	OR ([updated] = @Updated AND @Updated is not null)
	OR ([merc_type] = @MercType AND @MercType is not null)
	OR ([tax_code] = @TaxCode AND @TaxCode is not null)
	OR ([vat_incl] = @VatIncl AND @VatIncl is not null)
	OR ([discpervat] = @Discpervat AND @Discpervat is not null)
	OR ([disc_incl] = @DiscIncl AND @DiscIncl is not null)
	OR ([copies] = @Copies AND @Copies is not null)
	OR ([recnum] = @Recnum AND @Recnum is not null)
	OR ([card_id] = @CardId AND @CardId is not null)
	OR ([Shift] = @Shift AND @Shift is not null)
	OR ([Status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblModePayment_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblModePayment_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblModePayment_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblModePayment table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblModePayment_Get_List

AS


				
				SELECT
					[pmt_mode],
					[description],
					[forex],
					[forex_rate],
					[iscard],
					[status]
				FROM
					[dbo].[tblModePayment]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblModePayment_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblModePayment_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblModePayment_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblModePayment table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblModePayment_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [pmt_mode] nchar(10) , [forex] nchar(3)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([pmt_mode], [forex])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [pmt_mode], [forex]'
				SET @SQL = @SQL + ' FROM [dbo].[tblModePayment]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[pmt_mode], O.[description], O.[forex], O.[forex_rate], O.[iscard], O.[status]
				FROM
				    [dbo].[tblModePayment] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[pmt_mode] = PageIndex.[pmt_mode]
					AND O.[forex] = PageIndex.[forex]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblModePayment]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblModePayment_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblModePayment_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblModePayment_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblModePayment table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblModePayment_Insert
(

	@PmtMode nchar (10)  ,

	@Description nvarchar (100)  ,

	@Forex nchar (3)  ,

	@ForexRate numeric (18, 2)  ,

	@Iscard nchar (1)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblModePayment]
					(
					[pmt_mode]
					,[description]
					,[forex]
					,[forex_rate]
					,[iscard]
					,[status]
					)
				VALUES
					(
					@PmtMode
					,@Description
					,@Forex
					,@ForexRate
					,@Iscard
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblModePayment_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblModePayment_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblModePayment_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblModePayment table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblModePayment_Update
(

	@PmtMode nchar (10)  ,

	@OriginalPmtMode nchar (10)  ,

	@Description nvarchar (100)  ,

	@Forex nchar (3)  ,

	@OriginalForex nchar (3)  ,

	@ForexRate numeric (18, 2)  ,

	@Iscard nchar (1)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblModePayment]
				SET
					[pmt_mode] = @PmtMode
					,[description] = @Description
					,[forex] = @Forex
					,[forex_rate] = @ForexRate
					,[iscard] = @Iscard
					,[status] = @Status
				WHERE
[pmt_mode] = @OriginalPmtMode 
AND [forex] = @OriginalForex 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblModePayment_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblModePayment_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblModePayment_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblModePayment table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblModePayment_Delete
(

	@PmtMode nchar (10)  ,

	@Forex nchar (3)  
)
AS


				DELETE FROM [dbo].[tblModePayment] WITH (ROWLOCK) 
				WHERE
					[pmt_mode] = @PmtMode
					AND [forex] = @Forex
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblModePayment_GetByPmtModeForex procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblModePayment_GetByPmtModeForex') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblModePayment_GetByPmtModeForex
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblModePayment table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblModePayment_GetByPmtModeForex
(

	@PmtMode nchar (10)  ,

	@Forex nchar (3)  
)
AS


				SELECT
					[pmt_mode],
					[description],
					[forex],
					[forex_rate],
					[iscard],
					[status]
				FROM
					[dbo].[tblModePayment]
				WHERE
					[pmt_mode] = @PmtMode
					AND [forex] = @Forex
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblModePayment_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblModePayment_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblModePayment_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblModePayment table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblModePayment_Find
(

	@SearchUsingOR bit   = null ,

	@PmtMode nchar (10)  = null ,

	@Description nvarchar (100)  = null ,

	@Forex nchar (3)  = null ,

	@ForexRate numeric (18, 2)  = null ,

	@Iscard nchar (1)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [pmt_mode]
	, [description]
	, [forex]
	, [forex_rate]
	, [iscard]
	, [status]
    FROM
	[dbo].[tblModePayment]
    WHERE 
	 ([pmt_mode] = @PmtMode OR @PmtMode IS NULL)
	AND ([description] = @Description OR @Description IS NULL)
	AND ([forex] = @Forex OR @Forex IS NULL)
	AND ([forex_rate] = @ForexRate OR @ForexRate IS NULL)
	AND ([iscard] = @Iscard OR @Iscard IS NULL)
	AND ([status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [pmt_mode]
	, [description]
	, [forex]
	, [forex_rate]
	, [iscard]
	, [status]
    FROM
	[dbo].[tblModePayment]
    WHERE 
	 ([pmt_mode] = @PmtMode AND @PmtMode is not null)
	OR ([description] = @Description AND @Description is not null)
	OR ([forex] = @Forex AND @Forex is not null)
	OR ([forex_rate] = @ForexRate AND @ForexRate is not null)
	OR ([iscard] = @Iscard AND @Iscard is not null)
	OR ([status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransnum_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransnum_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransnum_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblTransnum table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransnum_Get_List

AS


				
				SELECT
					[trans_type],
					[last_num],
					[last_date]
				FROM
					[dbo].[tblTransnum]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransnum_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransnum_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransnum_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblTransnum table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransnum_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [trans_type] char(4)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([trans_type])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [trans_type]'
				SET @SQL = @SQL + ' FROM [dbo].[tblTransnum]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[trans_type], O.[last_num], O.[last_date]
				FROM
				    [dbo].[tblTransnum] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[trans_type] = PageIndex.[trans_type]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblTransnum]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransnum_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransnum_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransnum_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblTransnum table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransnum_Insert
(

	@TransType char (4)  ,

	@LastNum decimal (18, 0)  ,

	@LastDate datetime   
)
AS


				
				INSERT INTO [dbo].[tblTransnum]
					(
					[trans_type]
					,[last_num]
					,[last_date]
					)
				VALUES
					(
					@TransType
					,@LastNum
					,@LastDate
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransnum_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransnum_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransnum_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblTransnum table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransnum_Update
(

	@TransType char (4)  ,

	@OriginalTransType char (4)  ,

	@LastNum decimal (18, 0)  ,

	@LastDate datetime   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblTransnum]
				SET
					[trans_type] = @TransType
					,[last_num] = @LastNum
					,[last_date] = @LastDate
				WHERE
[trans_type] = @OriginalTransType 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransnum_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransnum_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransnum_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblTransnum table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransnum_Delete
(

	@TransType char (4)  
)
AS


				DELETE FROM [dbo].[tblTransnum] WITH (ROWLOCK) 
				WHERE
					[trans_type] = @TransType
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransnum_GetByTransType procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransnum_GetByTransType') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransnum_GetByTransType
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblTransnum table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransnum_GetByTransType
(

	@TransType char (4)  
)
AS


				SELECT
					[trans_type],
					[last_num],
					[last_date]
				FROM
					[dbo].[tblTransnum]
				WHERE
					[trans_type] = @TransType
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblTransnum_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblTransnum_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblTransnum_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblTransnum table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblTransnum_Find
(

	@SearchUsingOR bit   = null ,

	@TransType char (4)  = null ,

	@LastNum decimal (18, 0)  = null ,

	@LastDate datetime   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [trans_type]
	, [last_num]
	, [last_date]
    FROM
	[dbo].[tblTransnum]
    WHERE 
	 ([trans_type] = @TransType OR @TransType IS NULL)
	AND ([last_num] = @LastNum OR @LastNum IS NULL)
	AND ([last_date] = @LastDate OR @LastDate IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [trans_type]
	, [last_num]
	, [last_date]
    FROM
	[dbo].[tblTransnum]
    WHERE 
	 ([trans_type] = @TransType AND @TransType is not null)
	OR ([last_num] = @LastNum AND @LastNum is not null)
	OR ([last_date] = @LastDate AND @LastDate is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMercLocation_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMercLocation_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMercLocation_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblMercLocation table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMercLocation_Get_List

AS


				
				SELECT
					[idx],
					[stk_id],
					[loc_id],
					[goods_id],
					[check]
				FROM
					[dbo].[tblMercLocation]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMercLocation_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMercLocation_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMercLocation_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblMercLocation table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMercLocation_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [idx] numeric(18, 0) 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([idx])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [idx]'
				SET @SQL = @SQL + ' FROM [dbo].[tblMercLocation]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[idx], O.[stk_id], O.[loc_id], O.[goods_id], O.[check]
				FROM
				    [dbo].[tblMercLocation] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[idx] = PageIndex.[idx]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblMercLocation]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMercLocation_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMercLocation_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMercLocation_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblMercLocation table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMercLocation_Insert
(

	@Idx numeric (18, 0)   OUTPUT,

	@StkId nchar (5)  ,

	@LocId nchar (4)  ,

	@GoodsId nchar (6)  ,

	@Check bit   
)
AS


				
				INSERT INTO [dbo].[tblMercLocation]
					(
					[stk_id]
					,[loc_id]
					,[goods_id]
					,[check]
					)
				VALUES
					(
					@StkId
					,@LocId
					,@GoodsId
					,@Check
					)
				-- Get the identity value
				SET @Idx = SCOPE_IDENTITY()
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMercLocation_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMercLocation_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMercLocation_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblMercLocation table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMercLocation_Update
(

	@Idx numeric (18, 0)  ,

	@StkId nchar (5)  ,

	@LocId nchar (4)  ,

	@GoodsId nchar (6)  ,

	@Check bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblMercLocation]
				SET
					[stk_id] = @StkId
					,[loc_id] = @LocId
					,[goods_id] = @GoodsId
					,[check] = @Check
				WHERE
[idx] = @Idx 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMercLocation_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMercLocation_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMercLocation_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblMercLocation table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMercLocation_Delete
(

	@Idx numeric (18, 0)  
)
AS


				DELETE FROM [dbo].[tblMercLocation] WITH (ROWLOCK) 
				WHERE
					[idx] = @Idx
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMercLocation_GetByIdx procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMercLocation_GetByIdx') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMercLocation_GetByIdx
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblMercLocation table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMercLocation_GetByIdx
(

	@Idx numeric (18, 0)  
)
AS


				SELECT
					[idx],
					[stk_id],
					[loc_id],
					[goods_id],
					[check]
				FROM
					[dbo].[tblMercLocation]
				WHERE
					[idx] = @Idx
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMercLocation_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMercLocation_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMercLocation_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblMercLocation table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMercLocation_Find
(

	@SearchUsingOR bit   = null ,

	@Idx numeric (18, 0)  = null ,

	@StkId nchar (5)  = null ,

	@LocId nchar (4)  = null ,

	@GoodsId nchar (6)  = null ,

	@Check bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [idx]
	, [stk_id]
	, [loc_id]
	, [goods_id]
	, [check]
    FROM
	[dbo].[tblMercLocation]
    WHERE 
	 ([idx] = @Idx OR @Idx IS NULL)
	AND ([stk_id] = @StkId OR @StkId IS NULL)
	AND ([loc_id] = @LocId OR @LocId IS NULL)
	AND ([goods_id] = @GoodsId OR @GoodsId IS NULL)
	AND ([check] = @Check OR @Check IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [idx]
	, [stk_id]
	, [loc_id]
	, [goods_id]
	, [check]
    FROM
	[dbo].[tblMercLocation]
    WHERE 
	 ([idx] = @Idx AND @Idx is not null)
	OR ([stk_id] = @StkId AND @StkId is not null)
	OR ([loc_id] = @LocId AND @LocId is not null)
	OR ([goods_id] = @GoodsId AND @GoodsId is not null)
	OR ([check] = @Check AND @Check is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCurrency_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCurrency_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCurrency_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblCurrency table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCurrency_Get_List

AS


				
				SELECT
					[id],
					[Description],
					[Exchange],
					[Status]
				FROM
					[dbo].[tblCurrency]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCurrency_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCurrency_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCurrency_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblCurrency table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCurrency_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] nvarchar(3)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblCurrency]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[Description], O.[Exchange], O.[Status]
				FROM
				    [dbo].[tblCurrency] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblCurrency]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCurrency_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCurrency_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCurrency_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblCurrency table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCurrency_Insert
(

	@Id nvarchar (3)  ,

	@Description nvarchar (50)  ,

	@Exchange decimal (18, 3)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblCurrency]
					(
					[id]
					,[Description]
					,[Exchange]
					,[Status]
					)
				VALUES
					(
					@Id
					,@Description
					,@Exchange
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCurrency_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCurrency_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCurrency_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblCurrency table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCurrency_Update
(

	@Id nvarchar (3)  ,

	@OriginalId nvarchar (3)  ,

	@Description nvarchar (50)  ,

	@Exchange decimal (18, 3)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblCurrency]
				SET
					[id] = @Id
					,[Description] = @Description
					,[Exchange] = @Exchange
					,[Status] = @Status
				WHERE
[id] = @OriginalId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCurrency_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCurrency_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCurrency_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblCurrency table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCurrency_Delete
(

	@Id nvarchar (3)  
)
AS


				DELETE FROM [dbo].[tblCurrency] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCurrency_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCurrency_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCurrency_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblCurrency table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCurrency_GetById
(

	@Id nvarchar (3)  
)
AS


				SELECT
					[id],
					[Description],
					[Exchange],
					[Status]
				FROM
					[dbo].[tblCurrency]
				WHERE
					[id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCurrency_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCurrency_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCurrency_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblCurrency table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCurrency_Find
(

	@SearchUsingOR bit   = null ,

	@Id nvarchar (3)  = null ,

	@Description nvarchar (50)  = null ,

	@Exchange decimal (18, 3)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [Description]
	, [Exchange]
	, [Status]
    FROM
	[dbo].[tblCurrency]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([Description] = @Description OR @Description IS NULL)
	AND ([Exchange] = @Exchange OR @Exchange IS NULL)
	AND ([Status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [Description]
	, [Exchange]
	, [Status]
    FROM
	[dbo].[tblCurrency]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([Description] = @Description AND @Description is not null)
	OR ([Exchange] = @Exchange AND @Exchange is not null)
	OR ([Status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMenus_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMenus_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMenus_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblMenus table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMenus_Get_List

AS


				
				SELECT
					[id],
					[subitem],
					[parent],
					[menukey],
					[prompt],
					[type],
					[procerdue],
					[imageidx],
					[password],
					[basicright],
					[depcode],
					[skip]
				FROM
					[dbo].[tblMenus]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMenus_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMenus_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMenus_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblMenus table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMenus_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] int 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblMenus]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[subitem], O.[parent], O.[menukey], O.[prompt], O.[type], O.[procerdue], O.[imageidx], O.[password], O.[basicright], O.[depcode], O.[skip]
				FROM
				    [dbo].[tblMenus] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblMenus]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMenus_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMenus_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMenus_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblMenus table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMenus_Insert
(

	@Id int    OUTPUT,

	@Subitem int   ,

	@Parent int   ,

	@Menukey nchar (30)  ,

	@Prompt nvarchar (200)  ,

	@Type nchar (1)  ,

	@Procerdue nchar (40)  ,

	@Imageidx int   ,

	@Password bit   ,

	@Basicright int   ,

	@Depcode nchar (1)  ,

	@Skip bit   
)
AS


				
				INSERT INTO [dbo].[tblMenus]
					(
					[subitem]
					,[parent]
					,[menukey]
					,[prompt]
					,[type]
					,[procerdue]
					,[imageidx]
					,[password]
					,[basicright]
					,[depcode]
					,[skip]
					)
				VALUES
					(
					@Subitem
					,@Parent
					,@Menukey
					,@Prompt
					,@Type
					,@Procerdue
					,@Imageidx
					,@Password
					,@Basicright
					,@Depcode
					,@Skip
					)
				-- Get the identity value
				SET @Id = SCOPE_IDENTITY()
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMenus_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMenus_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMenus_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblMenus table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMenus_Update
(

	@Id int   ,

	@Subitem int   ,

	@Parent int   ,

	@Menukey nchar (30)  ,

	@Prompt nvarchar (200)  ,

	@Type nchar (1)  ,

	@Procerdue nchar (40)  ,

	@Imageidx int   ,

	@Password bit   ,

	@Basicright int   ,

	@Depcode nchar (1)  ,

	@Skip bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblMenus]
				SET
					[subitem] = @Subitem
					,[parent] = @Parent
					,[menukey] = @Menukey
					,[prompt] = @Prompt
					,[type] = @Type
					,[procerdue] = @Procerdue
					,[imageidx] = @Imageidx
					,[password] = @Password
					,[basicright] = @Basicright
					,[depcode] = @Depcode
					,[skip] = @Skip
				WHERE
[id] = @Id 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMenus_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMenus_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMenus_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblMenus table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMenus_Delete
(

	@Id int   
)
AS


				DELETE FROM [dbo].[tblMenus] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMenus_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMenus_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMenus_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblMenus table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMenus_GetById
(

	@Id int   
)
AS


				SELECT
					[id],
					[subitem],
					[parent],
					[menukey],
					[prompt],
					[type],
					[procerdue],
					[imageidx],
					[password],
					[basicright],
					[depcode],
					[skip]
				FROM
					[dbo].[tblMenus]
				WHERE
					[id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblMenus_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblMenus_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblMenus_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblMenus table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblMenus_Find
(

	@SearchUsingOR bit   = null ,

	@Id int   = null ,

	@Subitem int   = null ,

	@Parent int   = null ,

	@Menukey nchar (30)  = null ,

	@Prompt nvarchar (200)  = null ,

	@Type nchar (1)  = null ,

	@Procerdue nchar (40)  = null ,

	@Imageidx int   = null ,

	@Password bit   = null ,

	@Basicright int   = null ,

	@Depcode nchar (1)  = null ,

	@Skip bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [subitem]
	, [parent]
	, [menukey]
	, [prompt]
	, [type]
	, [procerdue]
	, [imageidx]
	, [password]
	, [basicright]
	, [depcode]
	, [skip]
    FROM
	[dbo].[tblMenus]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([subitem] = @Subitem OR @Subitem IS NULL)
	AND ([parent] = @Parent OR @Parent IS NULL)
	AND ([menukey] = @Menukey OR @Menukey IS NULL)
	AND ([prompt] = @Prompt OR @Prompt IS NULL)
	AND ([type] = @Type OR @Type IS NULL)
	AND ([procerdue] = @Procerdue OR @Procerdue IS NULL)
	AND ([imageidx] = @Imageidx OR @Imageidx IS NULL)
	AND ([password] = @Password OR @Password IS NULL)
	AND ([basicright] = @Basicright OR @Basicright IS NULL)
	AND ([depcode] = @Depcode OR @Depcode IS NULL)
	AND ([skip] = @Skip OR @Skip IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [subitem]
	, [parent]
	, [menukey]
	, [prompt]
	, [type]
	, [procerdue]
	, [imageidx]
	, [password]
	, [basicright]
	, [depcode]
	, [skip]
    FROM
	[dbo].[tblMenus]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([subitem] = @Subitem AND @Subitem is not null)
	OR ([parent] = @Parent AND @Parent is not null)
	OR ([menukey] = @Menukey AND @Menukey is not null)
	OR ([prompt] = @Prompt AND @Prompt is not null)
	OR ([type] = @Type AND @Type is not null)
	OR ([procerdue] = @Procerdue AND @Procerdue is not null)
	OR ([imageidx] = @Imageidx AND @Imageidx is not null)
	OR ([password] = @Password AND @Password is not null)
	OR ([basicright] = @Basicright AND @Basicright is not null)
	OR ([depcode] = @Depcode AND @Depcode is not null)
	OR ([skip] = @Skip AND @Skip is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCust_info_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCust_info_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCust_info_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblCust_info table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCust_info_Get_List

AS


				
				SELECT
					[Cust_id],
					[goods_id],
					[imp_qty],
					[imp_amt],
					[exp_qty],
					[exp_amt],
					[lastwspr],
					[last_date]
				FROM
					[dbo].[tblCust_info]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCust_info_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCust_info_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCust_info_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblCust_info table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCust_info_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [Cust_id] nchar(5) , [goods_id] nchar(6)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([Cust_id], [goods_id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [Cust_id], [goods_id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblCust_info]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[Cust_id], O.[goods_id], O.[imp_qty], O.[imp_amt], O.[exp_qty], O.[exp_amt], O.[lastwspr], O.[last_date]
				FROM
				    [dbo].[tblCust_info] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[Cust_id] = PageIndex.[Cust_id]
					AND O.[goods_id] = PageIndex.[goods_id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblCust_info]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCust_info_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCust_info_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCust_info_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblCust_info table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCust_info_Insert
(

	@CustId nchar (5)  ,

	@GoodsId nchar (6)  ,

	@ImpQty decimal (18, 0)  ,

	@ImpAmt decimal (18, 2)  ,

	@ExpQty decimal (18, 0)  ,

	@ExpAmt decimal (18, 2)  ,

	@Lastwspr decimal (18, 2)  ,

	@LastDate datetime   
)
AS


				
				INSERT INTO [dbo].[tblCust_info]
					(
					[Cust_id]
					,[goods_id]
					,[imp_qty]
					,[imp_amt]
					,[exp_qty]
					,[exp_amt]
					,[lastwspr]
					,[last_date]
					)
				VALUES
					(
					@CustId
					,@GoodsId
					,@ImpQty
					,@ImpAmt
					,@ExpQty
					,@ExpAmt
					,@Lastwspr
					,@LastDate
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCust_info_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCust_info_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCust_info_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblCust_info table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCust_info_Update
(

	@CustId nchar (5)  ,

	@OriginalCustId nchar (5)  ,

	@GoodsId nchar (6)  ,

	@OriginalGoodsId nchar (6)  ,

	@ImpQty decimal (18, 0)  ,

	@ImpAmt decimal (18, 2)  ,

	@ExpQty decimal (18, 0)  ,

	@ExpAmt decimal (18, 2)  ,

	@Lastwspr decimal (18, 2)  ,

	@LastDate datetime   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblCust_info]
				SET
					[Cust_id] = @CustId
					,[goods_id] = @GoodsId
					,[imp_qty] = @ImpQty
					,[imp_amt] = @ImpAmt
					,[exp_qty] = @ExpQty
					,[exp_amt] = @ExpAmt
					,[lastwspr] = @Lastwspr
					,[last_date] = @LastDate
				WHERE
[Cust_id] = @OriginalCustId 
AND [goods_id] = @OriginalGoodsId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCust_info_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCust_info_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCust_info_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblCust_info table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCust_info_Delete
(

	@CustId nchar (5)  ,

	@GoodsId nchar (6)  
)
AS


				DELETE FROM [dbo].[tblCust_info] WITH (ROWLOCK) 
				WHERE
					[Cust_id] = @CustId
					AND [goods_id] = @GoodsId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCust_info_GetByCustIdGoodsId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCust_info_GetByCustIdGoodsId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCust_info_GetByCustIdGoodsId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblCust_info table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCust_info_GetByCustIdGoodsId
(

	@CustId nchar (5)  ,

	@GoodsId nchar (6)  
)
AS


				SELECT
					[Cust_id],
					[goods_id],
					[imp_qty],
					[imp_amt],
					[exp_qty],
					[exp_amt],
					[lastwspr],
					[last_date]
				FROM
					[dbo].[tblCust_info]
				WHERE
					[Cust_id] = @CustId
					AND [goods_id] = @GoodsId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCust_info_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCust_info_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCust_info_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblCust_info table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCust_info_Find
(

	@SearchUsingOR bit   = null ,

	@CustId nchar (5)  = null ,

	@GoodsId nchar (6)  = null ,

	@ImpQty decimal (18, 0)  = null ,

	@ImpAmt decimal (18, 2)  = null ,

	@ExpQty decimal (18, 0)  = null ,

	@ExpAmt decimal (18, 2)  = null ,

	@Lastwspr decimal (18, 2)  = null ,

	@LastDate datetime   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [Cust_id]
	, [goods_id]
	, [imp_qty]
	, [imp_amt]
	, [exp_qty]
	, [exp_amt]
	, [lastwspr]
	, [last_date]
    FROM
	[dbo].[tblCust_info]
    WHERE 
	 ([Cust_id] = @CustId OR @CustId IS NULL)
	AND ([goods_id] = @GoodsId OR @GoodsId IS NULL)
	AND ([imp_qty] = @ImpQty OR @ImpQty IS NULL)
	AND ([imp_amt] = @ImpAmt OR @ImpAmt IS NULL)
	AND ([exp_qty] = @ExpQty OR @ExpQty IS NULL)
	AND ([exp_amt] = @ExpAmt OR @ExpAmt IS NULL)
	AND ([lastwspr] = @Lastwspr OR @Lastwspr IS NULL)
	AND ([last_date] = @LastDate OR @LastDate IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [Cust_id]
	, [goods_id]
	, [imp_qty]
	, [imp_amt]
	, [exp_qty]
	, [exp_amt]
	, [lastwspr]
	, [last_date]
    FROM
	[dbo].[tblCust_info]
    WHERE 
	 ([Cust_id] = @CustId AND @CustId is not null)
	OR ([goods_id] = @GoodsId AND @GoodsId is not null)
	OR ([imp_qty] = @ImpQty AND @ImpQty is not null)
	OR ([imp_amt] = @ImpAmt AND @ImpAmt is not null)
	OR ([exp_qty] = @ExpQty AND @ExpQty is not null)
	OR ([exp_amt] = @ExpAmt AND @ExpAmt is not null)
	OR ([lastwspr] = @Lastwspr AND @Lastwspr is not null)
	OR ([last_date] = @LastDate AND @LastDate is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCsCard_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCsCard_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCsCard_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblCsCard table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCsCard_Get_List

AS


				
				SELECT
					[card_id],
					[is_vip],
					[cs_sex],
					[person_id],
					[birthday],
					[ps_issuedate],
					[ps_placeissuse],
					[fullname],
					[address],
					[phone],
					[email],
					[disc_pc],
					[iss_date],
					[due_date],
					[image],
					[remark],
					[begmark],
					[endmark],
					[status]
				FROM
					[dbo].[tblCsCard]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCsCard_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCsCard_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCsCard_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblCsCard table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCsCard_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [card_id] char(8)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([card_id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [card_id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblCsCard]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[card_id], O.[is_vip], O.[cs_sex], O.[person_id], O.[birthday], O.[ps_issuedate], O.[ps_placeissuse], O.[fullname], O.[address], O.[phone], O.[email], O.[disc_pc], O.[iss_date], O.[due_date], O.[image], O.[remark], O.[begmark], O.[endmark], O.[status]
				FROM
				    [dbo].[tblCsCard] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[card_id] = PageIndex.[card_id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblCsCard]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCsCard_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCsCard_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCsCard_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblCsCard table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCsCard_Insert
(

	@CardId char (8)  ,

	@IsVip bit   ,

	@CsSex bit   ,

	@PersonId char (20)  ,

	@Birthday datetime   ,

	@PsIssuedate datetime   ,

	@PsPlaceissuse nchar (100)  ,

	@Fullname nvarchar (100)  ,

	@Address nvarchar (300)  ,

	@Phone varchar (50)  ,

	@Email varchar (200)  ,

	@DiscPc decimal (5, 2)  ,

	@IssDate datetime   ,

	@DueDate datetime   ,

	@Image image   ,

	@Remark nvarchar (300)  ,

	@Begmark numeric (18, 0)  ,

	@Endmark numeric (18, 0)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblCsCard]
					(
					[card_id]
					,[is_vip]
					,[cs_sex]
					,[person_id]
					,[birthday]
					,[ps_issuedate]
					,[ps_placeissuse]
					,[fullname]
					,[address]
					,[phone]
					,[email]
					,[disc_pc]
					,[iss_date]
					,[due_date]
					,[image]
					,[remark]
					,[begmark]
					,[endmark]
					,[status]
					)
				VALUES
					(
					@CardId
					,@IsVip
					,@CsSex
					,@PersonId
					,@Birthday
					,@PsIssuedate
					,@PsPlaceissuse
					,@Fullname
					,@Address
					,@Phone
					,@Email
					,@DiscPc
					,@IssDate
					,@DueDate
					,@Image
					,@Remark
					,@Begmark
					,@Endmark
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCsCard_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCsCard_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCsCard_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblCsCard table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCsCard_Update
(

	@CardId char (8)  ,

	@OriginalCardId char (8)  ,

	@IsVip bit   ,

	@CsSex bit   ,

	@PersonId char (20)  ,

	@Birthday datetime   ,

	@PsIssuedate datetime   ,

	@PsPlaceissuse nchar (100)  ,

	@Fullname nvarchar (100)  ,

	@Address nvarchar (300)  ,

	@Phone varchar (50)  ,

	@Email varchar (200)  ,

	@DiscPc decimal (5, 2)  ,

	@IssDate datetime   ,

	@DueDate datetime   ,

	@Image image   ,

	@Remark nvarchar (300)  ,

	@Begmark numeric (18, 0)  ,

	@Endmark numeric (18, 0)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblCsCard]
				SET
					[card_id] = @CardId
					,[is_vip] = @IsVip
					,[cs_sex] = @CsSex
					,[person_id] = @PersonId
					,[birthday] = @Birthday
					,[ps_issuedate] = @PsIssuedate
					,[ps_placeissuse] = @PsPlaceissuse
					,[fullname] = @Fullname
					,[address] = @Address
					,[phone] = @Phone
					,[email] = @Email
					,[disc_pc] = @DiscPc
					,[iss_date] = @IssDate
					,[due_date] = @DueDate
					,[image] = @Image
					,[remark] = @Remark
					,[begmark] = @Begmark
					,[endmark] = @Endmark
					,[status] = @Status
				WHERE
[card_id] = @OriginalCardId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCsCard_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCsCard_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCsCard_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblCsCard table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCsCard_Delete
(

	@CardId char (8)  
)
AS


				DELETE FROM [dbo].[tblCsCard] WITH (ROWLOCK) 
				WHERE
					[card_id] = @CardId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCsCard_GetByCardId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCsCard_GetByCardId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCsCard_GetByCardId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblCsCard table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCsCard_GetByCardId
(

	@CardId char (8)  
)
AS


				SELECT
					[card_id],
					[is_vip],
					[cs_sex],
					[person_id],
					[birthday],
					[ps_issuedate],
					[ps_placeissuse],
					[fullname],
					[address],
					[phone],
					[email],
					[disc_pc],
					[iss_date],
					[due_date],
					[image],
					[remark],
					[begmark],
					[endmark],
					[status]
				FROM
					[dbo].[tblCsCard]
				WHERE
					[card_id] = @CardId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCsCard_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCsCard_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCsCard_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblCsCard table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCsCard_Find
(

	@SearchUsingOR bit   = null ,

	@CardId char (8)  = null ,

	@IsVip bit   = null ,

	@CsSex bit   = null ,

	@PersonId char (20)  = null ,

	@Birthday datetime   = null ,

	@PsIssuedate datetime   = null ,

	@PsPlaceissuse nchar (100)  = null ,

	@Fullname nvarchar (100)  = null ,

	@Address nvarchar (300)  = null ,

	@Phone varchar (50)  = null ,

	@Email varchar (200)  = null ,

	@DiscPc decimal (5, 2)  = null ,

	@IssDate datetime   = null ,

	@DueDate datetime   = null ,

	@Image image   = null ,

	@Remark nvarchar (300)  = null ,

	@Begmark numeric (18, 0)  = null ,

	@Endmark numeric (18, 0)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [card_id]
	, [is_vip]
	, [cs_sex]
	, [person_id]
	, [birthday]
	, [ps_issuedate]
	, [ps_placeissuse]
	, [fullname]
	, [address]
	, [phone]
	, [email]
	, [disc_pc]
	, [iss_date]
	, [due_date]
	, [image]
	, [remark]
	, [begmark]
	, [endmark]
	, [status]
    FROM
	[dbo].[tblCsCard]
    WHERE 
	 ([card_id] = @CardId OR @CardId IS NULL)
	AND ([is_vip] = @IsVip OR @IsVip IS NULL)
	AND ([cs_sex] = @CsSex OR @CsSex IS NULL)
	AND ([person_id] = @PersonId OR @PersonId IS NULL)
	AND ([birthday] = @Birthday OR @Birthday IS NULL)
	AND ([ps_issuedate] = @PsIssuedate OR @PsIssuedate IS NULL)
	AND ([ps_placeissuse] = @PsPlaceissuse OR @PsPlaceissuse IS NULL)
	AND ([fullname] = @Fullname OR @Fullname IS NULL)
	AND ([address] = @Address OR @Address IS NULL)
	AND ([phone] = @Phone OR @Phone IS NULL)
	AND ([email] = @Email OR @Email IS NULL)
	AND ([disc_pc] = @DiscPc OR @DiscPc IS NULL)
	AND ([iss_date] = @IssDate OR @IssDate IS NULL)
	AND ([due_date] = @DueDate OR @DueDate IS NULL)
	AND ([remark] = @Remark OR @Remark IS NULL)
	AND ([begmark] = @Begmark OR @Begmark IS NULL)
	AND ([endmark] = @Endmark OR @Endmark IS NULL)
	AND ([status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [card_id]
	, [is_vip]
	, [cs_sex]
	, [person_id]
	, [birthday]
	, [ps_issuedate]
	, [ps_placeissuse]
	, [fullname]
	, [address]
	, [phone]
	, [email]
	, [disc_pc]
	, [iss_date]
	, [due_date]
	, [image]
	, [remark]
	, [begmark]
	, [endmark]
	, [status]
    FROM
	[dbo].[tblCsCard]
    WHERE 
	 ([card_id] = @CardId AND @CardId is not null)
	OR ([is_vip] = @IsVip AND @IsVip is not null)
	OR ([cs_sex] = @CsSex AND @CsSex is not null)
	OR ([person_id] = @PersonId AND @PersonId is not null)
	OR ([birthday] = @Birthday AND @Birthday is not null)
	OR ([ps_issuedate] = @PsIssuedate AND @PsIssuedate is not null)
	OR ([ps_placeissuse] = @PsPlaceissuse AND @PsPlaceissuse is not null)
	OR ([fullname] = @Fullname AND @Fullname is not null)
	OR ([address] = @Address AND @Address is not null)
	OR ([phone] = @Phone AND @Phone is not null)
	OR ([email] = @Email AND @Email is not null)
	OR ([disc_pc] = @DiscPc AND @DiscPc is not null)
	OR ([iss_date] = @IssDate AND @IssDate is not null)
	OR ([due_date] = @DueDate AND @DueDate is not null)
	OR ([remark] = @Remark AND @Remark is not null)
	OR ([begmark] = @Begmark AND @Begmark is not null)
	OR ([endmark] = @Endmark AND @Endmark is not null)
	OR ([status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCustomer_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCustomer_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCustomer_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblCustomer table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCustomer_Get_List

AS


				
				SELECT
					[id],
					[Type],
					[fullname],
					[address],
					[phone],
					[fax],
					[person_id],
					[place_issue],
					[email],
					[due_date],
					[image],
					[bankname],
					[bank_br],
					[accnum],
					[Vatnum],
					[contactps],
					[remark],
					[open_date],
					[Status]
				FROM
					[dbo].[tblCustomer]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCustomer_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCustomer_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCustomer_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblCustomer table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCustomer_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] char(8)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblCustomer]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[Type], O.[fullname], O.[address], O.[phone], O.[fax], O.[person_id], O.[place_issue], O.[email], O.[due_date], O.[image], O.[bankname], O.[bank_br], O.[accnum], O.[Vatnum], O.[contactps], O.[remark], O.[open_date], O.[Status]
				FROM
				    [dbo].[tblCustomer] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblCustomer]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCustomer_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCustomer_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCustomer_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblCustomer table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCustomer_Insert
(

	@Id char (8)  ,

	@Type int   ,

	@Fullname nvarchar (200)  ,

	@Address nvarchar (500)  ,

	@Phone nvarchar (100)  ,

	@Fax nvarchar (50)  ,

	@PersonId nchar (30)  ,

	@PlaceIssue nvarchar (150)  ,

	@Email nchar (100)  ,

	@DueDate datetime   ,

	@Image image   ,

	@Bankname nvarchar (150)  ,

	@BankBr nvarchar (150)  ,

	@Accnum nvarchar (50)  ,

	@Vatnum nvarchar (50)  ,

	@Contactps nvarchar (50)  ,

	@Remark nvarchar (500)  ,

	@OpenDate datetime   ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblCustomer]
					(
					[id]
					,[Type]
					,[fullname]
					,[address]
					,[phone]
					,[fax]
					,[person_id]
					,[place_issue]
					,[email]
					,[due_date]
					,[image]
					,[bankname]
					,[bank_br]
					,[accnum]
					,[Vatnum]
					,[contactps]
					,[remark]
					,[open_date]
					,[Status]
					)
				VALUES
					(
					@Id
					,@Type
					,@Fullname
					,@Address
					,@Phone
					,@Fax
					,@PersonId
					,@PlaceIssue
					,@Email
					,@DueDate
					,@Image
					,@Bankname
					,@BankBr
					,@Accnum
					,@Vatnum
					,@Contactps
					,@Remark
					,@OpenDate
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCustomer_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCustomer_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCustomer_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblCustomer table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCustomer_Update
(

	@Id char (8)  ,

	@OriginalId char (8)  ,

	@Type int   ,

	@Fullname nvarchar (200)  ,

	@Address nvarchar (500)  ,

	@Phone nvarchar (100)  ,

	@Fax nvarchar (50)  ,

	@PersonId nchar (30)  ,

	@PlaceIssue nvarchar (150)  ,

	@Email nchar (100)  ,

	@DueDate datetime   ,

	@Image image   ,

	@Bankname nvarchar (150)  ,

	@BankBr nvarchar (150)  ,

	@Accnum nvarchar (50)  ,

	@Vatnum nvarchar (50)  ,

	@Contactps nvarchar (50)  ,

	@Remark nvarchar (500)  ,

	@OpenDate datetime   ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblCustomer]
				SET
					[id] = @Id
					,[Type] = @Type
					,[fullname] = @Fullname
					,[address] = @Address
					,[phone] = @Phone
					,[fax] = @Fax
					,[person_id] = @PersonId
					,[place_issue] = @PlaceIssue
					,[email] = @Email
					,[due_date] = @DueDate
					,[image] = @Image
					,[bankname] = @Bankname
					,[bank_br] = @BankBr
					,[accnum] = @Accnum
					,[Vatnum] = @Vatnum
					,[contactps] = @Contactps
					,[remark] = @Remark
					,[open_date] = @OpenDate
					,[Status] = @Status
				WHERE
[id] = @OriginalId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCustomer_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCustomer_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCustomer_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblCustomer table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCustomer_Delete
(

	@Id char (8)  
)
AS


				DELETE FROM [dbo].[tblCustomer] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCustomer_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCustomer_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCustomer_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblCustomer table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCustomer_GetById
(

	@Id char (8)  
)
AS


				SELECT
					[id],
					[Type],
					[fullname],
					[address],
					[phone],
					[fax],
					[person_id],
					[place_issue],
					[email],
					[due_date],
					[image],
					[bankname],
					[bank_br],
					[accnum],
					[Vatnum],
					[contactps],
					[remark],
					[open_date],
					[Status]
				FROM
					[dbo].[tblCustomer]
				WHERE
					[id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblCustomer_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblCustomer_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblCustomer_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblCustomer table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblCustomer_Find
(

	@SearchUsingOR bit   = null ,

	@Id char (8)  = null ,

	@Type int   = null ,

	@Fullname nvarchar (200)  = null ,

	@Address nvarchar (500)  = null ,

	@Phone nvarchar (100)  = null ,

	@Fax nvarchar (50)  = null ,

	@PersonId nchar (30)  = null ,

	@PlaceIssue nvarchar (150)  = null ,

	@Email nchar (100)  = null ,

	@DueDate datetime   = null ,

	@Image image   = null ,

	@Bankname nvarchar (150)  = null ,

	@BankBr nvarchar (150)  = null ,

	@Accnum nvarchar (50)  = null ,

	@Vatnum nvarchar (50)  = null ,

	@Contactps nvarchar (50)  = null ,

	@Remark nvarchar (500)  = null ,

	@OpenDate datetime   = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [Type]
	, [fullname]
	, [address]
	, [phone]
	, [fax]
	, [person_id]
	, [place_issue]
	, [email]
	, [due_date]
	, [image]
	, [bankname]
	, [bank_br]
	, [accnum]
	, [Vatnum]
	, [contactps]
	, [remark]
	, [open_date]
	, [Status]
    FROM
	[dbo].[tblCustomer]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([Type] = @Type OR @Type IS NULL)
	AND ([fullname] = @Fullname OR @Fullname IS NULL)
	AND ([address] = @Address OR @Address IS NULL)
	AND ([phone] = @Phone OR @Phone IS NULL)
	AND ([fax] = @Fax OR @Fax IS NULL)
	AND ([person_id] = @PersonId OR @PersonId IS NULL)
	AND ([place_issue] = @PlaceIssue OR @PlaceIssue IS NULL)
	AND ([email] = @Email OR @Email IS NULL)
	AND ([due_date] = @DueDate OR @DueDate IS NULL)
	AND ([bankname] = @Bankname OR @Bankname IS NULL)
	AND ([bank_br] = @BankBr OR @BankBr IS NULL)
	AND ([accnum] = @Accnum OR @Accnum IS NULL)
	AND ([Vatnum] = @Vatnum OR @Vatnum IS NULL)
	AND ([contactps] = @Contactps OR @Contactps IS NULL)
	AND ([remark] = @Remark OR @Remark IS NULL)
	AND ([open_date] = @OpenDate OR @OpenDate IS NULL)
	AND ([Status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [Type]
	, [fullname]
	, [address]
	, [phone]
	, [fax]
	, [person_id]
	, [place_issue]
	, [email]
	, [due_date]
	, [image]
	, [bankname]
	, [bank_br]
	, [accnum]
	, [Vatnum]
	, [contactps]
	, [remark]
	, [open_date]
	, [Status]
    FROM
	[dbo].[tblCustomer]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([Type] = @Type AND @Type is not null)
	OR ([fullname] = @Fullname AND @Fullname is not null)
	OR ([address] = @Address AND @Address is not null)
	OR ([phone] = @Phone AND @Phone is not null)
	OR ([fax] = @Fax AND @Fax is not null)
	OR ([person_id] = @PersonId AND @PersonId is not null)
	OR ([place_issue] = @PlaceIssue AND @PlaceIssue is not null)
	OR ([email] = @Email AND @Email is not null)
	OR ([due_date] = @DueDate AND @DueDate is not null)
	OR ([bankname] = @Bankname AND @Bankname is not null)
	OR ([bank_br] = @BankBr AND @BankBr is not null)
	OR ([accnum] = @Accnum AND @Accnum is not null)
	OR ([Vatnum] = @Vatnum AND @Vatnum is not null)
	OR ([contactps] = @Contactps AND @Contactps is not null)
	OR ([remark] = @Remark AND @Remark is not null)
	OR ([open_date] = @OpenDate AND @OpenDate is not null)
	OR ([Status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAccTrans_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAccTrans_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAccTrans_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblAccTrans table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAccTrans_Get_List

AS


				
				SELECT
					[id],
					[tran_date],
					[tran_time],
					[ef_date],
					[trans_num],
					[voucher],
					[trans_code],
					[account_id],
					[db_amount],
					[cr_amount],
					[user_id],
					[corr_acc],
					[remark],
					[name],
					[address],
					[person_id],
					[updated],
					[recnum],
					[status]
				FROM
					[dbo].[tblAccTrans]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAccTrans_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAccTrans_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAccTrans_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblAccTrans table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAccTrans_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] numeric(18, 0) 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblAccTrans]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[tran_date], O.[tran_time], O.[ef_date], O.[trans_num], O.[voucher], O.[trans_code], O.[account_id], O.[db_amount], O.[cr_amount], O.[user_id], O.[corr_acc], O.[remark], O.[name], O.[address], O.[person_id], O.[updated], O.[recnum], O.[status]
				FROM
				    [dbo].[tblAccTrans] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblAccTrans]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAccTrans_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAccTrans_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAccTrans_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblAccTrans table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAccTrans_Insert
(

	@Id numeric (18, 0)   OUTPUT,

	@TranDate datetime   ,

	@TranTime nchar (5)  ,

	@EfDate datetime   ,

	@TransNum char (12)  ,

	@Voucher char (20)  ,

	@TransCode char (2)  ,

	@AccountId char (9)  ,

	@DbAmount numeric (18, 2)  ,

	@CrAmount numeric (18, 2)  ,

	@UserId numeric (3, 0)  ,

	@CorrAcc char (9)  ,

	@Remark nvarchar (200)  ,

	@Name nvarchar (200)  ,

	@Address nvarchar (255)  ,

	@PersonId nchar (20)  ,

	@Updated bit   ,

	@Recnum numeric (2, 0)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblAccTrans]
					(
					[tran_date]
					,[tran_time]
					,[ef_date]
					,[trans_num]
					,[voucher]
					,[trans_code]
					,[account_id]
					,[db_amount]
					,[cr_amount]
					,[user_id]
					,[corr_acc]
					,[remark]
					,[name]
					,[address]
					,[person_id]
					,[updated]
					,[recnum]
					,[status]
					)
				VALUES
					(
					@TranDate
					,@TranTime
					,@EfDate
					,@TransNum
					,@Voucher
					,@TransCode
					,@AccountId
					,@DbAmount
					,@CrAmount
					,@UserId
					,@CorrAcc
					,@Remark
					,@Name
					,@Address
					,@PersonId
					,@Updated
					,@Recnum
					,@Status
					)
				-- Get the identity value
				SET @Id = SCOPE_IDENTITY()
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAccTrans_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAccTrans_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAccTrans_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblAccTrans table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAccTrans_Update
(

	@Id numeric (18, 0)  ,

	@TranDate datetime   ,

	@TranTime nchar (5)  ,

	@EfDate datetime   ,

	@TransNum char (12)  ,

	@Voucher char (20)  ,

	@TransCode char (2)  ,

	@AccountId char (9)  ,

	@DbAmount numeric (18, 2)  ,

	@CrAmount numeric (18, 2)  ,

	@UserId numeric (3, 0)  ,

	@CorrAcc char (9)  ,

	@Remark nvarchar (200)  ,

	@Name nvarchar (200)  ,

	@Address nvarchar (255)  ,

	@PersonId nchar (20)  ,

	@Updated bit   ,

	@Recnum numeric (2, 0)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblAccTrans]
				SET
					[tran_date] = @TranDate
					,[tran_time] = @TranTime
					,[ef_date] = @EfDate
					,[trans_num] = @TransNum
					,[voucher] = @Voucher
					,[trans_code] = @TransCode
					,[account_id] = @AccountId
					,[db_amount] = @DbAmount
					,[cr_amount] = @CrAmount
					,[user_id] = @UserId
					,[corr_acc] = @CorrAcc
					,[remark] = @Remark
					,[name] = @Name
					,[address] = @Address
					,[person_id] = @PersonId
					,[updated] = @Updated
					,[recnum] = @Recnum
					,[status] = @Status
				WHERE
[id] = @Id 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAccTrans_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAccTrans_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAccTrans_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblAccTrans table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAccTrans_Delete
(

	@Id numeric (18, 0)  
)
AS


				DELETE FROM [dbo].[tblAccTrans] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAccTrans_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAccTrans_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAccTrans_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblAccTrans table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAccTrans_GetById
(

	@Id numeric (18, 0)  
)
AS


				SELECT
					[id],
					[tran_date],
					[tran_time],
					[ef_date],
					[trans_num],
					[voucher],
					[trans_code],
					[account_id],
					[db_amount],
					[cr_amount],
					[user_id],
					[corr_acc],
					[remark],
					[name],
					[address],
					[person_id],
					[updated],
					[recnum],
					[status]
				FROM
					[dbo].[tblAccTrans]
				WHERE
					[id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAccTrans_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAccTrans_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAccTrans_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblAccTrans table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAccTrans_Find
(

	@SearchUsingOR bit   = null ,

	@Id numeric (18, 0)  = null ,

	@TranDate datetime   = null ,

	@TranTime nchar (5)  = null ,

	@EfDate datetime   = null ,

	@TransNum char (12)  = null ,

	@Voucher char (20)  = null ,

	@TransCode char (2)  = null ,

	@AccountId char (9)  = null ,

	@DbAmount numeric (18, 2)  = null ,

	@CrAmount numeric (18, 2)  = null ,

	@UserId numeric (3, 0)  = null ,

	@CorrAcc char (9)  = null ,

	@Remark nvarchar (200)  = null ,

	@Name nvarchar (200)  = null ,

	@Address nvarchar (255)  = null ,

	@PersonId nchar (20)  = null ,

	@Updated bit   = null ,

	@Recnum numeric (2, 0)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [tran_date]
	, [tran_time]
	, [ef_date]
	, [trans_num]
	, [voucher]
	, [trans_code]
	, [account_id]
	, [db_amount]
	, [cr_amount]
	, [user_id]
	, [corr_acc]
	, [remark]
	, [name]
	, [address]
	, [person_id]
	, [updated]
	, [recnum]
	, [status]
    FROM
	[dbo].[tblAccTrans]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([tran_date] = @TranDate OR @TranDate IS NULL)
	AND ([tran_time] = @TranTime OR @TranTime IS NULL)
	AND ([ef_date] = @EfDate OR @EfDate IS NULL)
	AND ([trans_num] = @TransNum OR @TransNum IS NULL)
	AND ([voucher] = @Voucher OR @Voucher IS NULL)
	AND ([trans_code] = @TransCode OR @TransCode IS NULL)
	AND ([account_id] = @AccountId OR @AccountId IS NULL)
	AND ([db_amount] = @DbAmount OR @DbAmount IS NULL)
	AND ([cr_amount] = @CrAmount OR @CrAmount IS NULL)
	AND ([user_id] = @UserId OR @UserId IS NULL)
	AND ([corr_acc] = @CorrAcc OR @CorrAcc IS NULL)
	AND ([remark] = @Remark OR @Remark IS NULL)
	AND ([name] = @Name OR @Name IS NULL)
	AND ([address] = @Address OR @Address IS NULL)
	AND ([person_id] = @PersonId OR @PersonId IS NULL)
	AND ([updated] = @Updated OR @Updated IS NULL)
	AND ([recnum] = @Recnum OR @Recnum IS NULL)
	AND ([status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [tran_date]
	, [tran_time]
	, [ef_date]
	, [trans_num]
	, [voucher]
	, [trans_code]
	, [account_id]
	, [db_amount]
	, [cr_amount]
	, [user_id]
	, [corr_acc]
	, [remark]
	, [name]
	, [address]
	, [person_id]
	, [updated]
	, [recnum]
	, [status]
    FROM
	[dbo].[tblAccTrans]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([tran_date] = @TranDate AND @TranDate is not null)
	OR ([tran_time] = @TranTime AND @TranTime is not null)
	OR ([ef_date] = @EfDate AND @EfDate is not null)
	OR ([trans_num] = @TransNum AND @TransNum is not null)
	OR ([voucher] = @Voucher AND @Voucher is not null)
	OR ([trans_code] = @TransCode AND @TransCode is not null)
	OR ([account_id] = @AccountId AND @AccountId is not null)
	OR ([db_amount] = @DbAmount AND @DbAmount is not null)
	OR ([cr_amount] = @CrAmount AND @CrAmount is not null)
	OR ([user_id] = @UserId AND @UserId is not null)
	OR ([corr_acc] = @CorrAcc AND @CorrAcc is not null)
	OR ([remark] = @Remark AND @Remark is not null)
	OR ([name] = @Name AND @Name is not null)
	OR ([address] = @Address AND @Address is not null)
	OR ([person_id] = @PersonId AND @PersonId is not null)
	OR ([updated] = @Updated AND @Updated is not null)
	OR ([recnum] = @Recnum AND @Recnum is not null)
	OR ([status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblBookAttr_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblBookAttr_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblBookAttr_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblBookAttr table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblBookAttr_Get_List

AS


				
				SELECT
					[goods_id],
					[author],
					[publish],
					[translator],
					[form_type],
					[language],
					[pl_month],
					[pl_year],
					[dimension],
					[weight],
					[pages],
					[introinfo]
				FROM
					[dbo].[tblBookAttr]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblBookAttr_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblBookAttr_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblBookAttr_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblBookAttr table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblBookAttr_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [goods_id] nchar(6)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([goods_id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [goods_id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblBookAttr]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[goods_id], O.[author], O.[publish], O.[translator], O.[form_type], O.[language], O.[pl_month], O.[pl_year], O.[dimension], O.[weight], O.[pages], O.[introinfo]
				FROM
				    [dbo].[tblBookAttr] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[goods_id] = PageIndex.[goods_id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblBookAttr]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblBookAttr_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblBookAttr_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblBookAttr_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblBookAttr table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblBookAttr_Insert
(

	@GoodsId nchar (6)  ,

	@Author nvarchar (200)  ,

	@Publish nvarchar (200)  ,

	@Translator nvarchar (200)  ,

	@FormType int   ,

	@Language int   ,

	@PlMonth int   ,

	@PlYear int   ,

	@Dimension nvarchar (100)  ,

	@Weight int   ,

	@Pages int   ,

	@Introinfo nvarchar (1500)  
)
AS


				
				INSERT INTO [dbo].[tblBookAttr]
					(
					[goods_id]
					,[author]
					,[publish]
					,[translator]
					,[form_type]
					,[language]
					,[pl_month]
					,[pl_year]
					,[dimension]
					,[weight]
					,[pages]
					,[introinfo]
					)
				VALUES
					(
					@GoodsId
					,@Author
					,@Publish
					,@Translator
					,@FormType
					,@Language
					,@PlMonth
					,@PlYear
					,@Dimension
					,@Weight
					,@Pages
					,@Introinfo
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblBookAttr_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblBookAttr_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblBookAttr_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblBookAttr table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblBookAttr_Update
(

	@GoodsId nchar (6)  ,

	@OriginalGoodsId nchar (6)  ,

	@Author nvarchar (200)  ,

	@Publish nvarchar (200)  ,

	@Translator nvarchar (200)  ,

	@FormType int   ,

	@Language int   ,

	@PlMonth int   ,

	@PlYear int   ,

	@Dimension nvarchar (100)  ,

	@Weight int   ,

	@Pages int   ,

	@Introinfo nvarchar (1500)  
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblBookAttr]
				SET
					[goods_id] = @GoodsId
					,[author] = @Author
					,[publish] = @Publish
					,[translator] = @Translator
					,[form_type] = @FormType
					,[language] = @Language
					,[pl_month] = @PlMonth
					,[pl_year] = @PlYear
					,[dimension] = @Dimension
					,[weight] = @Weight
					,[pages] = @Pages
					,[introinfo] = @Introinfo
				WHERE
[goods_id] = @OriginalGoodsId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblBookAttr_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblBookAttr_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblBookAttr_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblBookAttr table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblBookAttr_Delete
(

	@GoodsId nchar (6)  
)
AS


				DELETE FROM [dbo].[tblBookAttr] WITH (ROWLOCK) 
				WHERE
					[goods_id] = @GoodsId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblBookAttr_GetByGoodsId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblBookAttr_GetByGoodsId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblBookAttr_GetByGoodsId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblBookAttr table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblBookAttr_GetByGoodsId
(

	@GoodsId nchar (6)  
)
AS


				SELECT
					[goods_id],
					[author],
					[publish],
					[translator],
					[form_type],
					[language],
					[pl_month],
					[pl_year],
					[dimension],
					[weight],
					[pages],
					[introinfo]
				FROM
					[dbo].[tblBookAttr]
				WHERE
					[goods_id] = @GoodsId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblBookAttr_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblBookAttr_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblBookAttr_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblBookAttr table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblBookAttr_Find
(

	@SearchUsingOR bit   = null ,

	@GoodsId nchar (6)  = null ,

	@Author nvarchar (200)  = null ,

	@Publish nvarchar (200)  = null ,

	@Translator nvarchar (200)  = null ,

	@FormType int   = null ,

	@Language int   = null ,

	@PlMonth int   = null ,

	@PlYear int   = null ,

	@Dimension nvarchar (100)  = null ,

	@Weight int   = null ,

	@Pages int   = null ,

	@Introinfo nvarchar (1500)  = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [goods_id]
	, [author]
	, [publish]
	, [translator]
	, [form_type]
	, [language]
	, [pl_month]
	, [pl_year]
	, [dimension]
	, [weight]
	, [pages]
	, [introinfo]
    FROM
	[dbo].[tblBookAttr]
    WHERE 
	 ([goods_id] = @GoodsId OR @GoodsId IS NULL)
	AND ([author] = @Author OR @Author IS NULL)
	AND ([publish] = @Publish OR @Publish IS NULL)
	AND ([translator] = @Translator OR @Translator IS NULL)
	AND ([form_type] = @FormType OR @FormType IS NULL)
	AND ([language] = @Language OR @Language IS NULL)
	AND ([pl_month] = @PlMonth OR @PlMonth IS NULL)
	AND ([pl_year] = @PlYear OR @PlYear IS NULL)
	AND ([dimension] = @Dimension OR @Dimension IS NULL)
	AND ([weight] = @Weight OR @Weight IS NULL)
	AND ([pages] = @Pages OR @Pages IS NULL)
	AND ([introinfo] = @Introinfo OR @Introinfo IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [goods_id]
	, [author]
	, [publish]
	, [translator]
	, [form_type]
	, [language]
	, [pl_month]
	, [pl_year]
	, [dimension]
	, [weight]
	, [pages]
	, [introinfo]
    FROM
	[dbo].[tblBookAttr]
    WHERE 
	 ([goods_id] = @GoodsId AND @GoodsId is not null)
	OR ([author] = @Author AND @Author is not null)
	OR ([publish] = @Publish AND @Publish is not null)
	OR ([translator] = @Translator AND @Translator is not null)
	OR ([form_type] = @FormType AND @FormType is not null)
	OR ([language] = @Language AND @Language is not null)
	OR ([pl_month] = @PlMonth AND @PlMonth is not null)
	OR ([pl_year] = @PlYear AND @PlYear is not null)
	OR ([dimension] = @Dimension AND @Dimension is not null)
	OR ([weight] = @Weight AND @Weight is not null)
	OR ([pages] = @Pages AND @Pages is not null)
	OR ([introinfo] = @Introinfo AND @Introinfo is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAtrCode_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAtrCode_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAtrCode_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblAtrCode table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAtrCode_Get_List

AS


				
				SELECT
					[trans_code],
					[trans_name],
					[status],
					[db_accid],
					[cr_accid],
					[accid1],
					[accid2],
					[accid3],
					[pcommand],
					[form],
					[voucher],
					[fvoucher],
					[nov],
					[tr_type]
				FROM
					[dbo].[tblAtrCode]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAtrCode_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAtrCode_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAtrCode_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblAtrCode table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAtrCode_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [trans_code] nvarchar(2)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([trans_code])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [trans_code]'
				SET @SQL = @SQL + ' FROM [dbo].[tblAtrCode]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[trans_code], O.[trans_name], O.[status], O.[db_accid], O.[cr_accid], O.[accid1], O.[accid2], O.[accid3], O.[pcommand], O.[form], O.[voucher], O.[fvoucher], O.[nov], O.[tr_type]
				FROM
				    [dbo].[tblAtrCode] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[trans_code] = PageIndex.[trans_code]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblAtrCode]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAtrCode_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAtrCode_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAtrCode_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblAtrCode table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAtrCode_Insert
(

	@TransCode nvarchar (2)  ,

	@TransName nvarchar (200)  ,

	@Status bit   ,

	@DbAccid nvarchar (9)  ,

	@CrAccid nvarchar (9)  ,

	@Accid1 nvarchar (9)  ,

	@Accid2 nvarchar (9)  ,

	@Accid3 nvarchar (9)  ,

	@Pcommand nvarchar (100)  ,

	@Form nvarchar (20)  ,

	@Voucher nvarchar (20)  ,

	@Fvoucher nvarchar (20)  ,

	@Nov numeric (3, 0)  ,

	@TrType nvarchar (2)  
)
AS


				
				INSERT INTO [dbo].[tblAtrCode]
					(
					[trans_code]
					,[trans_name]
					,[status]
					,[db_accid]
					,[cr_accid]
					,[accid1]
					,[accid2]
					,[accid3]
					,[pcommand]
					,[form]
					,[voucher]
					,[fvoucher]
					,[nov]
					,[tr_type]
					)
				VALUES
					(
					@TransCode
					,@TransName
					,@Status
					,@DbAccid
					,@CrAccid
					,@Accid1
					,@Accid2
					,@Accid3
					,@Pcommand
					,@Form
					,@Voucher
					,@Fvoucher
					,@Nov
					,@TrType
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAtrCode_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAtrCode_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAtrCode_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblAtrCode table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAtrCode_Update
(

	@TransCode nvarchar (2)  ,

	@OriginalTransCode nvarchar (2)  ,

	@TransName nvarchar (200)  ,

	@Status bit   ,

	@DbAccid nvarchar (9)  ,

	@CrAccid nvarchar (9)  ,

	@Accid1 nvarchar (9)  ,

	@Accid2 nvarchar (9)  ,

	@Accid3 nvarchar (9)  ,

	@Pcommand nvarchar (100)  ,

	@Form nvarchar (20)  ,

	@Voucher nvarchar (20)  ,

	@Fvoucher nvarchar (20)  ,

	@Nov numeric (3, 0)  ,

	@TrType nvarchar (2)  
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblAtrCode]
				SET
					[trans_code] = @TransCode
					,[trans_name] = @TransName
					,[status] = @Status
					,[db_accid] = @DbAccid
					,[cr_accid] = @CrAccid
					,[accid1] = @Accid1
					,[accid2] = @Accid2
					,[accid3] = @Accid3
					,[pcommand] = @Pcommand
					,[form] = @Form
					,[voucher] = @Voucher
					,[fvoucher] = @Fvoucher
					,[nov] = @Nov
					,[tr_type] = @TrType
				WHERE
[trans_code] = @OriginalTransCode 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAtrCode_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAtrCode_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAtrCode_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblAtrCode table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAtrCode_Delete
(

	@TransCode nvarchar (2)  
)
AS


				DELETE FROM [dbo].[tblAtrCode] WITH (ROWLOCK) 
				WHERE
					[trans_code] = @TransCode
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAtrCode_GetByTransCode procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAtrCode_GetByTransCode') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAtrCode_GetByTransCode
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblAtrCode table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAtrCode_GetByTransCode
(

	@TransCode nvarchar (2)  
)
AS


				SELECT
					[trans_code],
					[trans_name],
					[status],
					[db_accid],
					[cr_accid],
					[accid1],
					[accid2],
					[accid3],
					[pcommand],
					[form],
					[voucher],
					[fvoucher],
					[nov],
					[tr_type]
				FROM
					[dbo].[tblAtrCode]
				WHERE
					[trans_code] = @TransCode
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblAtrCode_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblAtrCode_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblAtrCode_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblAtrCode table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblAtrCode_Find
(

	@SearchUsingOR bit   = null ,

	@TransCode nvarchar (2)  = null ,

	@TransName nvarchar (200)  = null ,

	@Status bit   = null ,

	@DbAccid nvarchar (9)  = null ,

	@CrAccid nvarchar (9)  = null ,

	@Accid1 nvarchar (9)  = null ,

	@Accid2 nvarchar (9)  = null ,

	@Accid3 nvarchar (9)  = null ,

	@Pcommand nvarchar (100)  = null ,

	@Form nvarchar (20)  = null ,

	@Voucher nvarchar (20)  = null ,

	@Fvoucher nvarchar (20)  = null ,

	@Nov numeric (3, 0)  = null ,

	@TrType nvarchar (2)  = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [trans_code]
	, [trans_name]
	, [status]
	, [db_accid]
	, [cr_accid]
	, [accid1]
	, [accid2]
	, [accid3]
	, [pcommand]
	, [form]
	, [voucher]
	, [fvoucher]
	, [nov]
	, [tr_type]
    FROM
	[dbo].[tblAtrCode]
    WHERE 
	 ([trans_code] = @TransCode OR @TransCode IS NULL)
	AND ([trans_name] = @TransName OR @TransName IS NULL)
	AND ([status] = @Status OR @Status IS NULL)
	AND ([db_accid] = @DbAccid OR @DbAccid IS NULL)
	AND ([cr_accid] = @CrAccid OR @CrAccid IS NULL)
	AND ([accid1] = @Accid1 OR @Accid1 IS NULL)
	AND ([accid2] = @Accid2 OR @Accid2 IS NULL)
	AND ([accid3] = @Accid3 OR @Accid3 IS NULL)
	AND ([pcommand] = @Pcommand OR @Pcommand IS NULL)
	AND ([form] = @Form OR @Form IS NULL)
	AND ([voucher] = @Voucher OR @Voucher IS NULL)
	AND ([fvoucher] = @Fvoucher OR @Fvoucher IS NULL)
	AND ([nov] = @Nov OR @Nov IS NULL)
	AND ([tr_type] = @TrType OR @TrType IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [trans_code]
	, [trans_name]
	, [status]
	, [db_accid]
	, [cr_accid]
	, [accid1]
	, [accid2]
	, [accid3]
	, [pcommand]
	, [form]
	, [voucher]
	, [fvoucher]
	, [nov]
	, [tr_type]
    FROM
	[dbo].[tblAtrCode]
    WHERE 
	 ([trans_code] = @TransCode AND @TransCode is not null)
	OR ([trans_name] = @TransName AND @TransName is not null)
	OR ([status] = @Status AND @Status is not null)
	OR ([db_accid] = @DbAccid AND @DbAccid is not null)
	OR ([cr_accid] = @CrAccid AND @CrAccid is not null)
	OR ([accid1] = @Accid1 AND @Accid1 is not null)
	OR ([accid2] = @Accid2 AND @Accid2 is not null)
	OR ([accid3] = @Accid3 AND @Accid3 is not null)
	OR ([pcommand] = @Pcommand AND @Pcommand is not null)
	OR ([form] = @Form AND @Form is not null)
	OR ([voucher] = @Voucher AND @Voucher is not null)
	OR ([fvoucher] = @Fvoucher AND @Fvoucher is not null)
	OR ([nov] = @Nov AND @Nov is not null)
	OR ([tr_type] = @TrType AND @TrType is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblDate_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblDate_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblDate_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblDate table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblDate_Get_List

AS


				
				SELECT
					[id],
					[org_date],
					[Complete]
				FROM
					[dbo].[tblDate]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblDate_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblDate_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblDate_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblDate table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblDate_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] int 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblDate]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[org_date], O.[Complete]
				FROM
				    [dbo].[tblDate] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblDate]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblDate_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblDate_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblDate_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblDate table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblDate_Insert
(

	@Id int   ,

	@OrgDate datetime   ,

	@Complete nvarchar (1)  
)
AS


				
				INSERT INTO [dbo].[tblDate]
					(
					[id]
					,[org_date]
					,[Complete]
					)
				VALUES
					(
					@Id
					,@OrgDate
					,@Complete
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblDate_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblDate_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblDate_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblDate table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblDate_Update
(

	@Id int   ,

	@OriginalId int   ,

	@OrgDate datetime   ,

	@Complete nvarchar (1)  
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblDate]
				SET
					[id] = @Id
					,[org_date] = @OrgDate
					,[Complete] = @Complete
				WHERE
[id] = @OriginalId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblDate_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblDate_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblDate_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblDate table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblDate_Delete
(

	@Id int   
)
AS


				DELETE FROM [dbo].[tblDate] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblDate_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblDate_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblDate_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblDate table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblDate_GetById
(

	@Id int   
)
AS


				SELECT
					[id],
					[org_date],
					[Complete]
				FROM
					[dbo].[tblDate]
				WHERE
					[id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblDate_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblDate_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblDate_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblDate table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblDate_Find
(

	@SearchUsingOR bit   = null ,

	@Id int   = null ,

	@OrgDate datetime   = null ,

	@Complete nvarchar (1)  = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [org_date]
	, [Complete]
    FROM
	[dbo].[tblDate]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([org_date] = @OrgDate OR @OrgDate IS NULL)
	AND ([Complete] = @Complete OR @Complete IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [org_date]
	, [Complete]
    FROM
	[dbo].[tblDate]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([org_date] = @OrgDate AND @OrgDate is not null)
	OR ([Complete] = @Complete AND @Complete is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblBarcode_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblBarcode_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblBarcode_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblBarcode table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblBarcode_Get_List

AS


				
				SELECT
					[barcode],
					[goods_id]
				FROM
					[dbo].[tblBarcode]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblBarcode_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblBarcode_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblBarcode_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblBarcode table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblBarcode_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [barcode] varchar(20)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([barcode])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [barcode]'
				SET @SQL = @SQL + ' FROM [dbo].[tblBarcode]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[barcode], O.[goods_id]
				FROM
				    [dbo].[tblBarcode] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[barcode] = PageIndex.[barcode]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblBarcode]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblBarcode_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblBarcode_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblBarcode_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblBarcode table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblBarcode_Insert
(

	@Barcode varchar (20)  ,

	@GoodsId char (6)  
)
AS


				
				INSERT INTO [dbo].[tblBarcode]
					(
					[barcode]
					,[goods_id]
					)
				VALUES
					(
					@Barcode
					,@GoodsId
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblBarcode_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblBarcode_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblBarcode_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblBarcode table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblBarcode_Update
(

	@Barcode varchar (20)  ,

	@OriginalBarcode varchar (20)  ,

	@GoodsId char (6)  
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblBarcode]
				SET
					[barcode] = @Barcode
					,[goods_id] = @GoodsId
				WHERE
[barcode] = @OriginalBarcode 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblBarcode_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblBarcode_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblBarcode_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblBarcode table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblBarcode_Delete
(

	@Barcode varchar (20)  
)
AS


				DELETE FROM [dbo].[tblBarcode] WITH (ROWLOCK) 
				WHERE
					[barcode] = @Barcode
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblBarcode_GetByBarcode procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblBarcode_GetByBarcode') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblBarcode_GetByBarcode
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblBarcode table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblBarcode_GetByBarcode
(

	@Barcode varchar (20)  
)
AS


				SELECT
					[barcode],
					[goods_id]
				FROM
					[dbo].[tblBarcode]
				WHERE
					[barcode] = @Barcode
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblBarcode_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblBarcode_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblBarcode_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblBarcode table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblBarcode_Find
(

	@SearchUsingOR bit   = null ,

	@Barcode varchar (20)  = null ,

	@GoodsId char (6)  = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [barcode]
	, [goods_id]
    FROM
	[dbo].[tblBarcode]
    WHERE 
	 ([barcode] = @Barcode OR @Barcode IS NULL)
	AND ([goods_id] = @GoodsId OR @GoodsId IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [barcode]
	, [goods_id]
    FROM
	[dbo].[tblBarcode]
    WHERE 
	 ([barcode] = @Barcode AND @Barcode is not null)
	OR ([goods_id] = @GoodsId AND @GoodsId is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLanguage_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLanguage_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLanguage_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblLanguage table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLanguage_Get_List

AS


				
				SELECT
					[id],
					[description],
					[status]
				FROM
					[dbo].[tblLanguage]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLanguage_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLanguage_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLanguage_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblLanguage table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLanguage_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] numeric(18, 0) 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblLanguage]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[description], O.[status]
				FROM
				    [dbo].[tblLanguage] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblLanguage]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLanguage_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLanguage_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLanguage_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblLanguage table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLanguage_Insert
(

	@Id numeric (18, 0)  ,

	@Description nvarchar (100)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblLanguage]
					(
					[id]
					,[description]
					,[status]
					)
				VALUES
					(
					@Id
					,@Description
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLanguage_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLanguage_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLanguage_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblLanguage table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLanguage_Update
(

	@Id numeric (18, 0)  ,

	@OriginalId numeric (18, 0)  ,

	@Description nvarchar (100)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblLanguage]
				SET
					[id] = @Id
					,[description] = @Description
					,[status] = @Status
				WHERE
[id] = @OriginalId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLanguage_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLanguage_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLanguage_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblLanguage table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLanguage_Delete
(

	@Id numeric (18, 0)  
)
AS


				DELETE FROM [dbo].[tblLanguage] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLanguage_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLanguage_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLanguage_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblLanguage table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLanguage_GetById
(

	@Id numeric (18, 0)  
)
AS


				SELECT
					[id],
					[description],
					[status]
				FROM
					[dbo].[tblLanguage]
				WHERE
					[id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLanguage_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLanguage_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLanguage_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblLanguage table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLanguage_Find
(

	@SearchUsingOR bit   = null ,

	@Id numeric (18, 0)  = null ,

	@Description nvarchar (100)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [description]
	, [status]
    FROM
	[dbo].[tblLanguage]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([description] = @Description OR @Description IS NULL)
	AND ([status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [description]
	, [status]
    FROM
	[dbo].[tblLanguage]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([description] = @Description AND @Description is not null)
	OR ([status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblFiles_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblFiles_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblFiles_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblFiles table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblFiles_Get_List

AS


				
				SELECT
					[id],
					[filename],
					[version],
					[filebinary],
					[last_date]
				FROM
					[dbo].[tblFiles]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblFiles_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblFiles_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblFiles_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblFiles table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblFiles_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] numeric(18, 0) 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblFiles]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[filename], O.[version], O.[filebinary], O.[last_date]
				FROM
				    [dbo].[tblFiles] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblFiles]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblFiles_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblFiles_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblFiles_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblFiles table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblFiles_Insert
(

	@Id numeric (18, 0)   OUTPUT,

	@Filename nvarchar (200)  ,

	@Version nvarchar (50)  ,

	@Filebinary varbinary (MAX)  ,

	@LastDate datetime   
)
AS


				
				INSERT INTO [dbo].[tblFiles]
					(
					[filename]
					,[version]
					,[filebinary]
					,[last_date]
					)
				VALUES
					(
					@Filename
					,@Version
					,@Filebinary
					,@LastDate
					)
				-- Get the identity value
				SET @Id = SCOPE_IDENTITY()
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblFiles_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblFiles_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblFiles_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblFiles table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblFiles_Update
(

	@Id numeric (18, 0)  ,

	@Filename nvarchar (200)  ,

	@Version nvarchar (50)  ,

	@Filebinary varbinary (MAX)  ,

	@LastDate datetime   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblFiles]
				SET
					[filename] = @Filename
					,[version] = @Version
					,[filebinary] = @Filebinary
					,[last_date] = @LastDate
				WHERE
[id] = @Id 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblFiles_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblFiles_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblFiles_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblFiles table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblFiles_Delete
(

	@Id numeric (18, 0)  
)
AS


				DELETE FROM [dbo].[tblFiles] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblFiles_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblFiles_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblFiles_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblFiles table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblFiles_GetById
(

	@Id numeric (18, 0)  
)
AS


				SELECT
					[id],
					[filename],
					[version],
					[filebinary],
					[last_date]
				FROM
					[dbo].[tblFiles]
				WHERE
					[id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblFiles_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblFiles_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblFiles_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblFiles table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblFiles_Find
(

	@SearchUsingOR bit   = null ,

	@Id numeric (18, 0)  = null ,

	@Filename nvarchar (200)  = null ,

	@Version nvarchar (50)  = null ,

	@Filebinary varbinary (MAX)  = null ,

	@LastDate datetime   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [filename]
	, [version]
	, [filebinary]
	, [last_date]
    FROM
	[dbo].[tblFiles]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([filename] = @Filename OR @Filename IS NULL)
	AND ([version] = @Version OR @Version IS NULL)
	AND ([last_date] = @LastDate OR @LastDate IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [filename]
	, [version]
	, [filebinary]
	, [last_date]
    FROM
	[dbo].[tblFiles]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([filename] = @Filename AND @Filename is not null)
	OR ([version] = @Version AND @Version is not null)
	OR ([last_date] = @LastDate AND @LastDate is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLoanTran_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLoanTran_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLoanTran_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblLoanTran table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLoanTran_Get_List

AS


				
				SELECT
					[trans_num],
					[tran_date],
					[trans_code],
					[tran_time],
					[exp_id],
					[cs_id],
					[goods_id],
					[qty],
					[due_date],
					[user_id],
					[corr_tran],
					[remark],
					[status]
				FROM
					[dbo].[tblLoanTran]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLoanTran_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLoanTran_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLoanTran_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblLoanTran table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLoanTran_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [trans_num] nchar(12) , [goods_id] nchar(6)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([trans_num], [goods_id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [trans_num], [goods_id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblLoanTran]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[trans_num], O.[tran_date], O.[trans_code], O.[tran_time], O.[exp_id], O.[cs_id], O.[goods_id], O.[qty], O.[due_date], O.[user_id], O.[corr_tran], O.[remark], O.[status]
				FROM
				    [dbo].[tblLoanTran] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[trans_num] = PageIndex.[trans_num]
					AND O.[goods_id] = PageIndex.[goods_id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblLoanTran]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLoanTran_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLoanTran_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLoanTran_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblLoanTran table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLoanTran_Insert
(

	@TransNum nchar (12)  ,

	@TranDate datetime   ,

	@TransCode nchar (2)  ,

	@TranTime nchar (5)  ,

	@ExpId nchar (5)  ,

	@CsId nchar (8)  ,

	@GoodsId nchar (6)  ,

	@Qty numeric (18, 2)  ,

	@DueDate datetime   ,

	@UserId numeric (18, 0)  ,

	@CorrTran nchar (12)  ,

	@Remark nvarchar (300)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblLoanTran]
					(
					[trans_num]
					,[tran_date]
					,[trans_code]
					,[tran_time]
					,[exp_id]
					,[cs_id]
					,[goods_id]
					,[qty]
					,[due_date]
					,[user_id]
					,[corr_tran]
					,[remark]
					,[status]
					)
				VALUES
					(
					@TransNum
					,@TranDate
					,@TransCode
					,@TranTime
					,@ExpId
					,@CsId
					,@GoodsId
					,@Qty
					,@DueDate
					,@UserId
					,@CorrTran
					,@Remark
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLoanTran_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLoanTran_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLoanTran_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblLoanTran table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLoanTran_Update
(

	@TransNum nchar (12)  ,

	@OriginalTransNum nchar (12)  ,

	@TranDate datetime   ,

	@TransCode nchar (2)  ,

	@TranTime nchar (5)  ,

	@ExpId nchar (5)  ,

	@CsId nchar (8)  ,

	@GoodsId nchar (6)  ,

	@OriginalGoodsId nchar (6)  ,

	@Qty numeric (18, 2)  ,

	@DueDate datetime   ,

	@UserId numeric (18, 0)  ,

	@CorrTran nchar (12)  ,

	@Remark nvarchar (300)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblLoanTran]
				SET
					[trans_num] = @TransNum
					,[tran_date] = @TranDate
					,[trans_code] = @TransCode
					,[tran_time] = @TranTime
					,[exp_id] = @ExpId
					,[cs_id] = @CsId
					,[goods_id] = @GoodsId
					,[qty] = @Qty
					,[due_date] = @DueDate
					,[user_id] = @UserId
					,[corr_tran] = @CorrTran
					,[remark] = @Remark
					,[status] = @Status
				WHERE
[trans_num] = @OriginalTransNum 
AND [goods_id] = @OriginalGoodsId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLoanTran_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLoanTran_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLoanTran_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblLoanTran table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLoanTran_Delete
(

	@TransNum nchar (12)  ,

	@GoodsId nchar (6)  
)
AS


				DELETE FROM [dbo].[tblLoanTran] WITH (ROWLOCK) 
				WHERE
					[trans_num] = @TransNum
					AND [goods_id] = @GoodsId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLoanTran_GetByTransNumGoodsId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLoanTran_GetByTransNumGoodsId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLoanTran_GetByTransNumGoodsId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblLoanTran table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLoanTran_GetByTransNumGoodsId
(

	@TransNum nchar (12)  ,

	@GoodsId nchar (6)  
)
AS


				SELECT
					[trans_num],
					[tran_date],
					[trans_code],
					[tran_time],
					[exp_id],
					[cs_id],
					[goods_id],
					[qty],
					[due_date],
					[user_id],
					[corr_tran],
					[remark],
					[status]
				FROM
					[dbo].[tblLoanTran]
				WHERE
					[trans_num] = @TransNum
					AND [goods_id] = @GoodsId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLoanTran_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLoanTran_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLoanTran_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblLoanTran table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLoanTran_Find
(

	@SearchUsingOR bit   = null ,

	@TransNum nchar (12)  = null ,

	@TranDate datetime   = null ,

	@TransCode nchar (2)  = null ,

	@TranTime nchar (5)  = null ,

	@ExpId nchar (5)  = null ,

	@CsId nchar (8)  = null ,

	@GoodsId nchar (6)  = null ,

	@Qty numeric (18, 2)  = null ,

	@DueDate datetime   = null ,

	@UserId numeric (18, 0)  = null ,

	@CorrTran nchar (12)  = null ,

	@Remark nvarchar (300)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [trans_num]
	, [tran_date]
	, [trans_code]
	, [tran_time]
	, [exp_id]
	, [cs_id]
	, [goods_id]
	, [qty]
	, [due_date]
	, [user_id]
	, [corr_tran]
	, [remark]
	, [status]
    FROM
	[dbo].[tblLoanTran]
    WHERE 
	 ([trans_num] = @TransNum OR @TransNum IS NULL)
	AND ([tran_date] = @TranDate OR @TranDate IS NULL)
	AND ([trans_code] = @TransCode OR @TransCode IS NULL)
	AND ([tran_time] = @TranTime OR @TranTime IS NULL)
	AND ([exp_id] = @ExpId OR @ExpId IS NULL)
	AND ([cs_id] = @CsId OR @CsId IS NULL)
	AND ([goods_id] = @GoodsId OR @GoodsId IS NULL)
	AND ([qty] = @Qty OR @Qty IS NULL)
	AND ([due_date] = @DueDate OR @DueDate IS NULL)
	AND ([user_id] = @UserId OR @UserId IS NULL)
	AND ([corr_tran] = @CorrTran OR @CorrTran IS NULL)
	AND ([remark] = @Remark OR @Remark IS NULL)
	AND ([status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [trans_num]
	, [tran_date]
	, [trans_code]
	, [tran_time]
	, [exp_id]
	, [cs_id]
	, [goods_id]
	, [qty]
	, [due_date]
	, [user_id]
	, [corr_tran]
	, [remark]
	, [status]
    FROM
	[dbo].[tblLoanTran]
    WHERE 
	 ([trans_num] = @TransNum AND @TransNum is not null)
	OR ([tran_date] = @TranDate AND @TranDate is not null)
	OR ([trans_code] = @TransCode AND @TransCode is not null)
	OR ([tran_time] = @TranTime AND @TranTime is not null)
	OR ([exp_id] = @ExpId AND @ExpId is not null)
	OR ([cs_id] = @CsId AND @CsId is not null)
	OR ([goods_id] = @GoodsId AND @GoodsId is not null)
	OR ([qty] = @Qty AND @Qty is not null)
	OR ([due_date] = @DueDate AND @DueDate is not null)
	OR ([user_id] = @UserId AND @UserId is not null)
	OR ([corr_tran] = @CorrTran AND @CorrTran is not null)
	OR ([remark] = @Remark AND @Remark is not null)
	OR ([status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblKit_info_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblKit_info_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblKit_info_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblKit_info table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblKit_info_Get_List

AS


				
				SELECT
					[kit_id],
					[goods_id],
					[qty]
				FROM
					[dbo].[tblKit_info]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblKit_info_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblKit_info_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblKit_info_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblKit_info table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblKit_info_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [kit_id] nchar(7) , [goods_id] nchar(6)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([kit_id], [goods_id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [kit_id], [goods_id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblKit_info]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[kit_id], O.[goods_id], O.[qty]
				FROM
				    [dbo].[tblKit_info] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[kit_id] = PageIndex.[kit_id]
					AND O.[goods_id] = PageIndex.[goods_id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblKit_info]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblKit_info_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblKit_info_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblKit_info_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblKit_info table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblKit_info_Insert
(

	@KitId nchar (7)  ,

	@GoodsId nchar (6)  ,

	@Qty numeric (18, 2)  
)
AS


				
				INSERT INTO [dbo].[tblKit_info]
					(
					[kit_id]
					,[goods_id]
					,[qty]
					)
				VALUES
					(
					@KitId
					,@GoodsId
					,@Qty
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblKit_info_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblKit_info_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblKit_info_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblKit_info table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblKit_info_Update
(

	@KitId nchar (7)  ,

	@OriginalKitId nchar (7)  ,

	@GoodsId nchar (6)  ,

	@OriginalGoodsId nchar (6)  ,

	@Qty numeric (18, 2)  
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblKit_info]
				SET
					[kit_id] = @KitId
					,[goods_id] = @GoodsId
					,[qty] = @Qty
				WHERE
[kit_id] = @OriginalKitId 
AND [goods_id] = @OriginalGoodsId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblKit_info_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblKit_info_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblKit_info_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblKit_info table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblKit_info_Delete
(

	@KitId nchar (7)  ,

	@GoodsId nchar (6)  
)
AS


				DELETE FROM [dbo].[tblKit_info] WITH (ROWLOCK) 
				WHERE
					[kit_id] = @KitId
					AND [goods_id] = @GoodsId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblKit_info_GetByKitIdGoodsId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblKit_info_GetByKitIdGoodsId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblKit_info_GetByKitIdGoodsId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblKit_info table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblKit_info_GetByKitIdGoodsId
(

	@KitId nchar (7)  ,

	@GoodsId nchar (6)  
)
AS


				SELECT
					[kit_id],
					[goods_id],
					[qty]
				FROM
					[dbo].[tblKit_info]
				WHERE
					[kit_id] = @KitId
					AND [goods_id] = @GoodsId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblKit_info_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblKit_info_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblKit_info_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblKit_info table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblKit_info_Find
(

	@SearchUsingOR bit   = null ,

	@KitId nchar (7)  = null ,

	@GoodsId nchar (6)  = null ,

	@Qty numeric (18, 2)  = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [kit_id]
	, [goods_id]
	, [qty]
    FROM
	[dbo].[tblKit_info]
    WHERE 
	 ([kit_id] = @KitId OR @KitId IS NULL)
	AND ([goods_id] = @GoodsId OR @GoodsId IS NULL)
	AND ([qty] = @Qty OR @Qty IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [kit_id]
	, [goods_id]
	, [qty]
    FROM
	[dbo].[tblKit_info]
    WHERE 
	 ([kit_id] = @KitId AND @KitId is not null)
	OR ([goods_id] = @GoodsId AND @GoodsId is not null)
	OR ([qty] = @Qty AND @Qty is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLocation_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLocation_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLocation_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblLocation table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLocation_Get_List

AS


				
				SELECT
					[stk_id],
					[loc_id],
					[description],
					[status]
				FROM
					[dbo].[tblLocation]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLocation_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLocation_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLocation_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblLocation table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLocation_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [stk_id] nchar(5) , [loc_id] nchar(4)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([stk_id], [loc_id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [stk_id], [loc_id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblLocation]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[stk_id], O.[loc_id], O.[description], O.[status]
				FROM
				    [dbo].[tblLocation] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[stk_id] = PageIndex.[stk_id]
					AND O.[loc_id] = PageIndex.[loc_id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblLocation]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLocation_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLocation_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLocation_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblLocation table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLocation_Insert
(

	@StkId nchar (5)  ,

	@LocId nchar (4)  ,

	@Description nvarchar (100)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblLocation]
					(
					[stk_id]
					,[loc_id]
					,[description]
					,[status]
					)
				VALUES
					(
					@StkId
					,@LocId
					,@Description
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLocation_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLocation_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLocation_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblLocation table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLocation_Update
(

	@StkId nchar (5)  ,

	@OriginalStkId nchar (5)  ,

	@LocId nchar (4)  ,

	@OriginalLocId nchar (4)  ,

	@Description nvarchar (100)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblLocation]
				SET
					[stk_id] = @StkId
					,[loc_id] = @LocId
					,[description] = @Description
					,[status] = @Status
				WHERE
[stk_id] = @OriginalStkId 
AND [loc_id] = @OriginalLocId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLocation_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLocation_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLocation_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblLocation table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLocation_Delete
(

	@StkId nchar (5)  ,

	@LocId nchar (4)  
)
AS


				DELETE FROM [dbo].[tblLocation] WITH (ROWLOCK) 
				WHERE
					[stk_id] = @StkId
					AND [loc_id] = @LocId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLocation_GetByStkIdLocId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLocation_GetByStkIdLocId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLocation_GetByStkIdLocId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblLocation table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLocation_GetByStkIdLocId
(

	@StkId nchar (5)  ,

	@LocId nchar (4)  
)
AS


				SELECT
					[stk_id],
					[loc_id],
					[description],
					[status]
				FROM
					[dbo].[tblLocation]
				WHERE
					[stk_id] = @StkId
					AND [loc_id] = @LocId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblLocation_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblLocation_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblLocation_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblLocation table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblLocation_Find
(

	@SearchUsingOR bit   = null ,

	@StkId nchar (5)  = null ,

	@LocId nchar (4)  = null ,

	@Description nvarchar (100)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [stk_id]
	, [loc_id]
	, [description]
	, [status]
    FROM
	[dbo].[tblLocation]
    WHERE 
	 ([stk_id] = @StkId OR @StkId IS NULL)
	AND ([loc_id] = @LocId OR @LocId IS NULL)
	AND ([description] = @Description OR @Description IS NULL)
	AND ([status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [stk_id]
	, [loc_id]
	, [description]
	, [status]
    FROM
	[dbo].[tblLocation]
    WHERE 
	 ([stk_id] = @StkId AND @StkId is not null)
	OR ([loc_id] = @LocId AND @LocId is not null)
	OR ([description] = @Description AND @Description is not null)
	OR ([status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblFrmType_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblFrmType_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblFrmType_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblFrmType table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblFrmType_Get_List

AS


				
				SELECT
					[id],
					[description],
					[status]
				FROM
					[dbo].[tblFrmType]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblFrmType_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblFrmType_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblFrmType_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblFrmType table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblFrmType_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] numeric(18, 0) 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblFrmType]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[description], O.[status]
				FROM
				    [dbo].[tblFrmType] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblFrmType]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblFrmType_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblFrmType_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblFrmType_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblFrmType table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblFrmType_Insert
(

	@Id numeric (18, 0)  ,

	@Description nvarchar (100)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblFrmType]
					(
					[id]
					,[description]
					,[status]
					)
				VALUES
					(
					@Id
					,@Description
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblFrmType_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblFrmType_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblFrmType_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblFrmType table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblFrmType_Update
(

	@Id numeric (18, 0)  ,

	@OriginalId numeric (18, 0)  ,

	@Description nvarchar (100)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblFrmType]
				SET
					[id] = @Id
					,[description] = @Description
					,[status] = @Status
				WHERE
[id] = @OriginalId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblFrmType_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblFrmType_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblFrmType_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblFrmType table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblFrmType_Delete
(

	@Id numeric (18, 0)  
)
AS


				DELETE FROM [dbo].[tblFrmType] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblFrmType_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblFrmType_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblFrmType_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblFrmType table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblFrmType_GetById
(

	@Id numeric (18, 0)  
)
AS


				SELECT
					[id],
					[description],
					[status]
				FROM
					[dbo].[tblFrmType]
				WHERE
					[id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblFrmType_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblFrmType_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblFrmType_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblFrmType table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblFrmType_Find
(

	@SearchUsingOR bit   = null ,

	@Id numeric (18, 0)  = null ,

	@Description nvarchar (100)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [description]
	, [status]
    FROM
	[dbo].[tblFrmType]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([description] = @Description OR @Description IS NULL)
	AND ([status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [description]
	, [status]
    FROM
	[dbo].[tblFrmType]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([description] = @Description AND @Description is not null)
	OR ([status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblKit_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblKit_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblKit_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblKit table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblKit_Get_List

AS


				
				SELECT
					[id],
					[description],
					[unitsymb],
					[rtprice],
					[open_date],
					[status]
				FROM
					[dbo].[tblKit]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblKit_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblKit_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblKit_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblKit table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblKit_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] nchar(6)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblKit]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[description], O.[unitsymb], O.[rtprice], O.[open_date], O.[status]
				FROM
				    [dbo].[tblKit] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblKit]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblKit_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblKit_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblKit_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblKit table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblKit_Insert
(

	@Id nchar (6)  ,

	@Description nvarchar (50)  ,

	@Unitsymb nchar (3)  ,

	@Rtprice numeric (18, 2)  ,

	@OpenDate datetime   ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblKit]
					(
					[id]
					,[description]
					,[unitsymb]
					,[rtprice]
					,[open_date]
					,[status]
					)
				VALUES
					(
					@Id
					,@Description
					,@Unitsymb
					,@Rtprice
					,@OpenDate
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblKit_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblKit_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblKit_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblKit table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblKit_Update
(

	@Id nchar (6)  ,

	@OriginalId nchar (6)  ,

	@Description nvarchar (50)  ,

	@Unitsymb nchar (3)  ,

	@Rtprice numeric (18, 2)  ,

	@OpenDate datetime   ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblKit]
				SET
					[id] = @Id
					,[description] = @Description
					,[unitsymb] = @Unitsymb
					,[rtprice] = @Rtprice
					,[open_date] = @OpenDate
					,[status] = @Status
				WHERE
[id] = @OriginalId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblKit_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblKit_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblKit_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblKit table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblKit_Delete
(

	@Id nchar (6)  
)
AS


				DELETE FROM [dbo].[tblKit] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblKit_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblKit_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblKit_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblKit table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblKit_GetById
(

	@Id nchar (6)  
)
AS


				SELECT
					[id],
					[description],
					[unitsymb],
					[rtprice],
					[open_date],
					[status]
				FROM
					[dbo].[tblKit]
				WHERE
					[id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblKit_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblKit_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblKit_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblKit table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblKit_Find
(

	@SearchUsingOR bit   = null ,

	@Id nchar (6)  = null ,

	@Description nvarchar (50)  = null ,

	@Unitsymb nchar (3)  = null ,

	@Rtprice numeric (18, 2)  = null ,

	@OpenDate datetime   = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [description]
	, [unitsymb]
	, [rtprice]
	, [open_date]
	, [status]
    FROM
	[dbo].[tblKit]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([description] = @Description OR @Description IS NULL)
	AND ([unitsymb] = @Unitsymb OR @Unitsymb IS NULL)
	AND ([rtprice] = @Rtprice OR @Rtprice IS NULL)
	AND ([open_date] = @OpenDate OR @OpenDate IS NULL)
	AND ([status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [description]
	, [unitsymb]
	, [rtprice]
	, [open_date]
	, [status]
    FROM
	[dbo].[tblKit]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([description] = @Description AND @Description is not null)
	OR ([unitsymb] = @Unitsymb AND @Unitsymb is not null)
	OR ([rtprice] = @Rtprice AND @Rtprice is not null)
	OR ([open_date] = @OpenDate AND @OpenDate is not null)
	OR ([status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblGoods_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblGoods_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblGoods_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblGoods table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblGoods_Get_List

AS


				
				SELECT
					[goods_id],
					[barcode],
					[mbc],
					[ref],
					[grp_id],
					[short_name],
					[full_name],
					[packunit],
					[piceunit],
					[unitconv],
					[supp_id],
					[image],
					[open_date],
					[tax_code],
					[merc_type],
					[attr_type],
					[domestic],
					[warranty],
					[status]
				FROM
					[dbo].[tblGoods]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblGoods_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblGoods_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblGoods_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblGoods table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblGoods_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [goods_id] char(6)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([goods_id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [goods_id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblGoods]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[goods_id], O.[barcode], O.[mbc], O.[ref], O.[grp_id], O.[short_name], O.[full_name], O.[packunit], O.[piceunit], O.[unitconv], O.[supp_id], O.[image], O.[open_date], O.[tax_code], O.[merc_type], O.[attr_type], O.[domestic], O.[warranty], O.[status]
				FROM
				    [dbo].[tblGoods] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[goods_id] = PageIndex.[goods_id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblGoods]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblGoods_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblGoods_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblGoods_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblGoods table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblGoods_Insert
(

	@GoodsId char (6)  ,

	@Barcode varchar (20)  ,

	@Mbc bit   ,

	@SafeNameRef nchar (10)  ,

	@GrpId nvarchar (50)  ,

	@ShortName nvarchar (100)  ,

	@FullName nvarchar (200)  ,

	@Packunit char (3)  ,

	@Piceunit char (3)  ,

	@Unitconv decimal (4, 0)  ,

	@SuppId char (5)  ,

	@Image image   ,

	@OpenDate datetime   ,

	@TaxCode nchar (3)  ,

	@MercType nchar (2)  ,

	@AttrType nchar (2)  ,

	@Domestic bit   ,

	@Warranty bit   ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblGoods]
					(
					[goods_id]
					,[barcode]
					,[mbc]
					,[ref]
					,[grp_id]
					,[short_name]
					,[full_name]
					,[packunit]
					,[piceunit]
					,[unitconv]
					,[supp_id]
					,[image]
					,[open_date]
					,[tax_code]
					,[merc_type]
					,[attr_type]
					,[domestic]
					,[warranty]
					,[status]
					)
				VALUES
					(
					@GoodsId
					,@Barcode
					,@Mbc
					,@SafeNameRef
					,@GrpId
					,@ShortName
					,@FullName
					,@Packunit
					,@Piceunit
					,@Unitconv
					,@SuppId
					,@Image
					,@OpenDate
					,@TaxCode
					,@MercType
					,@AttrType
					,@Domestic
					,@Warranty
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblGoods_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblGoods_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblGoods_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblGoods table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblGoods_Update
(

	@GoodsId char (6)  ,

	@OriginalGoodsId char (6)  ,

	@Barcode varchar (20)  ,

	@Mbc bit   ,

	@SafeNameRef nchar (10)  ,

	@GrpId nvarchar (50)  ,

	@ShortName nvarchar (100)  ,

	@FullName nvarchar (200)  ,

	@Packunit char (3)  ,

	@Piceunit char (3)  ,

	@Unitconv decimal (4, 0)  ,

	@SuppId char (5)  ,

	@Image image   ,

	@OpenDate datetime   ,

	@TaxCode nchar (3)  ,

	@MercType nchar (2)  ,

	@AttrType nchar (2)  ,

	@Domestic bit   ,

	@Warranty bit   ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblGoods]
				SET
					[goods_id] = @GoodsId
					,[barcode] = @Barcode
					,[mbc] = @Mbc
					,[ref] = @SafeNameRef
					,[grp_id] = @GrpId
					,[short_name] = @ShortName
					,[full_name] = @FullName
					,[packunit] = @Packunit
					,[piceunit] = @Piceunit
					,[unitconv] = @Unitconv
					,[supp_id] = @SuppId
					,[image] = @Image
					,[open_date] = @OpenDate
					,[tax_code] = @TaxCode
					,[merc_type] = @MercType
					,[attr_type] = @AttrType
					,[domestic] = @Domestic
					,[warranty] = @Warranty
					,[status] = @Status
				WHERE
[goods_id] = @OriginalGoodsId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblGoods_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblGoods_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblGoods_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblGoods table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblGoods_Delete
(

	@GoodsId char (6)  
)
AS


				DELETE FROM [dbo].[tblGoods] WITH (ROWLOCK) 
				WHERE
					[goods_id] = @GoodsId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblGoods_GetByGoodsId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblGoods_GetByGoodsId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblGoods_GetByGoodsId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblGoods table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblGoods_GetByGoodsId
(

	@GoodsId char (6)  
)
AS


				SELECT
					[goods_id],
					[barcode],
					[mbc],
					[ref],
					[grp_id],
					[short_name],
					[full_name],
					[packunit],
					[piceunit],
					[unitconv],
					[supp_id],
					[image],
					[open_date],
					[tax_code],
					[merc_type],
					[attr_type],
					[domestic],
					[warranty],
					[status]
				FROM
					[dbo].[tblGoods]
				WHERE
					[goods_id] = @GoodsId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblGoods_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblGoods_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblGoods_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblGoods table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblGoods_Find
(

	@SearchUsingOR bit   = null ,

	@GoodsId char (6)  = null ,

	@Barcode varchar (20)  = null ,

	@Mbc bit   = null ,

	@SafeNameRef nchar (10)  = null ,

	@GrpId nvarchar (50)  = null ,

	@ShortName nvarchar (100)  = null ,

	@FullName nvarchar (200)  = null ,

	@Packunit char (3)  = null ,

	@Piceunit char (3)  = null ,

	@Unitconv decimal (4, 0)  = null ,

	@SuppId char (5)  = null ,

	@Image image   = null ,

	@OpenDate datetime   = null ,

	@TaxCode nchar (3)  = null ,

	@MercType nchar (2)  = null ,

	@AttrType nchar (2)  = null ,

	@Domestic bit   = null ,

	@Warranty bit   = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [goods_id]
	, [barcode]
	, [mbc]
	, [ref]
	, [grp_id]
	, [short_name]
	, [full_name]
	, [packunit]
	, [piceunit]
	, [unitconv]
	, [supp_id]
	, [image]
	, [open_date]
	, [tax_code]
	, [merc_type]
	, [attr_type]
	, [domestic]
	, [warranty]
	, [status]
    FROM
	[dbo].[tblGoods]
    WHERE 
	 ([goods_id] = @GoodsId OR @GoodsId IS NULL)
	AND ([barcode] = @Barcode OR @Barcode IS NULL)
	AND ([mbc] = @Mbc OR @Mbc IS NULL)
	AND ([ref] = @SafeNameRef OR @SafeNameRef IS NULL)
	AND ([grp_id] = @GrpId OR @GrpId IS NULL)
	AND ([short_name] = @ShortName OR @ShortName IS NULL)
	AND ([full_name] = @FullName OR @FullName IS NULL)
	AND ([packunit] = @Packunit OR @Packunit IS NULL)
	AND ([piceunit] = @Piceunit OR @Piceunit IS NULL)
	AND ([unitconv] = @Unitconv OR @Unitconv IS NULL)
	AND ([supp_id] = @SuppId OR @SuppId IS NULL)
	AND ([open_date] = @OpenDate OR @OpenDate IS NULL)
	AND ([tax_code] = @TaxCode OR @TaxCode IS NULL)
	AND ([merc_type] = @MercType OR @MercType IS NULL)
	AND ([attr_type] = @AttrType OR @AttrType IS NULL)
	AND ([domestic] = @Domestic OR @Domestic IS NULL)
	AND ([warranty] = @Warranty OR @Warranty IS NULL)
	AND ([status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [goods_id]
	, [barcode]
	, [mbc]
	, [ref]
	, [grp_id]
	, [short_name]
	, [full_name]
	, [packunit]
	, [piceunit]
	, [unitconv]
	, [supp_id]
	, [image]
	, [open_date]
	, [tax_code]
	, [merc_type]
	, [attr_type]
	, [domestic]
	, [warranty]
	, [status]
    FROM
	[dbo].[tblGoods]
    WHERE 
	 ([goods_id] = @GoodsId AND @GoodsId is not null)
	OR ([barcode] = @Barcode AND @Barcode is not null)
	OR ([mbc] = @Mbc AND @Mbc is not null)
	OR ([ref] = @SafeNameRef AND @SafeNameRef is not null)
	OR ([grp_id] = @GrpId AND @GrpId is not null)
	OR ([short_name] = @ShortName AND @ShortName is not null)
	OR ([full_name] = @FullName AND @FullName is not null)
	OR ([packunit] = @Packunit AND @Packunit is not null)
	OR ([piceunit] = @Piceunit AND @Piceunit is not null)
	OR ([unitconv] = @Unitconv AND @Unitconv is not null)
	OR ([supp_id] = @SuppId AND @SuppId is not null)
	OR ([open_date] = @OpenDate AND @OpenDate is not null)
	OR ([tax_code] = @TaxCode AND @TaxCode is not null)
	OR ([merc_type] = @MercType AND @MercType is not null)
	OR ([attr_type] = @AttrType AND @AttrType is not null)
	OR ([domestic] = @Domestic AND @Domestic is not null)
	OR ([warranty] = @Warranty AND @Warranty is not null)
	OR ([status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUtils_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUtils_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUtils_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblUtils table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUtils_Get_List

AS


				
				SELECT
					[id],
					[name],
					[Description],
					[subname],
					[Status]
				FROM
					[dbo].[tblUtils]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUtils_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUtils_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUtils_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblUtils table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUtils_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [id] tinyint 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblUtils]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[id], O.[name], O.[Description], O.[subname], O.[Status]
				FROM
				    [dbo].[tblUtils] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[id] = PageIndex.[id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblUtils]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUtils_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUtils_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUtils_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblUtils table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUtils_Insert
(

	@Id tinyint   ,

	@Name nvarchar (100)  ,

	@Description nvarchar (MAX)  ,

	@Subname nvarchar (50)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblUtils]
					(
					[id]
					,[name]
					,[Description]
					,[subname]
					,[Status]
					)
				VALUES
					(
					@Id
					,@Name
					,@Description
					,@Subname
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUtils_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUtils_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUtils_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblUtils table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUtils_Update
(

	@Id tinyint   ,

	@OriginalId tinyint   ,

	@Name nvarchar (100)  ,

	@Description nvarchar (MAX)  ,

	@Subname nvarchar (50)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblUtils]
				SET
					[id] = @Id
					,[name] = @Name
					,[Description] = @Description
					,[subname] = @Subname
					,[Status] = @Status
				WHERE
[id] = @OriginalId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUtils_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUtils_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUtils_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblUtils table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUtils_Delete
(

	@Id tinyint   
)
AS


				DELETE FROM [dbo].[tblUtils] WITH (ROWLOCK) 
				WHERE
					[id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUtils_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUtils_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUtils_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblUtils table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUtils_GetById
(

	@Id tinyint   
)
AS


				SELECT
					[id],
					[name],
					[Description],
					[subname],
					[Status]
				FROM
					[dbo].[tblUtils]
				WHERE
					[id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblUtils_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblUtils_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblUtils_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblUtils table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblUtils_Find
(

	@SearchUsingOR bit   = null ,

	@Id tinyint   = null ,

	@Name nvarchar (100)  = null ,

	@Description nvarchar (MAX)  = null ,

	@Subname nvarchar (50)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [id]
	, [name]
	, [Description]
	, [subname]
	, [Status]
    FROM
	[dbo].[tblUtils]
    WHERE 
	 ([id] = @Id OR @Id IS NULL)
	AND ([name] = @Name OR @Name IS NULL)
	AND ([Description] = @Description OR @Description IS NULL)
	AND ([subname] = @Subname OR @Subname IS NULL)
	AND ([Status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [id]
	, [name]
	, [Description]
	, [subname]
	, [Status]
    FROM
	[dbo].[tblUtils]
    WHERE 
	 ([id] = @Id AND @Id is not null)
	OR ([name] = @Name AND @Name is not null)
	OR ([Description] = @Description AND @Description is not null)
	OR ([subname] = @Subname AND @Subname is not null)
	OR ([Status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblGoodsGrp_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblGoodsGrp_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblGoodsGrp_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the tblGoodsGrp table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblGoodsGrp_Get_List

AS


				
				SELECT
					[Id],
					[Description],
					[Status]
				FROM
					[dbo].[tblGoodsGrp]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblGoodsGrp_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblGoodsGrp_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblGoodsGrp_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the tblGoodsGrp table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblGoodsGrp_GetPaged
(

	@WhereClause varchar (8000)  ,

	@OrderBy varchar (2000)  ,

	@PageIndex int   ,

	@PageSize int   
)
AS


				
				BEGIN
				DECLARE @PageLowerBound int
				DECLARE @PageUpperBound int
				
				-- Set the page bounds
				SET @PageLowerBound = @PageSize * @PageIndex
				SET @PageUpperBound = @PageLowerBound + @PageSize

				-- Create a temp table to store the select results
				CREATE TABLE #PageIndex
				(
				    [IndexId] int IDENTITY (1, 1) NOT NULL,
				    [Id] nvarchar(4)  
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([Id])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [Id]'
				SET @SQL = @SQL + ' FROM [dbo].[tblGoodsGrp]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				IF LEN(@OrderBy) > 0
				BEGIN
					SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
				END
				
				-- Only get the number of rows needed here.
				SET ROWCOUNT @PageUpperBound
				
				-- Populate the temp table
				EXEC sp_executesql @SQL

				-- Reset Rowcount back to all
				SET ROWCOUNT 0
				
				-- Return paged results
				SELECT O.[Id], O.[Description], O.[Status]
				FROM
				    [dbo].[tblGoodsGrp] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[Id] = PageIndex.[Id]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[tblGoodsGrp]'
				IF LEN(@WhereClause) > 0
				BEGIN
					SET @SQL = @SQL + ' WHERE ' + @WhereClause
				END
				EXEC sp_executesql @SQL
			
				END
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblGoodsGrp_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblGoodsGrp_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblGoodsGrp_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the tblGoodsGrp table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblGoodsGrp_Insert
(

	@Id nvarchar (4)  ,

	@Description nvarchar (100)  ,

	@Status bit   
)
AS


				
				INSERT INTO [dbo].[tblGoodsGrp]
					(
					[Id]
					,[Description]
					,[Status]
					)
				VALUES
					(
					@Id
					,@Description
					,@Status
					)
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblGoodsGrp_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblGoodsGrp_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblGoodsGrp_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the tblGoodsGrp table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblGoodsGrp_Update
(

	@Id nvarchar (4)  ,

	@OriginalId nvarchar (4)  ,

	@Description nvarchar (100)  ,

	@Status bit   
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[tblGoodsGrp]
				SET
					[Id] = @Id
					,[Description] = @Description
					,[Status] = @Status
				WHERE
[Id] = @OriginalId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblGoodsGrp_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblGoodsGrp_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblGoodsGrp_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the tblGoodsGrp table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblGoodsGrp_Delete
(

	@Id nvarchar (4)  
)
AS


				DELETE FROM [dbo].[tblGoodsGrp] WITH (ROWLOCK) 
				WHERE
					[Id] = @Id
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblGoodsGrp_GetById procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblGoodsGrp_GetById') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblGoodsGrp_GetById
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the tblGoodsGrp table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblGoodsGrp_GetById
(

	@Id nvarchar (4)  
)
AS


				SELECT
					[Id],
					[Description],
					[Status]
				FROM
					[dbo].[tblGoodsGrp]
				WHERE
					[Id] = @Id
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.usptblGoodsGrp_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.usptblGoodsGrp_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.usptblGoodsGrp_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the tblGoodsGrp table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usptblGoodsGrp_Find
(

	@SearchUsingOR bit   = null ,

	@Id nvarchar (4)  = null ,

	@Description nvarchar (100)  = null ,

	@Status bit   = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [Id]
	, [Description]
	, [Status]
    FROM
	[dbo].[tblGoodsGrp]
    WHERE 
	 ([Id] = @Id OR @Id IS NULL)
	AND ([Description] = @Description OR @Description IS NULL)
	AND ([Status] = @Status OR @Status IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [Id]
	, [Description]
	, [Status]
    FROM
	[dbo].[tblGoodsGrp]
    WHERE 
	 ([Id] = @Id AND @Id is not null)
	OR ([Description] = @Description AND @Description is not null)
	OR ([Status] = @Status AND @Status is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

