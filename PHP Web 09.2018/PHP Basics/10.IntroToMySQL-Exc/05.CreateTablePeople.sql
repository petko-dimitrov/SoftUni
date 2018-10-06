create table people (
	id int not null auto_increment,
	name varchar(200) not null,
	picture mediumblob null,
	height decimal(2,2) null,
	weight decimal(2,2) null,
	gender enum('m', 'f') not null,
	birthdate date not null,
	biography longtext null,
	PRIMARY KEY (`id`)	
);
insert into people (name, gender, birthdate)
values ('Pesho', 'm', '1987-04-07'), ('Gosho', 'm', '1987-02-22'), ('Irina', 'f', '1987-04-14'), 
('Grudi', 'm', '1992-05-07'), ('Donna', 'f', '1988-05-23');