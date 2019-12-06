CREATE DATABASE dbIoasys
use dbIoasys

CREATE TABLE TbUser (
    userId int NOT NULL,
    email varchar(50) NOT NULL,
    password varchar(50) NOT NULL,
	PRIMARY KEY (userId)
);

CREATE TABLE TbType (
    typeId int NOT NULL,
    name varchar(50) NOT NULL,
	PRIMARY KEY (typeId)
);

CREATE TABLE TbEnterprise (
	enterpriseId int NOT NULL,
	type int FOREIGN KEY REFERENCES TbType(typeId) NOT NULL,
	name varchar(50) NOT NULL,
	PRIMARY KEY (enterpriseId)
);

INSERT INTO TbUser VALUES (1, 'testeapple@ioasys.com.br', '12341234');

INSERT INTO TbType VALUES (1, 'Agro');
INSERT INTO TbType VALUES (2, 'Aviation');
INSERT INTO TbType VALUES (3, 'Biotech');
INSERT INTO TbType VALUES (4, 'Eco');
INSERT INTO TbType VALUES (5, 'Ecommerce');
INSERT INTO TbType VALUES (6, 'Education');
INSERT INTO TbType VALUES (7, 'Fashion');
INSERT INTO TbType VALUES (8, 'Fintech');
INSERT INTO TbType VALUES (9, 'Food');
INSERT INTO TbType VALUES (10, 'Games');
INSERT INTO TbType VALUES (11, 'Health');
INSERT INTO TbType VALUES (12, 'IOT');
INSERT INTO TbType VALUES (13, 'Logistics');
INSERT INTO TbType VALUES (14, 'Media');
INSERT INTO TbType VALUES (15, 'Mining');
INSERT INTO TbType VALUES (16, 'Products');
INSERT INTO TbType VALUES (17, 'Real State');
INSERT INTO TbType VALUES (18, 'Service');
INSERT INTO TbType VALUES (19, 'Smart City');
INSERT INTO TbType VALUES (20, 'Social');
INSERT INTO TbType VALUES (21, 'Software');
INSERT INTO TbType VALUES (22, 'Technology');
INSERT INTO TbType VALUES (23, 'Tourism');
INSERT INTO TbType VALUES (24, 'Transport');

INSERT INTO TbEnterprise VALUES (1, 22, 'ioasys');
INSERT INTO TbEnterprise VALUES (2, 22, 'Microsoft');
INSERT INTO TbEnterprise VALUES (3, 22, 'Google');
INSERT INTO TbEnterprise VALUES (4, 22, 'Facebook');
INSERT INTO TbEnterprise VALUES (5, 22, 'Amazon');
INSERT INTO TbEnterprise VALUES (6, 22, 'Baidu');
INSERT INTO TbEnterprise VALUES (7, 10, 'Capcom');
INSERT INTO TbEnterprise VALUES (8, 9, 'UberEats');
INSERT INTO TbEnterprise VALUES (9, 1, 'aQm');

