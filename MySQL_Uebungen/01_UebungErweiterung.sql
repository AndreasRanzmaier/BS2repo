-- DB schule Erweitern 
-- 30.09.2020 Ranzmaier Andreas 

-- use nicht vergessen das porogramm weis sonst nicht welche db gemeint ist 

use 01einfuehrung_schule;

-- Tabelle erstellen 
-- beruf: ber_id id PK, ber_name varchar(50)

create table if not exists beruf (
    ber_id int primary key auto_increment,
    ber_name varchar(50) not null
);

-- Alle Tabellen anzeigen:
show tables;

-- beruf und person N:M Beziehung 
-- Zwischentabelle person_has_beruf erstellen (siehe ERM Zeichnung)

create table if not exists person_has_beruf(
    pebe_id int primary key auto_increment,
    per_id int not null, 
    ber_id int not null,
    -- besonderes foreign key attribut dem system lassen machen 
    foreign key (per_id) references person(per_id) 
        on update cascade on delete cascade,
    foreign key (ber_id) references beruf(ber_id)	
        on update cascade on delete cascade
    
);

 
-- falls man löschen will muss man seinen namen kennen und so kann man 
-- nachsehen
show create table beruf;

-- b) alle DS der Tabelle Person anzeigen 
select * 
from person;

-- Inserts in die Person einfügen 
-- c) DS in beruf und person_has_beruf einfügen 
-- c.1) die Attribute explizit angeben
insert into beruf(ber_name) values ("Schueler"), ("Lehrer"), ("Direktor");

-- d) wie c) Attribute in belibiger Reihenfolge angeben 
insert into person_has_beruf(ber_id, per_id) value (3,1), (1,2), (2,3);

-- hier dann die referenzielle integrität überprüfen 

-- e) Alle Personen deren Nachname mit 'b' beginnt 
-- Where Klausel 
-- 
select * 
from person 
where per_nachname like 'B%';

-- like: nicht case sensitive 
-- % Joker für eine belibige Anzahl  alphanumeischer Zeichen
-- _ Joker für ein einzelnes Zeichen 

/*
mysql> select *
    -> from person
    -> where per_nachname like 'B%';
+--------+-------------+--------------+------------+
| per_id | per_vorname | per_nachname | per_status |
+--------+-------------+--------------+------------+
|     75 | Oliver      | Bauer        |       NULL |
|     77 | Oliver      | Bauer        |       NULL |
+--------+-------------+--------------+------------+
*/

-- f) alle personen mit nachnamen an zweiter stell a  
select * 
from person 
where per_nachname like '_a%';

-- g) wie f) und vorname an letzer stelle 'k'
-- where Klausen mit and und or
-- Huspek and Bauer 

select * 
from person 
where per_nachname like '_u%'
and per_vorname like '%k';

-- h) Personen deren Nachnamen ein u oder Vornamen ein i enthalten

select * 
from person 
where per_nachname like '%u%'
or per_vorname like '%i%';

-- ORDER BY 
-- j) Personen aufsteigend sortiert nach Nachnameausgeben 
select * 
from person 
order by per_nachname;

-- oder aufsteigend explizit angeben 
select *
from person 
order by per_nachname ASC;

-- Anmerkung: DESC  = descending(absteigend) ASC: ascending(aufstegend)
-- mit beistrich getrennt
-- k) Aufgabe Personen nach Vornamen austeigend
-- 	  und Nachnamenn (innerhalb Vornamen) sortieren 
--    Vor und Nachname werden in einer Spalte ausgegeben

select *
from 		person 
order by 	per_vorname ASC, per_nachname;

select 		per_id as "PID", 
            concat_ws(" ", per_vorname, per_nachname) as "Person"
from 		person p
order by 	p.per_vorname ASC, p.per_nachname DESC;
 
 
 -- ------ 
 
select	 	per_vorname as "Vorname", 
            per_nachname as "Nachname"
from 		person 
order by 	Vorname, Nachname;
 
select 	per_nachname as "Das ist ein Nachname"
from 		person 
order by 	per_nachname;

-- LIMIT 
select *
from 		person 
limit 		0,3;
-- limit: 1Wert = wo beginnen, 2Wert = wo aufhören


