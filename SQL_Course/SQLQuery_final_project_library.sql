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

INSERT INTO Borrower
	(CardNo, Name, Address, Phone)
	VALUES
	('21', 'Dan Jones', '235 Pike Street', '235-254-5825'),
	('22', 'Pica Chu', '25672 West North Ave', '583-682-5822'),
	('23', 'Pablo Martinez', '390 Baker Street', '325-139-5391'),
	('24', 'Apple Pie', '391 Miller', '891-235-1383'),
	('25', 'Mary Jane', '7936 Nathan Ave', '863-091-0003'),
	('26', 'Anna Princes', '369 Arendel', '563-235-6311'),
	('27', 'Belle Beast', '13 Castle Road', '259-130-0245'),
	('28', 'Todd Marble', '356 North Pole', '946-090-0130')
	;

INSERT INTO Book_Copies
	(BookID, BranchID, No_Of_Copies)
	VALUES
	('1', 'S', '3'),
	('2', 'S', '5'),
	('3', 'C', '3'),
	('4', 'N', '9'),
	('5', 'C', '6'),
	('6', 'S', '5'),
	('7', 'E', '8'),
	('8', 'E', '3'),
	('9', 'S', '3'),
	('10', 'S', '9'),
	('11', 'E', '9'),
	('12', 'C', '4'),
	('13', 'N', '3'),
	('14', 'C', '8'),
	('15', 'S', '4'),
	('16', 'E', '6'),
	('17', 'N', '7'),
	('18', 'S', '7'),
	('19', 'E', '4'),
	('20', 'C', '6'),
	('1', 'C', '7'),
	('2', 'C', '4'),
	('3', 'N', '3'),
	('4', 'C', '6'),
	('5', 'S', '5'),
	('6', 'E', '5'),
	('7', 'S', '8'),
	('8', 'S', '9'),
	('9', 'E', '4'),
	('10', 'E', '5'),
	('11', 'C', '7'),
	('12', 'N', '3'),
	('13', 'E', '7'),
	('14', 'N', '9'),
	('15', 'E', '3'),
	('16', 'N', '5'),
	('17', 'C', '7'),
	('18', 'N', '8'),
	('19', 'N', '8'),
	('20', 'N', '4')
	;

INSERT INTO BookLoans
	(BookID, BranchID, CardNo, DateOut, DueDate)
	VALUES
	('4', 'N', '21', '2017.08.01', '2017.08.22'),
	('5', 'C', '21', '2017.12.01', '2017.12.22'),
	('1', 'S', '21', '2017.10.11', '2017.10.31'),
	('8', 'E', '21', '2017.10.11', '2017.10.31'),
	('9', 'S', '21', '2017.12.01', '2017.12.22'),
	('11', 'C', '22', '2017.12.01', '2017.12.22'),
	('20', 'N', '22', '2017.12.01', '2017.12.22'),
	('5', 'C', '22', '2017.12.01', '2017.12.22'),
	('3', 'C', '22', '2017.11.17', '2017.12.01'),
	('1', 'C', '22', '2017.08.01', '2017.08.22'),
	('9', 'E', '23', '2017.12.01', '2017.12.22'),
	('12', 'N', '24', '2017.12.01', '2017.12.22'),
	('15', 'E', '26', '2017.12.01', '2017.12.22'),
	('18', 'S', '25', '2017.10.11', '2017.10.31'),
	('20', 'C', '21', '2017.12.01', '2017.12.22'),
	('6', 'E', '28', '2017.10.11', '2017.10.31'),
	('4', 'C', '23', '2017.12.01', '2017.12.22'),
	('3', 'N', '24', '2017.08.01', '2017.08.22'),
	('5', 'S', '25', '2017.12.01', '2017.12.22'),
	('20', 'N', '26', '2017.12.01', '2017.12.22'),
	('12', 'C', '21', '2017.12.01', '2017.12.22'),
	('12', 'C', '28', '2017.08.01', '2017.08.22'),
	('18', 'N', '21', '2017.12.01', '2017.12.22'),
	('9', 'S', '22', '2017.11.17', '2017.12.01'),
	('2', 'C', '23', '2017.11.17', '2017.12.01'),
	('10', 'E', '24', '2017.10.11', '2017.10.31'),
	('3', 'N', '25', '2017.12.01', '2017.12.22'),
	('14', 'C', '26', '2017.12.01', '2017.12.22'),
	('1', 'C', '23', '2017.12.01', '2017.12.22'),
	('9', 'S', '28', '2017.12.01', '2017.12.22'),
	('6', 'E', '21', '2017.12.01', '2017.12.22'),
	('14', 'N', '22', '2017.12.01', '2017.12.22'),
	('15', 'E', '23', '2017.08.01', '2017.08.22'),
	('8', 'S', '24', '2017.12.01', '2017.12.22'),
	('16', 'E', '25', '2017.11.17', '2017.12.01'),
	('6', 'S', '26', '2017.12.01', '2017.12.22'),
	('18', 'N', '22', '2017.12.01', '2017.12.22'),
	('7', 'E', '28', '2017.12.01', '2017.12.22'),
	('20', 'C', '25', '2017.12.01', '2017.12.22'),
	('15', 'S', '21', '2017.12.01', '2017.12.22'),
	('19', 'N', '22', '2017.11.17', '2017.12.01'),
	('13', 'N', '23', '2017.12.01', '2017.12.22'),
	('11', 'C', '24', '2017.08.01', '2017.08.22'),
	('19', 'N', '25', '2017.12.01', '2017.12.22'),
	('7', 'S', '26', '2017.12.01', '2017.12.22'),
	('9', 'E', '24', '2017.12.01', '2017.12.22'),
	('17', 'C', '28', '2017.11.17', '2017.12.01'),
	('2', 'C', '24', '2017.11.17', '2017.12.01'),
	('9', 'S', '25', '2017.12.01', '2017.12.09'),
	('13', 'N', '22', '2017.12.01', GetDate())
	;