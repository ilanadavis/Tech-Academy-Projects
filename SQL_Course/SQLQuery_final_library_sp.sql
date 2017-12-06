USE db_library;
GO

CREATE PROCEDURE uspNumberCopies
	@Title nvarchar(100),
	@BranchName nvarchar(100)
AS
	SELECT No_Of_Copies
	FROM Book_Copies 
	INNER JOIN Book ON book_copies.BookId = book.BookID
	INNER JOIN Library_Branch ON Book_Copies.BranchID = Library_Branch.BranchID
	WHERE Title= @Title
	AND BranchName= @BranchName
	;
GO

EXEC uspNumberCopies @Title= 'The Lost Tribe', @BranchName= 'Sharpstown';
GO