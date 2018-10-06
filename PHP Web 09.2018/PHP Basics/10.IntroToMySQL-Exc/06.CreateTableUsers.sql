create table users (
	id int not null auto_increment,
	username varchar(200) not null,
	`password` varchar(200) not null,
	profile_picture mediumblob null,
	last_login_time timestamp,
	is_deleted enum('true', 'false'),
	PRIMARY KEY (`id`)	
);
insert into users (username, `password`, is_deleted)
values ('Pesho', '123', 'false'), ('Gosho', '232', 'false'), ('Irina', 'egregr', 'false'), 
('Grudi', 'effwe', 'false'), ('Donna', 'wgwgtowns', 'false');