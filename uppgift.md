WorksSHOP 02/10/25
------------------------------

Bankuppgift
1.	Skapa properties f�r anv�ndare (ApplicationUser)
		- kan ha flera konton
2.	skapa klass f�r Konto (ny klass)
		- kan ha flera transaktioner
		- tillh�r en anv�ndare
3.	skapa klass f�r transaktioner (ny klass)
		- tillh�r ett konto
4.	skapa DbSet i DbContext
5.	migrera och uppdatera DB
6.	skapa en profilsida f�r anv�ndaren (det finns boilerplate, modifiera den)
		- anv�nd bootstrap
7a.  skapa en admin-sida (beh�righet till admins)
		-ska visa lista av anv�ndare
7b.  skapa funktion att ta bort/l�gga till roller f�r anv�ndare