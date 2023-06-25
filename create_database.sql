CREATE DATABASE agriharvest;

USE agriharvest;

CREATE TABLE Category (
	id int NOT NULL IDENTITY,
	name varchar(20) NOT NULL,
	PRIMARY KEY(id));
	
CREATE TABLE Product (
	id int NOT NULL IDENTITY,
	price float NOT NULL,
	libelle varchar(20) NOT NULL,
	category_id int NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(category_id) 
		REFERENCES Category(id)); 
