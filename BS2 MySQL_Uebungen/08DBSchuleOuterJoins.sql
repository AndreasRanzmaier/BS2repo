-- AR, 22.10.2020
-- db schule 
-- outer joins 
show databases;
use schule;

/* left (outer) join 
 outer join liefern alle DS as Beziehungstabelle
 auch jene die noch nicht "zugeordnet" wurde, z.B.
 aus Tabelle Beruf, jene Berufe, die noch keiner 
 Person zugeordnet wurden
 */
 
 -- a) alle Berufe und (falls vorhanden auch die dazugehörigen) Personen ID's ausgeben
 -- zuerst die Tabelle von der ich alles will
 select b.*, pb.per_id 
 from 	beruf as b left outer join person_has_beruf pb 
 using 	(ber_id);
 
 insert into beruf values(null, "Schulwart");
 
 -- b) wie a) aber nur berufe die noch niemandem zugeordnet worden sind
select		b.*, pb.per_id 
from 		beruf as b left outer join person_has_beruf as pb 
using	    (ber_id) 
where 		pb.ber_id is null;

-- c) wie a) mit right outer join 
select b.*, pb.per_id 
from person_has_beruf as pb right outer join beruf as b using(ber_id);

-- d) wie a) aber folgende Spalten/Attribute
-- Berufsbez. und den Vor- und Nachnamen der zugeordneten Personen Falls vorhanden Person | Beruf 
select 	concat_ws('', per_vorname, per_nachname) as "Person",
		ber_name as "Beruf"
-- alle Berufe, über die Tabelle unter der Key verbindung personen suchen
from 	beruf 	left outer join person_has_beruf 	using(ber_id)
				left outer join person 				using(per_id);
                
-- alternative 
select 	concat_ws('', per_vorname, per_nachname) as "Person",
		ber_name as "Beruf"
from person_has_beruf pb right outer join beruf b on pb.ber_id = b.ber_id
						 left outer join  person p on pb.per_id = p.per_id;


select * from person_has_beruf;

                