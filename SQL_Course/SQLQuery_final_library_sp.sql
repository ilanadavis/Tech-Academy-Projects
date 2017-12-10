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

EXEC uspNumberCopies @Title= 'The Lost Tribe', @BranchName= 'Sharpstown';
GO


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

EXEC uspNumberCopiesAllBranches @Title= 'The Lost Tribe';
GO


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



DROP PROCEDURE IF EXISTS uspSharpstown_books_due_today;  
GO  
--Sharpstown books due today
CREATE PROCEDURE uspSharpstown_books_due_today
AS
	SELECT Title, Borrower.Name, Borrower.Address
	FROM BookLoans
	INNER JOIN BOOK ON BookLoans.BookId = Book.BookID
	INNER JOIN Library_Branch ON BookLoans.BranchID = Library_Branch.BranchID
	INNER JOIN Borrower ON Bookloans.CardNo = Borrower.CardNo
	WHERE Bookloans.DueDate = Convert(date, GETDATE())
	AND Library_Branch.BranchName = 'Sharpstown'
	;
GO

EXEC uspSharpstown_books_due_today;
GO



DROP PROCEDURE IF EXISTS uspBranch_with_books_on_loan;  
GO  
--List of branches with books currently out on loan
CREATE PROCEDURE uspBranch_with_books_on_loan
AS
	SELECT BranchName, COUNT(Bookloans.BranchID) 'Number of books on loan'
	FROM Library_Branch
	INNER JOIN BookLoans ON Library_Branch.BranchID = BookLoans.BranchID
	WHERE Bookloans.BranchID IS NOT NULL
	GROUP BY BranchName
	;
GO

EXEC uspBranch_with_books_on_loan;
GO


DROP PROCEDURE IF EXISTS uspMore_Than_5_books;  
GO  
--List of borrowers with 5 or more books on loan
CREATE PROCEDURE uspMore_Than_5_books
AS
	SELECT Borrower.Name, Borrower.Address, COUNT(BookLoans.CardNo) 'Number of Loans'
	FROM Borrower
	INNER JOIN BookLoans ON Borrower.CardNo = BookLoans.CardNo
	GROUP BY Borrower.Name, Borrower.Address
	HAVING COUNT(BookLoans.CardNo) >5
	;
GO

EXEC uspMore_Than_5_books;
GO


DROP PROCEDURE IF EXISTS uspStephenKing_copies_per_branch;  
GO  
--Title and number of copies of Stephen King books in Central Branch

CREATE PROCEDURE uspStephenKing_copies_per_branch
	@AuthorName nvarchar(100),
	@BranchName nvarchar(100)
AS
	SELECT Book.Title, Book_Copies.No_Of_Copies, AuthorName
	FROM Book_Copies 
	INNER JOIN Book ON book_copies.BookId = book.BookID
	INNER JOIN Book_Authors ON Book.BookID = Book_Authors.BookId
	INNER JOIN Library_Branch ON Book_Copies.BranchID = Library_Branch.BranchID
	WHERE AuthorName= @AuthorName
	AND BranchName= @BranchName
	;
GO

EXEC uspStephenKing_copies_per_branch @AuthorName= 'Stephen King', @BranchName= 'Central'
;
GO
*/