-- DB Schule Joins 
use 01einfuehrung_schule;

-- alle Tabellen anzeigen 
show tables;

-- Cross Join
-- Inner Joins 
-- finden "vernüpfte" Datensätze 
-- erfolgt über den PK und FK
-- a) Alle Personen ausgeben + ber_id (JOIN)
select * 
from person, person_has_beruf;

/*+--------+-------------+--------------+------------+---------+--------+--------+
| per_id | per_vorname | per_nachname | per_status | pebe_id | per_id | ber_id |
+--------+-------------+--------------+------------+---------+--------+--------+
|     75 | Oliver      | Bauer        |       NULL |      10 |     75 |      3 |
|     75 | Oliver      | Bauer        |       NULL |      11 |     76 |      1 |
|     75 | Oliver      | Bauer        |       NULL |      12 |     77 |      2 |
|     76 | Hannes      | Huspek       |       NULL |      10 |     75 |      3 |
|     76 | Hannes      | Huspek       |       NULL |      11 |     76 |      1 |
|     76 | Hannes      | Huspek       |       NULL |      12 |     77 |      2 |
|     77 | Jakob       | Schmidt      |       NULL |      10 |     75 |      3 |
|     77 | Jakob       | Schmidt      |       NULL |      11 |     76 |      1 |
|     77 | Jakob       | Schmidt      |       NULL |      12 |     77 |      2 |
|     78 | Martha      | Huber        |       NULL |      10 |     75 |      3 |
|     78 | Martha      | Huber        |       NULL |      11 |     76 |      1 |
|     78 | Martha      | Huber        |       NULL |      12 |     77 |      2 |
+--------+-------------+--------------+------------+---------+--------+--------+
12 rows in set (0.00 sec)*/

-- b) korr. a)
select person.*, person_has_beruf.ber_id
from person, person_has_beruf;

/*+--------+-------------+--------------+------------+--------+
| per_id | per_vorname | per_nachname | per_status | ber_id |
+--------+-------------+--------------+------------+--------+
|     75 | Oliver      | Bauer        |       NULL |      1 |
|     75 | Oliver      | Bauer        |       NULL |      2 |
|     75 | Oliver      | Bauer        |       NULL |      3 |
|     76 | Hannes      | Huspek       |       NULL |      1 |
|     76 | Hannes      | Huspek       |       NULL |      2 |
|     76 | Hannes      | Huspek       |       NULL |      3 |
|     77 | Jakob       | Schmidt      |       NULL |      1 |
|     77 | Jakob       | Schmidt      |       NULL |      2 |
|     77 | Jakob       | Schmidt      |       NULL |      3 |
|     78 | Martha      | Huber        |       NULL |      1 |
|     78 | Martha      | Huber        |       NULL |      2 |
|     78 | Martha      | Huber        |       NULL |      3 |
+--------+-------------+--------------+------------+--------+*/

-- c) wie b) mit tabellenalias 
select p.*, pb.per_id 
from person as p, person_has_beruf pb;

-- d) wie c) mit atribut alias 
select	p.per_vorname as "Vorname",
		p.per_nachname as "Nachname",
		pb.ber_id as "BerufsID"
from 	person as p, person_has_beruf as pb;

-- Equi-Join 
-- mit where Klasusel
-- e) wie d) aber nur "verknüpfte" Datensätze
select	p.per_vorname as "Vorname", 
  		p.per_nachname as "Nachname", 
		pb.ber_id as "BerufsID"
from 	person as p, person_has_beruf as pb
where 	p.per_id = pb.per_id; 

-- f) alle Personen + Berufsbezeichnungen
-- Person | Beruf  ... person mit vor und nach-nahemen 
select	concat_ws(" ", per_vorname, per_nachname) as "Person",
		b.ber_id as "Beruf"
from 	person as p, beruf as b, person_has_beruf as pb
where	p.per_id = pb.per_id
and 	b.ber_id = pb.ber_id;


-- INNER JOIN 
-- g) wie a) aber nur verknüpfte Datensätze 
-- using kann verwendet werden, wenn PK und FK die gleiche Bezeiehung habenb
select 	p.*, ber_id 
from 	person as p INNER JOIN person_has_beruf as pb using(per_id); 

-- alternativ falls PK und FK nicht die gleiche Bezeichnung haben 
select 	p.*, ber_id 
from 	person as p 
INNER JOIN person_has_beruf as pb 
		on p.per_id = pb.per_id;
		
-- h) wie f) 

select 	concat_ws (" ", per_vorname, per_nachname) as "Person",
		b.ber_name as "Beruf"
from	person as p INNER JOIN person_has_beruf as pb
		on p.per_id = pb.per_id 
		inner join beruf b using(ber_id);

-- i) wie h) aber nicht mit using sondern nur mit on 
		
select 	concat_ws (" ", per_vorname, per_nachname) as "Person",
		b.ber_name as "Beruf"
from	person as p INNER JOIN person_has_beruf as pb
		on p.per_id = pb.per_id 
		inner join beruf b
		on p.per_id = pb.per_id;

-- alternative for 3 Tables
select 	concat_ws(" ", per_vorname, per_nachname) as "Person",
		b.ber_name as "Beruf"
from 	person_has_beruf inner join (person, beruf b) using(per_id, ber_id);


-- natural join 
-- wie h) 
select 	concat_ws (" ", per_vorname, per_nachname) as "Person",
		b.ber_name as "Beruf"
from	person as p Natural JOIN person_has_beruf as pb
		Natural join beruf b; 
		
/*
NATURAL JOIN: 	vergleichen ALLE "gleichnamigen atribute"
				ALLER angegebenen Tabellen 
*/










