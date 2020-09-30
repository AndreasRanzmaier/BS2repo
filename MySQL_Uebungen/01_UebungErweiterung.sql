-- DB schule Erweitern 
-- 30.09.2020 Ranzmaier Andreas 

use 01einfuehrung_schule;

-- Tabelle erstellen 
-- beruf: ber_id id PK, ber_name varchar(50)

create table if not exists beruf (
	ber_id int primary key auto_increment,
	ber_name varchar(50) not null
);

-- Alle Tabellen anzeigen:
	show tables;
