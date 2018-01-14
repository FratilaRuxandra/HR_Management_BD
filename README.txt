

APLICATIE SOFTWARE DE GESTIUNE A ANGAJATILOR INTR-O FIRMA

REALIZAT DE:
AVRAM RARES
ENOIU DORIN
FRATILA RUXANDRA


PREZENTARE GENERALA:
Dorind o abordare cat mai rapida,usoara si de actualitate, am folosit pentru 
implementarea aplicatiei Entity Framework.
In proiect,pe langa interogarile de manipulare si afisare date,au fost incluse 
proceduri stocate,tranzactii si view-uri. 

Conceptul de baza de la care s-a pornit a fost faptul ca firma in discutie 
este o unitate militara,a carei organizare sa se asemene cu cea a beneficiarilor 
Academiei ( SRI,STS,MAI etc).Prin urmare,pentru formarea profilului angajatului 
am luat in considerare aspecte precum gradul militar, informatii despre rudele
acestuia,salariul format din mai multe solde etc.

FOLOSIREA APLICATIEI:

Aplicatia poate fi accesata de 3 tipuri de utilizatori:
1. angajatii de la departamentul de resurse umane
 ( default :username "hr" parola "hr" ) 
Acestia au posibilitatea sa adauge ,modifice,vizualizeze date despre angajati
2. adminul 
(username "admin" parola "admin")
Acesta poate modifica structura departamentelor,functiilor si proiectelor precum 
si parolele pentru fiecare tip de utilizator
3. useri normal 
( username "guest" parola "guest")
Acestia pot doar vizualiza informatii despre angajati 
 
Astfel, desi functionalitatea de login nu este dezvoltata decat pentru aceste 
trei nivele,se evita posibilitatea persoanelor neautorizate de a modifica 
informatii sensibile(precum salariul).

	PRECIZARI:
	-formularul de adaugare angajat nou trebuie completat in totalitate.
	(inclusiv incarcare cv,completare fisa medicala si informatii pentru cel
	 putin o ruda )
	-in modul admin se selecteaza intai tabela ce se doreste modificata
	(departamente/functii/proiecte) si apoi actiunea propriu-zisa
	(adaugare/modificare/stergere)
        -modificarile salariale au o sectiune dedicata, nu sunt incluse in sectiunea
        "Modificari Angajat"
        -un angajat nu va fi sters,ci trecut in rezerva 
        -sectiunea de informatii contine informatii generale,specifice fiecarui 
        angajat si functionalitatea de exportare rapoarte in format pdf,excel,csv. 


