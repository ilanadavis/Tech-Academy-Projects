USE master
IF EXISTS(select * from sys.databases where name='db_library')
DROP DATABASE db_library

CREATE DATABASE db_library

USE db_library

-- TABLES--

CREATE TABLE Publisher (
	Name varchar(100) NOT NULL PRIMARY KEY,
	Address varchar(100) NOT NULL,
	Phone varchar(50) NOT NULL
	);

CREATE TABLE BOOK (
	BookID INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	Title varchar(100) NOT NULL,
	PublisherName varchar(100) NOT NULL CONSTRAINT fk_book_name FOREIGN KEY REFERENCES Publisher (Name) ON UPDATE CASCADE ON DELETE CASCADE
	);

CREATE TABLE Book_Authors (
	BookId INT NOT NULL CONSTRAINT fk_book_authors_bookid FOREIGN KEY REFERENCES Book(BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	AuthorName varchar(100) NOT NULL
	);

CREATE TABLE Library_Branch (
	BranchID varchar(100) PRIMARY KEY NOT NULL,
	BranchName varchar(100) NOT NULL,
	Address varchar(100) NOT NULL,
	);

CREATE TABLE Borrower (
	CardNo INT PRIMARY KEY NOT NULL,
	Name varchar(100) NOT NULL,
	Address varchar(100) NOT NULL,
	Phone varchar (100) NOT NULL
	);

CREATE TABLE BookLoans (
	BookId INT NOT NULL CONSTRAINT fk_book_loans_bookid FOREIGN KEY REFERENCES Book(BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchID varchar(100) NOT NULL CONSTRAINT fk_book_loans_branchid FOREIGN KEY REFERENCES Library_Branch(BranchID) ON UPDATE CASCADE ON DELETE CASCADE,
	CardNo INT NOT NULL CONSTRAINT fk_book_loans_CardNo FOREIGN KEY REFERENCES Borrower(CardNo) ON UPDATE CASCADE ON DELETE CASCADE,
	DateOut DATE NOT NULL,
	DueDate DATE NOT NULL
	);

CREATE TABLE Book_Copies (
	BookId INT NOT NULL CONSTRAINT fk_book_copies_bookid FOREIGN KEY REFERENCES Book(BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchID varchar(100) NOT NULL CONSTRAINT fk_book_copies_branchid FOREIGN KEY REFERENCES Library_Branch(BranchID) ON UPDATE CASCADE ON DELETE CASCADE,
	No_Of_Copies INT NOT NULL
	);


INSERT INTO Publisher
	(Name, Address, Phone)
	Values
	('Random House 1', '231 Wish Street', 'Ext 321'),
	('Gray Publishing', '2941 Mill Street', 'Ext 462'),
	('McDonald Publishing House 1', '0561 Market Avenue', 'Ext 183'),
	('Random House 2', '232 Wish Street', 'Ext 324'),
	('Gray Publishing 2', '2942 Mill Street', 'Ext 465'),
	('McDonald Publishing House 2', '0562 Market Avenue', 'Ext 186'),
	('Random House 3', '233 Wish Street', 'Ext 327'),
	('Gray Publishing 3', '2943 Mill Street', 'Ext 468'),
	('McDonald Publishing House 3', '0563 Market Avenue', 'Ext 189'),
	('Random House 4', '234 Wish Street', 'Ext 320'),
	('Gray Publishing 4', '2944 Mill Street', 'Ext 165'),
	('McDonald Publishing House 4', '0564 Market Avenue', 'Ext 284'),
	('Random House 5', '235 Wish Street', 'Ext 325'),
	('Gray Publishing 5', '2945 Mill Street', 'Ext 465'),
	('McDonald Publishing House 5', '0565 Market Avenue', 'Ext 584'),
	('Random House 6', '236 Wish Street', 'Ext 625'),
	('Gray Publishing 6', '2946 Mill Street', 'Ext 765'),
	('McDonald Publishing House 6', '0566 Market Avenue', 'Ext 884'),
	('Random House 7', '237 Wish Street', 'Ext 925'),
	('Gray Publishing 7', '2947 Mill Street', 'Ext 065')
	;

INSERT INTO BOOK
	(Title, PublisherName)
	VALUES
	('The Lost Tribe', 'Random House 1'),
	('The Corrections', 'Gray Publishing'),
	('Atonement', 'McDonald Publishing House 1'),
	('White Teeth', 'Random House 2'),
	('Austerlitz', 'Gray Publishing 2'),
	('The Amazing Adventures of Kavalier and Clay', 'McDonald Publishing House 2'),
	('The Road', 'Random House 3'),
	('The Brief Wondrous Life of Oscar Wao', 'Gray Publishing 3'),
	('Never Let Me Go', 'McDonald Publishing House 3'),
	('The Book Theif', 'Random House 4'),
	('Poems', 'Gray Publishing 4'),
	('Middlesex', 'McDonald Publishing House 4'),
	('2666', 'Random House 5'),
	('Cloud Atlas', 'Gray Publishing 5'),
	('Balzac and the Little Chinese Seamstress', 'McDonald Publishing House 5'),
	('The Sense of an Ending', 'Random House 6'),
	('Jimmy Corrigan, the Smartest Kid on Earth', 'Gray Publishing 6'),
	('The Fault in Our Stars', 'McDonald Publishing House 6'),
	('Wolf Hall', 'Random House 7'),
	('The Kit Runner', 'Gray Publishing 7')
	;

INSERT INTO Library_Branch
	(BranchID, BranchName, Address)
	VALUES
	('S', 'Sharpstown', '123 Mickey'),
	('C', 'Central', '57013 Donald'),
	('N', 'NorthWest', '395 Goofy'),
	('E', 'East', '230 Daisy')
	;

INSERT INTO Book_Authors
	(BookId, AuthorName)
	VALUES
	('1', 'Stephen King'),
	('2', 'John Franzen'),
	('3', 'Ian McEwan'),
	('4', 'Zadie Smith'),
	('5', 'W.G. Sebald'),
	('6', 'Michael Chabon'),
	('7', 'Cormac McCarthy'),
	('8', 'Junot Diaz'),
	('9', 'Kazuo Ishiguro'),
	('10', 'Marcus Zusak'),
	('11', 'Paul Celan'),
	('12', 'Jeffrey Eugenides'),
	('13', 'Roberto Bolano'),
	('14', 'David Mitchell'),
	('15', 'Dai Sijie'),
	('16', 'Julian Barnes'),
	('17', 'Chris Ware'),
	('18', 'John Green'),
	('19', 'Hilary Mantel'),
	('20', 'Khaled Hosseini')
	;
/*
INSERT INTO Borrower
	(CardNo)
	VALUES
	(''),
	(''),
	(''),
	(''),
	(''),
	(''),
	(''),
	('')
	;
	*/