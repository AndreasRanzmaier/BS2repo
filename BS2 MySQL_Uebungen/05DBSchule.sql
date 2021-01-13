-- DB schule erweitern
-- 30.09.2020
-- 02_dbschule.sgl
use schule;

-- Tabelle erstellen
-- beruf: ber_id int PK, ber_name varchat(50)
create table if not exists beruf (
ber_id int primary key auto_increment,
ber_name varchar(50) not null
);

show tables;

-- beruf und person N:M erstellen 
-- Zwischentabelle person_beruf erstellen(siehe ERM Zeichnung)
create table if not exists person_beruf (
pebe_id int primary key auto_increment,
per_id int not null,
ber_id int not null,
foreign key (per_id) references person(per_id) on update cascade on delete cascade,
foreign key (ber_id) references beruf(ber_id) on update cascade on delete cascade);
show create table person_beruf;

-- b) alle DS der Tabelle person anzeigen
select * from person;
insert into beruf (ber_name) values("schueler"),("Lehrer"),("Direktor");

insert into person_beruf (ber_id, per_id) value (3,1),(1,2)(2,3);
insert into person_beruf (ber_id,per_id) values(4,4);

-- ERROR 1452 (23000): Cannot add or update a child row: a foreign key constraint 
-- fails (`schule`.`person_beruf`, CONSTRAINT `person_beruf_ibfk_1` FOREIGN KEY (`per_id`) 
-- REFERENCES `person` (`per_id`) ON DELETE CASCADE ON UPDATE CASCADE)

-- f) Alle Personen deren NachNamen mit S beginnt
select * from person where per_nname like 'S%';
-- like: überprüft nicht case-sensitiv
--		 % - Joker für eine beliebige Anzahl alphanumerisches Zeichen
--		 _ Joker für ein EINZIGES alphanumerisches Zeichen

-- g) Alle Personen die im NachNamen ein a an zweiter Stelle ein a haben

select * from person where per_nname like 'a%';

-- where-Klausel mit AND und OR
-- h) wie g) und Vorname an letzter Stelle ein r 
select * from person where per_nname like 'a%' and  per_vname like '%r';
select * from person where per_nname like 'a%' or  per_vname like '%r';

-- i) Person deren Nachname ein u oder Vorname ein i enthält
select * from person where per_nname like '%a%' or  per_vname like '%r%';

select * from person order by per_nname;

select * from person order by per_nname ASC;

-- Anmerkung DESC dür absteigende, mehrere Sortierungen duch Beistrich getrennt 
-- k)Person nach Nachnamen (innhalb Vorname) sortieren Vor- und Nachname werden in einer Spalte ausgegeben
-- Alias verwenden
-- PID | Person

select per_id as "PID",
concat_ws(" ",per_vname,per_nname) as "Sortiert" 
from person p
order by p.per_vname ASC, p.per_nname;

select per_vname as "Vorname", per_nname as "Nachname" from Person order by Vorname, Nachname;

select per_vname as "Vorname", per_nname as "Nachname" from Person order by "Das ist ein Vorname";

-- LIMIT 
select *
from person
limit 0, 10;
-- limit: 1 Wert = wo beginnen, 2 Wert wie viele Datensätze

-- DB Schule 16.10.2020
-- update, delete, alter table
use schule;
select * from person;

-- UPDATE
-- a) bestehenden eintarag ändern,
--  die person mit der per_id 3 bekommt den Vornamen Markus
update person set per_vname = 'Markus' where per_id = 3;

-- b)per_id 3 Vornamen auf Martin und Nachname auf Zeus ändern
update person set per_vname = 'Martin', per_nname = 'Zeus'
where per_id = 3;
select * from person;

-- Delete
delete from person_beruf where pebe_id=3;
select * from person_beruf;

-- ALTER TABLE
-- um die Struktur eines Entities oder Attributs zu ändern oder zu löschen
-- z.b. Datentyp eines Attributs ändern, Attribut löschen, Entity umbenennen

-- + ADD
-- b) Der Tabelle Person wird ein Attribut
-- per_nickname varchar(20) not null hinzugefügt
alter table 	person
add				per_nickname varchar(20) not null;
 describe person;
 
 -- c) ein Attribut per_geburt date Anfang hinzufügen
 alter table	person 
 add 			per_geburt date first;
 
 -- d) ein Attribut per_status nach per_nname;
 alter table	person 
 add			per_status int after per_nname;
 describe person;
 
 -- e) FK ber_id int not null zu Tabelle person hinzufügen
 alter table	person add ber_id int not null;
 update person set ber_id=1 where per_id between 1 and 4;
 alter table	person
 add			constraint fk_beruf_berid foreign key(ber_id)
				references beruf(ber_id);

select * from beruf;

show create	table person;

-- MODIFY
-- Attributeeigenschaften ändern
-- f) Person: Datentyp von per_geburt auf datetime ändern
alter table 	person
modify			per_geburt datetime;
describe person;

-- g) PERSON: per_nickname vor per_vname "verschieben"
alter table		person 
modify			per_nickname varchar(20) not null after per_id;
describe person;

-- h) PERSON: per_nickname wird auf optional geändert
alter table 	person
modify 			per_nickname varchar(20);
describe person;

-- i) PERSON: ber_id eine Dafault Wert hinzufügen
-- + ALTER
alter table		person
alter 			ber_id set default 1;
describe person;

-- auto_increment auf einen bestimmten Wert setzen
-- MUSS höher als der zuletzt eingefügte sein 
-- j) PERSON: per_id auto_increment auf 100 setzten 
alter table 	person
				auto_increment = 100;
show create table person;

-- DROP
-- k)  PERSON: per_status löschen
alter table 	person
drop			per_status;
describe person;

-- l) PERSON: die Eigenschaften foreign key von ber_id
alter table 	person
drop			foreign key fk_beruf_berid;

-- CHANGE
-- m) PERSON: per_geburt in per_geb_datum umbenennen
alter table		person change per_geburt per_datum datetime;
describe person;

-- Rename
-- n) Tabelle PERSON in PERSONEN umbenennen
alter table		personen
rename			person;
show tables;

Create table test (tid int);
show tables;
drop table if exists test;
show tables;