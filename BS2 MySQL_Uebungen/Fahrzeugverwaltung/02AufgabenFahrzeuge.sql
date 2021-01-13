use fahrzeugverwaltung;

-- 1)
select count(zul_id) as "Anzahl Zulassungen"
from zulassung; 

-- 2) a)
select 	h.her_marke, z.zul_motornr, z.zul_aktiv
from 	zulassung z, hersteller h, h_type ht
-- equi die pk und fk händisch verknüpfen 
where 	z.hty_id = ht.hty_id
and 	h.her_id = ht.her_id
and 	z.zul_aktiv = 1; 

-- 2) b)
select 		h.her_marke, z.zul_motornr, z.zul_aktiv
from 		hersteller as h 
inner join 	h_type as ht 
on			h.her_id = ht.her_id 
inner join 	zulassung as z 
on 			ht.hty_id = z.hty_id 
where 		zul_aktiv = 1; 

-- 3) 
select 	her_id, her_marke
from 	hersteller as h
left outer join h_type as ht using(her_id)
where ht.hty_type is null;

-- 4)
select 	her_marke as "Hersteller"
from 	hersteller as h
left join h_type as ht using(her_id)
left join zulassung as z using(hty_id)
where z.zul_id is null;

-- 5) 
describe h_type;

-- 6) 
show create table zulassung;

-- 7)
select 	h.her_marke as "Marke", ht.hty_type as "Type",  z.zul_motornr as "Motornummer", 
		z.zul_fahrgestellnr as "Fahrgestellnummer", k.ken_nr as "Kennzeichen"
from 	hersteller as h natural join h_type as ht natural join zulassung as z natural join kennzeichen as k
where 	z.zul_aktiv = 1;

-- 8)
select 	k.ken_id, k.ken_nr, z.zul_id, ht.hty_id, z.zul_motornr, z.zul_fahrgestellnr, z.zul_aktiv
from  	h_type as ht natural join zulassung as z natural join kennzeichen as k
where 	k.ken_nr like 'L%';

-- 9)
select 		h.her_marke as "Marke", ht.hty_type as "Type",  z.zul_motornr as "Motornummer", 
			z.zul_fahrgestellnr as "Fahrgestellnummer", k.ken_nr as "Kennzeichen"
from 		hersteller as h natural join 
			h_type as ht natural join 
			zulassung as z natural join 
			kennzeichen as k
order by 	h.her_marke asc, k.ken_nr asc;

-- 10)
select 	concat_ws(" -> ", k.ken_id, k.ken_nr) as "ID -> Kennzeichen (nicht zugelassen)"
from 	zulassung as z right outer join kennzeichen as k using(ken_id) 
where 	z.zul_id is null;

-- where 	z.zul_id is null

-- 11) 
update zulassung set zul_fahrgestellnr = "KKDJE1KD" where zul_id = 2;

select  * from zulassung;
