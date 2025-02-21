WorksSHOP 02/10/25
------------------------------

Bankuppgift
1.	Skapa properties för användare (ApplicationUser)
		- kan ha flera konton
2.	skapa klass för Konto (ny klass)
		- kan ha flera transaktioner
		- tillhör en användare
3.	skapa klass för transaktioner (ny klass)
		- tillhör ett konto
4.	skapa DbSet i DbContext
5.	migrera och uppdatera DB
6.	skapa en profilsida för användaren (det finns boilerplate, modifiera den)
		- använd bootstrap
7a.  skapa en admin-sida (behörighet till admins)
		-ska visa lista av användare
7b.  skapa funktion att ta bort/lägga till roller för användare