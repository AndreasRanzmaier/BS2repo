show databases;
use 03uebungsolarium;

-- 1. Alle Sonnenbänke austeigend sortiert angeben
select * 
from sonnenbanken 
order by son_InvNum;

-- 2. Alle Sonnenänke inkl. Modellbezeichnungen aufsteigend sortiert asugeben
select *
from sonnenbanken, modelle
order by mod_name;

-- 3. Alle Persoen mit einem a im nachnamen 
select * 
from kunde
where kun_nname like '%a%';

-- 4. Alle Personen die entweder ein a oder ein e im Vornamen haben 
select * 
from kunde 
where kun_vname like '%a%' 
or kun_vname like '%e%';

-- 5. Alle Sonnenbänke inkl. Modellbezeichnung + Raumnamen in dem sie stehen 
-- mod_name + kab_raum_bez
-- lösng ohne Raumname 
select 	son_InvNum as "Sonnenbank",
		mod_Name as "Modell",
        max(kaso_start) as "Datum" 
from 	sonnenbanken s 
		inner join kabinen_sonnenbanken using(son_InvNum)
		inner join kabinen using(kab_id) 
        inner join modelle using(mod_id)
group by Sonnenbank;

select 	son_inventurnummer as "Sonnenbank",
		mod_Name as "Modell",
        max(lag_datum)
from 	sonnenbanken s inner join lager on s.son_InvNum = lager.son_inventurnummer
		inner join modelle using(mod_id)
group by Sonnenbank;

-- zum überprüfen neuer insert
insert into lager values(null, 12,'2020-02-02');

select * from sonnenbanken; 

-- 6. wie 5 inkl. Preis für die Benutzung 
-- insert into preisebenutzung values(null, 1, '2020-02-02', 2.2);

select 	son_InvNum as "Sonnenbank",
		mod_Name as "Modell",
        Pre_preis as "Kosten"
from 	sonnenbanken natural join modelle natural join preisebenutzung 
where 	Pre_gueltig is null;

select * from preisebenutzung;

/*
NATURAL JOIN:
*/
