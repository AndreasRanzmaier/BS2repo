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
describe 		person;
