USE master

IF EXISTS(select * from sys.databases where name='PersonDB')
DROP DATABASE PersonDB

GO

CREATE DATABASE PersonDB;

GO

USE PersonDB;


GO


CREATE TABLE Person
(
	recID int identity NOT NULL PRIMARY KEY,
    firstName nvarchar(100) NULL,
	lastName nvarchar(100) NULL,
	position nvarchar(100) NULL,
	age int NULL	
);


INSERT INTO Person VALUES ('Abraham','Lincoln','US President during American civil war',56)
INSERT INTO Person VALUES ('Nelson','Mandela','South African President anti-apartheid campaigner',96)
INSERT INTO Person VALUES ('Bill','Gates','American businessman, Founder of Microsoft',60)
INSERT INTO Person VALUES ('Charles','de Gaulle','French resistance leader and President',80)
INSERT INTO Person VALUES ('Christoper','Columbus','Italian Explorer',55)

SELECT * FROM Person;



