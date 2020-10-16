-- AR 16.10.2020
-- DB Schule 
-- update, delete, alter table 
-- 05DBSchule.sql

use 01einfuehrung_schule;
show tables; 

-- a) 	einen bestehenden Eintrag ändern, 
-- 		Die Person mit der per_id 3 bnekommt den Vornamen Markus 

update person set per_vorname = 'Markus' where per_id = 75;
select * from person;

-- b) per_id 3 Vorname auf Martin und Nachname auf Zeus setzen 
update person set per_vorname = 'Martin', per_nachname = 'Zeus'
where per_id = 77;

-- DELETE
delete from person_has_beruf where pebe_id = 10;
select * from person_has_beruf;

-- ALTER TABLE 
-- um die Struktur eines Entities oder Attributes zu änder oder auch zu löschen 
-- z.B. Datentyp eines Attributes änder, löschen, umbenennen, oder auch sachen wie nn oder ai hinzufügen 

-- + ADD
-- b)	Der Tabelle Person wird ein Attribut
-- 		per_nickname varchar(20) not null hinzugefügt 
alter table 	person
add 			per_nickname varchar(20) not null;
-- fügt per default ein neues Attribut am Ende der Tabelle hinzu 
describe person;

-- c) als erstes Attribut per_geb 
alter table 	person 
add				per_geburt date first;

-- d) ein Attrubut per_status int nach per_name einfügen
alter table 	person 
add 			per_status int after per_nachname;

-- e) einen FK bei ber_int int not null zu Tabell person hinzufügen 
alter table 	person add ber_id int not null;
update 			person set ber_id = 1 where per_id between 75 and 78;
alter table 	person 
add				constraint fk_beruf_berid foreign key(ber_id)
				references beruf(ber_id);
 
select * from person;
show create table person;
/*'person', 'CREATE TABLE `person` 
(\n  `per_geburt` date DEFAULT NULL,\n  
`per_id` int NOT NULL AUTO_INCREMENT,\n 
 `per_vorname` varchar(45) DEFAULT NULL,\n
 `per_nachname` varchar(45) NOT NULL,\n  
 `per_status` tinyint(1) DEFAULT \'1\',\n 
 `per_nickname` varchar(20) NOT NULL,\n  
 `ber_id` int NOT NULL,\n  PRIMARY KEY (`per_id`),\n 
 KEY `fk_beruf_berid` (`ber_id`),\n 
 CONSTRAINT `fk_beruf_berid` FOREIGN KEY (`ber_id`) REFERENCES `beruf` (`ber_id`)\n)
 ENGINE=InnoDB AUTO_INCREMENT=79 DEFAULT CHARSET=utf8'
*/

-- man könnte auch einen Primary key hinzufügen 

-- Modify Attributeigenschaften ändern 
-- f) person datentyp von per_geburt auf Datetime ändern
alter table 	person 
modify 			per_geburt datetime;

-- g) person: per_nickname vor per_vorname "verschieben"
alter table 	person 
modify 			per_nickname varchar(20) not null after per_id; -- man muss immer einen Datentypen mitgeben 

-- h) person: per_nickname nn wird auf optional geändert wenn nicht explizit angegeben
alter table 	person
modify 			per_nickname varchar(20);

-- i) person: ber_id einen Default Wert hinzufügen 
-- + ALTER
alter table	 	person
alter 			ber_id set default 1;

-- auto_increment auf einen bestimmten Wert setzen 
-- MUSS höher sein als der zuletzt eingefügt wert sein 
-- j) person: per_id auto_increment auf 100 setzen 
alter table 	person 
				auto_increment = 100;

-- DROP 
-- k) person: per_status löschen 
alter table 	person 
drop			per_status;

-- l) person: die Eigenschaft FK von ber_id entfernen 
-- alter table 	person
alter table 	person 
drop 			foreign key fk_beruf_berid;

-- change für table oä
-- m) PERSONEN: per_geburt in per_geb_datum umbenennen 
alter table		person 
change 			per_geburt per_geb_datum datetime;

-- rename für entity 
-- RENAME
-- n) Tabel person in personen umbenennen 
alter table 	person 
rename 			personen;

show tables;

-- und wieder zurückbenennen
alter table 	personen 
rename 			person;

describe 		person;