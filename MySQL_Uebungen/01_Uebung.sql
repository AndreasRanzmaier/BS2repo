-- Andreas Ranzmaier 30.09
-- MySQL


show databases;

-- Schema auswählen;
use 01einfuehrung_schule;

-- tabellen anzeigen
show tables;

/*
mysql> source C:\GIT_repo\AndreasRanzmaier\BS_repo\MySQL_Uebungen\01_Uebung.sql
+----------------------+
| Database             |
+----------------------+
| 01einfuehrung_schule |
| 01einführung_schule  |
| information_schema   |
| mysql                |
| performance_schema   |
| sys                  |
+----------------------+
6 rows in set (0.00 sec)

Database changed
+--------------------------------+
| Tables_in_01einfuehrung_schule |
+--------------------------------+
| person                         |
+--------------------------------+
1 row in set (0.00 sec)

*/

-- create Table Befehl anzeigen 
show create table person;

/*
+--------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Table  | Create Table                                                                                                                                                                                                                    |
+--------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| person | CREATE TABLE `person` (
  `per_id` int NOT NULL AUTO_INCREMENT,
  `per_vorname` varchar(45) DEFAULT NULL,
  `per_nachname` varchar(45) NOT NULL,
  PRIMARY KEY (`per_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 |
+--------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
1 row in set (0.00 sec)
*/

-- tabellen struktur ausgeben 
describe person;