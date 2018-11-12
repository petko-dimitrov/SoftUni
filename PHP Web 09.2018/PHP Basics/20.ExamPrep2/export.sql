CREATE DATABASE IF NOT EXISTS `money` /*!40100 COLLATE 'utf8_general_ci' */;

USE `money`;

CREATE TABLE IF NOT EXISTS `users` (
  `user_id` INT(11) NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(255) NOT NULL,
  `password` VARCHAR(255) NOT NULL,
  `full_name` VARCHAR(255) NOT NULL,
  `born_on` DATE NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE INDEX `username` (`username`)
)
  ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS `reasons` (
  `reason_id` INT(11) NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`reason_id`)
)
  ENGINE=InnoDB;

CREATE TABLE `operations` (
  `operation_id` INT(11) NOT NULL AUTO_INCREMENT,
  `type` CHAR NOT NULL,
  `reason_id` INT NOT NULL,
  `sum` DECIMAL(7,2) NULL DEFAULT '0',
  `notes` VARCHAR(255) NOT NULL,
  `on_date` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `for_date` DATE NULL DEFAULT NULL,
  `user_id` INT NOT NULL,
  PRIMARY KEY (`operation_id`),
  INDEX `FK_operations_reasons` (`reason_id`),
  INDEX `FK_operations_users` (`user_id`),
  CONSTRAINT `FK_operations_reasons` FOREIGN KEY (`reason_id`) REFERENCES `reasons` (`reason_id`),
  CONSTRAINT `FK_operations_users` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`)
)
  COLLATE='utf8_general_ci'
  ENGINE=InnoDB
;

INSERT INTO `reasons` (`name`) VALUES ('Salary');
INSERT INTO `reasons` (`name`) VALUES ('Coffee');
INSERT INTO `reasons` (`name`) VALUES ('Party');
INSERT INTO `reasons` (`name`) VALUES ('Loan');