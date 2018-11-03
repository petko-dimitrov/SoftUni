CREATE DATABASE IF NOT EXISTS `orm_view_engine` /*!40100 COLLATE 'utf8_general_ci' */;

USE `orm_view_engine`;

CREATE TABLE IF NOT EXISTS users (
  id  INT NOT NULL AUTO_INCREMENT,
  username VARCHAR(255) NOT NULL,
  password VARCHAR(255) NOT NULL,
  first_name VARCHAR(255) NOT NULL,
  last_name VARCHAR(255) NOT NULL,
  born_on TIMESTAMP NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE (username)
);