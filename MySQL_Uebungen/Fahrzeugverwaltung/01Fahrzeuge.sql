-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema fahrzeugverwaltung
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `fahrzeugverwaltung` ;

-- -----------------------------------------------------
-- Schema fahrzeugverwaltung
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `fahrzeugverwaltung` ;
USE `fahrzeugverwaltung` ;

-- -----------------------------------------------------
-- Table `fahrzeugverwaltung`.`HERSTELLER`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `fahrzeugverwaltung`.`HERSTELLER` (
  `her_id` INT NOT NULL,
  `her_marke` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`her_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `fahrzeugverwaltung`.`H_TYPE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `fahrzeugverwaltung`.`H_TYPE` (
  `hty_id` INT NOT NULL,
  `her_id` INT NOT NULL,
  `hty_type` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`hty_id`),
  INDEX `fk_H_TYPE_HERSTELLER` (`her_id` ASC),
  CONSTRAINT `fk_H_TYPE_HERSTELLER`
    FOREIGN KEY (`her_id`)
    REFERENCES `fahrzeugverwaltung`.`HERSTELLER` (`her_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `fahrzeugverwaltung`.`KENNZEICHEN`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `fahrzeugverwaltung`.`KENNZEICHEN` (
  `ken_id` INT NOT NULL AUTO_INCREMENT,
  `ken_nr` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ken_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `fahrzeugverwaltung`.`ZULASSUNG`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `fahrzeugverwaltung`.`ZULASSUNG` (
  `zul_id` INT NOT NULL,
  `hty_id` INT NOT NULL,
  `ken_id` INT NOT NULL,
  `zul_motornr` VARCHAR(45) NOT NULL,
  `zul_fahrgestellnr` VARCHAR(45) NOT NULL,
  `zul_aktiv` TINYINT NOT NULL DEFAULT 1,
  PRIMARY KEY (`zul_id`),
  INDEX `fk_ZULASSUNG_H_TYPE1` (`hty_id` ASC),
  INDEX `fk_ZULASSUNG_KENNZEICHEN1` (`ken_id` ASC),
  CONSTRAINT `fk_ZULASSUNG_H_TYPE1`
    FOREIGN KEY (`hty_id`)
    REFERENCES `fahrzeugverwaltung`.`H_TYPE` (`hty_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ZULASSUNG_KENNZEICHEN1`
    FOREIGN KEY (`ken_id`)
    REFERENCES `fahrzeugverwaltung`.`KENNZEICHEN` (`ken_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `fahrzeugverwaltung`.`HERSTELLER`
-- -----------------------------------------------------
START TRANSACTION;
USE `fahrzeugverwaltung`;
INSERT INTO `fahrzeugverwaltung`.`HERSTELLER` (`her_id`, `her_marke`) VALUES (27, 'Renault');
INSERT INTO `fahrzeugverwaltung`.`HERSTELLER` (`her_id`, `her_marke`) VALUES (28, 'Fiat');
INSERT INTO `fahrzeugverwaltung`.`HERSTELLER` (`her_id`, `her_marke`) VALUES (29, 'Mercedes');
INSERT INTO `fahrzeugverwaltung`.`HERSTELLER` (`her_id`, `her_marke`) VALUES (30, 'BMW');
INSERT INTO `fahrzeugverwaltung`.`HERSTELLER` (`her_id`, `her_marke`) VALUES (31, 'Peugeot');
INSERT INTO `fahrzeugverwaltung`.`HERSTELLER` (`her_id`, `her_marke`) VALUES (32, 'Jaguar');

COMMIT;


-- -----------------------------------------------------
-- Data for table `fahrzeugverwaltung`.`H_TYPE`
-- -----------------------------------------------------
START TRANSACTION;
USE `fahrzeugverwaltung`;
INSERT INTO `fahrzeugverwaltung`.`H_TYPE` (`hty_id`, `her_id`, `hty_type`) VALUES (99, 27, '19');
INSERT INTO `fahrzeugverwaltung`.`H_TYPE` (`hty_id`, `her_id`, `hty_type`) VALUES (100, 28, 'Punto');
INSERT INTO `fahrzeugverwaltung`.`H_TYPE` (`hty_id`, `her_id`, `hty_type`) VALUES (101, 29, '500');
INSERT INTO `fahrzeugverwaltung`.`H_TYPE` (`hty_id`, `her_id`, `hty_type`) VALUES (102, 30, '700');

COMMIT;


-- -----------------------------------------------------
-- Data for table `fahrzeugverwaltung`.`KENNZEICHEN`
-- -----------------------------------------------------
START TRANSACTION;
USE `fahrzeugverwaltung`;
INSERT INTO `fahrzeugverwaltung`.`KENNZEICHEN` (`ken_id`, `ken_nr`) VALUES (1, 'L-2BNCJ');
INSERT INTO `fahrzeugverwaltung`.`KENNZEICHEN` (`ken_id`, `ken_nr`) VALUES (2, 'L-BDJEK');
INSERT INTO `fahrzeugverwaltung`.`KENNZEICHEN` (`ken_id`, `ken_nr`) VALUES (3, 'UU-55GZ');
INSERT INTO `fahrzeugverwaltung`.`KENNZEICHEN` (`ken_id`, `ken_nr`) VALUES (4, 'GM-IDZS');
INSERT INTO `fahrzeugverwaltung`.`KENNZEICHEN` (`ken_id`, `ken_nr`) VALUES (NULL, 'L-2BNCK');

COMMIT;


-- -----------------------------------------------------
-- Data for table `fahrzeugverwaltung`.`ZULASSUNG`
-- -----------------------------------------------------
START TRANSACTION;
USE `fahrzeugverwaltung`;
INSERT INTO `fahrzeugverwaltung`.`ZULASSUNG` (`zul_id`, `hty_id`, `ken_id`, `zul_motornr`, `zul_fahrgestellnr`, `zul_aktiv`) VALUES (2, 100, 1, 'DUEJMNED5', 'DKEID3KE', 0);
INSERT INTO `fahrzeugverwaltung`.`ZULASSUNG` (`zul_id`, `hty_id`, `ken_id`, `zul_motornr`, `zul_fahrgestellnr`, `zul_aktiv`) VALUES (3, 100, 2, 'KDIEN7789D', 'DCKEJ6DN', 0);
INSERT INTO `fahrzeugverwaltung`.`ZULASSUNG` (`zul_id`, `hty_id`, `ken_id`, `zul_motornr`, `zul_fahrgestellnr`, `zul_aktiv`) VALUES (4, 102, 3, '88DDDFJEDD', 'LDKEKDN5', 1);
INSERT INTO `fahrzeugverwaltung`.`ZULASSUNG` (`zul_id`, `hty_id`, `ken_id`, `zul_motornr`, `zul_fahrgestellnr`, `zul_aktiv`) VALUES (5, 100, 4, 'D8DFJDKDUE', 'KLEJDNE5', 1);

COMMIT;

