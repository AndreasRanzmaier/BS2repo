-- a) Alle Datenbanken anzeigen  
show databases;

-- b) DB business löschen falls es noch nicht existiert 
drop database if exists business;

-- c) Datenbank Business anlegen
create database business;

-- d) verwenden
use business;

-- e) erstellen 
create table if not exists PRODUCER (
pro_id int primary key auto_increment,
pro_name varchar(45) not null
);

create table if not exists ARTICLE (
art_id int primary key auto_increment,
art_name varchar(45) not null ,
art_price double not null 
);

create table if not exists ARTICLE_PRODUCER (
pro_id int not null,
art_id int not null,
foreign key (pro_id) references PRODUCER(pro_id) on update cascade on delete cascade,
foreign key (art_id) references ARTICLE(art_id) on update cascade on delete cascade
);

-- f) anzeigen
show  tables;


-- g) mit Datensaetzen befüllen 
insert into PRODUCER 			(pro_id, pro_name)
values 							(1, 'Cloudy'),(2, 'Huber'),(3, 'Freud GmbH');

insert into ARTICLE 			(art_id, art_name, art_price)
values							(1,'HB40', 100), (2, 'XY10', 250.99), (3,'ABC' , 141.29), (4,'UMD56' ,99.99);

insert into ARTICLE_PRODUCER 	(art_id, pro_id)
values 							(1, 3),(2, 3),(3, 3),(4, 2);

-- h) ausgabe aller ds in PRODUCER 
select * from PRODUCER;

-- i) ausgabe der Tabellenstruktur von PRODUCER 
describe PRODUCER;

-- j) 	Geben sie von der Tabelle ARTICLE_PRODUCER, die Bezeichnungen der CONSTRAINTS
-- 		aus (show create table)
show create table PRODUCER;

-- k) alle Producer aufsteigend nach Bezeichnung sortieren
select pro_name as pro_name_Sorted
from PRODUCER
order by pro_name_Sorted ASC;

-- l-n) Artikel + Herstellerbez. 
-- 		soritiert nach 	Herstellerbez. 	DESC
-- 						Artikelbez 		ASC
-- l) mit INNER JOIN 
select 	p.pro_name, art_name 
from 	Producer as p 
-- die verbindung in n:m xy_has_xy vestlegen
INNER JOIN ARTICLE_PRODUCER as ap 
		on p.pro_id = ap.pro_id
--  andere Seite
INNER JOIN ARTICLE as a 
		on ap.art_id = a.art_id
order by p.pro_name desc, a.art_name asc;

-- m) natural join 
select a.*, p.pro_name
from article a natural join ARTICLE_PRODUCER natural join producer p 
order by p.pro_name desc, art_name asc;

-- andere 
select a.*, p.pro_name
from ARTICLE_PRODUCER natural join (ARTICLE a, PRODUCER p)
order by p.pro_name desc, art_name asc;

-- n) Equi Join auch Tabellenalias verwenden 
select a.*, p.pro_name
from ARTICLE a, ARTICLE_PRODUCER ap, PRODUCER p
where a.art_id = ap.art_id
and p.pro_id = ap.pro_id
order by p.pro_name desc, art_name asc;

        
-- o) Herstellerbez. Artbesch. und Preis ausgeben Alisas für Attribute 
-- Hersteller | Artikel | Preis 
select 	p.pro_name as "Producer", art_name as "Artikel", art_price as "Preis"
from 	Producer as p 
INNER JOIN ARTICLE_PRODUCER as ap 
		on p.pro_id = ap.pro_id
INNER JOIN ARTICLE as a 
		on ap.art_id = a.art_id;
	

-- p) wie o) aber nur der 3. DS
select 	p.pro_name as "Producer", art_name as "Artikel", art_price as "Preis"
from 	Producer as p 
INNER JOIN ARTICLE_PRODUCER as ap 
		on p.pro_id = ap.pro_id
INNER JOIN ARTICLE as a 
		on ap.art_id = a.art_id
order by a.art_name limit 2,1;
        
        
        
        
        
        
        
        
