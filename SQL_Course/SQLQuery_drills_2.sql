
CREATE TABLE tbl_name (
	name_id INT PRIMARY Key NOT NULL IDENTITY (1,1),
	name_fullname VARCHAR(50) NOT NULL,
	);

USE db_names

INSERT INTO tbl_name
	(name_fullname)
	VALUES
	('Bill Smith'),
	('Dolly Jo');
	
SELECT * FROM tbl_name;

USE db_names
CREATE TABLE tbl_contact (
	contact_id INT PRIMARY Key NOT NULL IDENTITY (1,1),
	contact_number VARCHAR(50) NOT NULL,
	name_userid INT NOT NULL,
	);

INSERT INTO tbl_contact
	(contact_number, name_userid)
	VALUES
	('123-456-7890', '45'),
	('098-765,4321', '46');

UPDATE tbl_contact
	SET name_userid = 2
	WHERE contact_number= '098-765,4321';


SELECT * FROM tbl_contact;

SELECT name_fullname, contact_number FROM tbl_contact
	INNER JOIN tbl_name ON tbl_contact.name_userid = tbl_name.name_id
	WHERE name_fullname = 'Bill Smith';

