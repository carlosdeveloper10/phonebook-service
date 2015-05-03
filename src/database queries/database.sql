--Architecture information
--(-1)DBMS: Sql server 2012.
--(-2)Edition: Express Edition (64-bit) on Windows NT 6.1 <X64> (Build 7601: Service Pack 1)
--(-3)Version: 11.0.2100.60 (X64) 
--(-4)Operative system: Microsoft windows 7 professional (x64)


--This code creates the Phonebook database.
--IMPORTANT: read information for each table
CREATE DATABASE  PhoneBook
GO

USE PhoneBook
GO

CREATE TABLE Person(
	userName VARCHAR(100) PRIMARY KEY,
	name VARCHAR(100),
	lastName VARCHAR(10),
	cellPhone VARCHAR(30),
	mail VARCHAR(100) UNIQUE,
	pass VARCHAR(100)
)
GO

--Country Code: more info, vist the next web site:
--(https://countrycode.org/), (http://en.wikipedia.org/wiki/List_of_country_calling_codes)
CREATE TABLE Country(
	code VARCHAR(8) PRIMARY KEY,
	countryName VARCHAR(50)
)
GO

--Contact type, example: work, university, home, family, love, ect.
--The picture is into the server, here only is the image url.
CREATE TABLE ContactType(
	id SMALLINT IDENTITY(1, 1) PRIMARY KEY,
	typeName VARCHAR(30),
	picture VARCHAR(100)
)
GO

--Contact information.
CREATE TABLE Contact(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	name VARCHAR(100),
	lastName VARCHAR(100),
	nickName VARCHAR(100),
	about VARCHAR(300),
	contactTypeId SMALLINT REFERENCES ContactType(id),
	userName VARCHAR(100) REFERENCES Person(userName)
)
GO 

CREATE TABLE Number(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	number VARCHAR(30),
	codeCountry VARCHAR(8) REFERENCES Country(code),
	contactId INT REFERENCES Contact(id)
)
GO

--Email contact
CREATE TABLE Email(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	mail VARCHAR(100),
	contactId INT REFERENCES Contact(id)
)
GO