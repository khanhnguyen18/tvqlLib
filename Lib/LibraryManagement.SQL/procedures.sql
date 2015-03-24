
USE [LibraryManagement]
GO
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.Book_Get_List procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.Book_Get_List') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.Book_Get_List
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets all records from the Book table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.Book_Get_List

AS


				
				SELECT
					[BookId],
					[BookCode],
					[BookName],
					[Author],
					[PublisherId],
					[BookCategoryId],
					[YearPublisher],
					[Quantity],
					[Description]
				FROM
					[dbo].[Book]
					
				SELECT @@ROWCOUNT
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.Book_GetPaged procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.Book_GetPaged') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.Book_GetPaged
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Gets records from the Book table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.Book_GetPaged
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
				    [BookId] bigint 
				)
				
				-- Insert into the temp table
				DECLARE @SQL AS nvarchar(4000)
				SET @SQL = 'INSERT INTO #PageIndex ([BookId])'
				SET @SQL = @SQL + ' SELECT'
				SET @SQL = @SQL + ' [BookId]'
				SET @SQL = @SQL + ' FROM [dbo].[Book]'
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
				SELECT O.[BookId], O.[BookCode], O.[BookName], O.[Author], O.[PublisherId], O.[BookCategoryId], O.[YearPublisher], O.[Quantity], O.[Description]
				FROM
				    [dbo].[Book] O,
				    #PageIndex PageIndex
				WHERE
				    PageIndex.IndexId > @PageLowerBound
					AND O.[BookId] = PageIndex.[BookId]
				ORDER BY
				    PageIndex.IndexId
                
				-- get row count
				SET @SQL = 'SELECT COUNT(1) AS TotalRowCount'
				SET @SQL = @SQL + ' FROM [dbo].[Book]'
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

	

-- Drop the dbo.Book_Insert procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.Book_Insert') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.Book_Insert
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Inserts a record into the Book table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.Book_Insert
(

	@BookId bigint    OUTPUT,

	@BookCode nvarchar (50)  ,

	@BookName nvarchar (1000)  ,

	@Author nvarchar (2000)  ,

	@PublisherId char (9)  ,

	@BookCategoryId char (10)  ,

	@YearPublisher varchar (4)  ,

	@Quantity int   ,

	@Description nvarchar (4000)  
)
AS


				
				INSERT INTO [dbo].[Book]
					(
					[BookCode]
					,[BookName]
					,[Author]
					,[PublisherId]
					,[BookCategoryId]
					,[YearPublisher]
					,[Quantity]
					,[Description]
					)
				VALUES
					(
					@BookCode
					,@BookName
					,@Author
					,@PublisherId
					,@BookCategoryId
					,@YearPublisher
					,@Quantity
					,@Description
					)
				-- Get the identity value
				SET @BookId = SCOPE_IDENTITY()
									
							
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.Book_Update procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.Book_Update') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.Book_Update
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Updates a record in the Book table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.Book_Update
(

	@BookId bigint   ,

	@BookCode nvarchar (50)  ,

	@BookName nvarchar (1000)  ,

	@Author nvarchar (2000)  ,

	@PublisherId char (9)  ,

	@BookCategoryId char (10)  ,

	@YearPublisher varchar (4)  ,

	@Quantity int   ,

	@Description nvarchar (4000)  
)
AS


				
				
				-- Modify the updatable columns
				UPDATE
					[dbo].[Book]
				SET
					[BookCode] = @BookCode
					,[BookName] = @BookName
					,[Author] = @Author
					,[PublisherId] = @PublisherId
					,[BookCategoryId] = @BookCategoryId
					,[YearPublisher] = @YearPublisher
					,[Quantity] = @Quantity
					,[Description] = @Description
				WHERE
[BookId] = @BookId 
				
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.Book_Delete procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.Book_Delete') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.Book_Delete
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Deletes a record in the Book table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.Book_Delete
(

	@BookId bigint   
)
AS


				DELETE FROM [dbo].[Book] WITH (ROWLOCK) 
				WHERE
					[BookId] = @BookId
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.Book_GetByBookId procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.Book_GetByBookId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.Book_GetByBookId
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Select records from the Book table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.Book_GetByBookId
(

	@BookId bigint   
)
AS


				SELECT
					[BookId],
					[BookCode],
					[BookName],
					[Author],
					[PublisherId],
					[BookCategoryId],
					[YearPublisher],
					[Quantity],
					[Description]
				FROM
					[dbo].[Book]
				WHERE
					[BookId] = @BookId
				SELECT @@ROWCOUNT
					
			

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

	

-- Drop the dbo.Book_Find procedure
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'dbo.Book_Find') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE dbo.Book_Find
GO

/*
----------------------------------------------------------------------------------------------------

-- Created By:  ()
-- Purpose: Finds records in the Book table passing nullable parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.Book_Find
(

	@SearchUsingOR bit   = null ,

	@BookId bigint   = null ,

	@BookCode nvarchar (50)  = null ,

	@BookName nvarchar (1000)  = null ,

	@Author nvarchar (2000)  = null ,

	@PublisherId char (9)  = null ,

	@BookCategoryId char (10)  = null ,

	@YearPublisher varchar (4)  = null ,

	@Quantity int   = null ,

	@Description nvarchar (4000)  = null 
)
AS


				
  IF ISNULL(@SearchUsingOR, 0) <> 1
  BEGIN
    SELECT
	  [BookId]
	, [BookCode]
	, [BookName]
	, [Author]
	, [PublisherId]
	, [BookCategoryId]
	, [YearPublisher]
	, [Quantity]
	, [Description]
    FROM
	[dbo].[Book]
    WHERE 
	 ([BookId] = @BookId OR @BookId IS NULL)
	AND ([BookCode] = @BookCode OR @BookCode IS NULL)
	AND ([BookName] = @BookName OR @BookName IS NULL)
	AND ([Author] = @Author OR @Author IS NULL)
	AND ([PublisherId] = @PublisherId OR @PublisherId IS NULL)
	AND ([BookCategoryId] = @BookCategoryId OR @BookCategoryId IS NULL)
	AND ([YearPublisher] = @YearPublisher OR @YearPublisher IS NULL)
	AND ([Quantity] = @Quantity OR @Quantity IS NULL)
	AND ([Description] = @Description OR @Description IS NULL)
						
  END
  ELSE
  BEGIN
    SELECT
	  [BookId]
	, [BookCode]
	, [BookName]
	, [Author]
	, [PublisherId]
	, [BookCategoryId]
	, [YearPublisher]
	, [Quantity]
	, [Description]
    FROM
	[dbo].[Book]
    WHERE 
	 ([BookId] = @BookId AND @BookId is not null)
	OR ([BookCode] = @BookCode AND @BookCode is not null)
	OR ([BookName] = @BookName AND @BookName is not null)
	OR ([Author] = @Author AND @Author is not null)
	OR ([PublisherId] = @PublisherId AND @PublisherId is not null)
	OR ([BookCategoryId] = @BookCategoryId AND @BookCategoryId is not null)
	OR ([YearPublisher] = @YearPublisher AND @YearPublisher is not null)
	OR ([Quantity] = @Quantity AND @Quantity is not null)
	OR ([Description] = @Description AND @Description is not null)
	SELECT @@ROWCOUNT			
  END
				

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS OFF 
GO

