-- Andreas Ranzmaier 30.09
-- MySQL


show databases;

-- DB ERSTELLEN 
-- NUR IN DER SCHULE ZUERST DB LÖSCHEN 
drop databases if exists 01einfuehrung_schule;

create database 01einfuehrung_schule;

-- Tabelle Person erstellen 
-- Schema auswählen;
use 01einfuehrung_schule;

-- tabellen anzeigen
create table person(per_id int primary key auto_increment,
per_vorname varchar(50), per_nachname varchar(50) not null);

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
s
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

-- datensatz attribute einfügen
insert into person values 	(null, "Oliver", "Bauer"),
							(null, "Hannes", "Huspek"),
							(null, "Jakob", "Schmidt"),
							(null, "Martha", "Huber");
-- Query: Abfrage auf Tabellen einfaches select Statement 
select * 
from person;

/*
mysql> select *
    -> from person;
+--------+-------------+--------------+
| per_id | per_vorname | per_nachname |
+--------+-------------+--------------+
|      1 | Jakob       | Schultz      |
|      2 | Marstus     | Lsa9sf        |
|      3 | Oliver      | Bauer        |
|     10 | Hannes      | Huspek       |
+--------+-------------+--------------+
4 rows in set (0.00 sec)
*/

show create table person;

-- Anzahl der DS in person ausgeben 
select count(*)
from person;

-- Alias für Attribute
select count(*) as "Anzahl Personen"
from person;

-- Attribute explizit für select auswählen:
select per_vorname as "vor", per_nachname as "nach"
from person;

/*
+---------+---------+
| vor     | nach    |
+---------+---------+
| Jakob   | Schultz |
| Marstus | Lsasf   |
| Oliver  | Bauer   |
| Hannes  | Huspek  |
+---------+---------+
*/

-- Tabellen Name bei Attributen auch davor schreiben
select person.per_vorname 
from person;

-- Alias für Tabelle in einer einzelnene Tabelle eigentlich nicht nötig Tabelle.Name
select p.per_vorname
from person p;

-- Übung:
-- a) Funktion concat mehrere Atribute in einer Spalte ausgeben
		-- also Vor + Nachname 
select 
	concat(per_vorname, " ", per_nachname)
from person; 

-- Übung 
-- b) mit spalten und Tabellen Alias 

select 
	concat(p.per_vorname, " ", p.per_nachname) as "TabellenName"	
from person p;

-- c) wie a mit concat_ws (zuerst trennzeichen dann atribute)
select  
	concat_ws(" ", per_id, per_vorname, per_nachname) as "something"
from person;

-- d) Augabe: geben sie in einer Spalte alle drei Attribute von person aus 
-- 		      per_nname per_vname per_id 

select 
	concat(per_nachname , " " , per_vorname , " - " , per_id ) as "Tabellen Name"
from person;

select
	concat_ws(" - ", concat_ws(" ", per_nachname, per_vorname), per_id) as "name"
from person;

-- 









