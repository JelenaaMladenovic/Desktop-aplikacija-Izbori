# Izbori - Projekat iz Sistema baza podataka

- Zadatak:

Za potrebe jedne političke strane potrebno je projektovati bazu podataka koja će voditi evidenciju o svim 
podacima neophodnim za vođenje kampanje na predsedničkim izborima. Za potrebe kampanje angažovan 
je veliki broj aktivista stranke. Za svakog učesnika u kampanji pamti se jedinstveni identifikator, ime, ime 
roditelja, prezime, datum rođenja, adresa, brojevi telefona za kontakt i e-mail adrese koje se mogu koristiti 
za kontakt. Neki od učesnika u kampanji su postavljeni na funkciju koordinatora za pojedine opštine. Za 
svakog opštinskog koordinatora se pamti ime opštine za koju je zadužen, adresa njegove privremene 
kancelarije i podaci o četiri njegova pomoćnika koji zajedno sa njim koordiniraju izborne aktivnosti na 
teritoriji opštine. Za potrebe kampanje zakupljuje se i reklamni prostor. Za svaku reklamu pamti se iznos 
koji je plaćen i vremenski period reklamiranja.  Ukoliko se radi o reklamnim panoima pamti se grad i naziv 
ulice u kojoj se reklamni pano nalazi, površina reklamnog pano i naziv agencije koja je vlasnik panoa. 
Ukoliko je reklamni prostor zakupljen u novinama ili časopisu vodi se evidencija o nazivu lista i o tome da 
li je oglas u koloru ili crno beli.  Za radio i tv reklame se pamti trajanje reklame u sekundama, naziv TV i 
radio stanica na kojima se ta reklama emituje kao i ukupan broj emitovanja za svaku TV ili radio stanicu. 
Pored reklama za potrebe kampanja se organizuje i veliki broj akcija. Za svaku akciju se pamti naziv akcije 
i informacije o aktivistima koji učestvuju u toj akciji. Ukoliko se radi o akciji deljenja letaka pamti se grad u 
kome se akcija odvija kao i nazivi lokacija na kojima se leci dele. Ukoliko se organizuju susreti kandidata sa 
građanima vodi se evidencija o planiranom vremenu tog susreta, gradu i lokaciji gde se susret organizuje. 
Ukoliko se radi o političkom mitingu pamti se mesto gde se miting organizuje, lokacija, podacima o gostima 
na mitingu (ime, prezime, titula ili funkcija koju gost obavlja) a ukoliko je miting u zatvorenom prostoru 
naziv firme ili instituciji od koje se prostor iznajmljuje kao i cena iznajmljivanja. U bazi se čuvaju informacije 
o svim pojavljivanjima predsedničkog kandidata u medijima. Ukoliko se radi o intervjuima u novinama i 
časopisima pamti se naziv lista, datum kada je intervju napravljen i datum kada je intervju objavljen kao i 
imena novinara koji su intervju napravili. Za gostovanja u radio i TV emisijama pamti se naziv TV ili radio 
stanice, naziv emisije u kojoj kandidat gostuje, ime voditelja i podatak o procenjenoj gledanosti emisije. 
Ukoliko se radi o TV duelu pamte se i imena protivkandidata kao i spisak unapred pripremljenih pitanja 
ukoliko postoje. Za potrebe praćenja samih izobra potrebno je voditi evidenciju o svim glasačkim mestima. 
Za svako glasačko mesto pamti se naziv izborne jedinice i broj glasačkog mesta, broj registrovanih birača, 
informacijama o aktivistima koji su ispred stranke angažovani za praćenje izbora na tom glasačkom mestu 
i primedbe koje su oni eventualno uložili na tok glasanja. Pamte se i rezultati izbora (za 1. i eventualni 2. 
krug): broj birača koji su izašli na izbore i procenat birača koji su glasali za kandidata stranke. 

-  Na osnovu specificiranih zahteva projektovati bazu podataka:
    1. EER model baze podataka 
    2. Relacioni model baze podataka 
    3. SQL naredbe za kreiranje tabela i pratećih ograničenja  
    4. SQL naredbe za punjenje tabela sample podacima

- Na osnovu projektovane baze podataka, kreirana je desktop aplikacija koja za pristup podacima koristi komponentu baziranu na korišćenju NHibernate ORM biblioteke.

- Kreirati Web API aplikaciju (korišćenjem C# programskog jezika) koja demonstrira korišćenje NHibernate komponente za pristup podacima koja je projektovana u prethodnom delu. Neophodno je da aplikacija poseduje Web API kontrolere čije metode omogućavaju pribavljanje, dodavanje, ažuriranje i brisanje svih tipova domenskih entiteta.