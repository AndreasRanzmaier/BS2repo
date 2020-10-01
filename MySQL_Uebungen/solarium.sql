-- AR 01.10.2020
-- Solarium DB

-- use shema
use 03UebungSolarium;

-- join Sonnenbank Inventur und Modellname
select 	son_InvNum as "Sonnenbank",
		mod_Name as "Modell"
from 	modelle natural join sonnenbanken;

/*
	natural join vergleicht von allen unter from 
	angegebenen Tabellen, ALLE Attribute mit gleichem 
	Namen! (in unserem fall die ID's)
*/

