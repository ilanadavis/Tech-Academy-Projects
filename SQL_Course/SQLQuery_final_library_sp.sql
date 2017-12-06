USE db_library;
GO

DROP PROCEDURE IF EXISTS uspNumberCopies;  
GO  
--number of copies of the book titled The Lost Tribe owned in branch Sharpstown
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
/*
EXEC uspNumberCopies @Title= 'The Lost Tribe', @BranchName= 'Sharpstown';
GO
*/

DROP PROCEDURE IF EXISTS uspNumberCopiesAllBranches;  
GO  
--Number of copies of The Lost Tribe in each branch
CREATE PROCEDURE uspNumberCopiesAllBranches
	@Title nvarchar(100)
AS
	SELECT BranchName, No_Of_Copies
	FROM Book_Copies 
	INNER JOIN Book ON book_copies.BookId = book.BookID
	INNER JOIN Library_Branch ON Book_Copies.BranchID = Library_Branch.BranchID
	WHERE Title= @Title
	;
GO
/*
EXEC uspNumberCopiesAllBranches @Title= 'The Lost Tribe';
GO
*/

DROP PROCEDURE IF EXISTS uspBorrowers_not_checked_out;  
GO  
--Names of borrowers who do not have books checked out
CREATE PROCEDURE uspBorrowers_not_checked_out
AS
	SELECT Name
	FROM Borrower
	LEFT JOIN BookLoans ON borrower.cardno = BookLoans.CardNo
	WHERE bookloans.CardNo IS NULL
	;
GO

EXEC uspBorrowers_not_checked_out;
GO

