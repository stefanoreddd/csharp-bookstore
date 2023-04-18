// See https://aka.ms/new-console-template for more information
using LeMieAuto;

Console.WriteLine("Hello, World!");

Auto autoDiBryan = new Auto("Audi", "A3", "nera", 20000f, 2018, 50, 3);
Console.WriteLine("L'auto di Bryan è: " + autoDiBryan.GetAccesa());

autoDiBryan.Accenditi();

Auto autoDiJordan = new Auto("BMW", "Serie 3", "blu", 25000f, 2020, 60, 5);

Console.WriteLine("L'auto di Bryan è: " + autoDiBryan.GetAccesa());
Console.WriteLine("L'auto di Jordan è: " + autoDiJordan.GetAccesa());

Console.WriteLine("Il prezzo scontato del 20% dell'auto di Jordan è: " + autoDiJordan.DammiPrezzoScontato(20));


Console.WriteLine("I litri di benzina contenuti prima del pieno erano: " + autoDiBryan.GetLitriNelSerbatoio() + " litri");
autoDiBryan.FaiIlPieno();
Console.WriteLine("I litri di benzina contenuti dopo il pieno sono: " + autoDiBryan.GetLitriNelSerbatoio() + " litri");

autoDiJordan.FaiLitriBenzina(10);
Console.WriteLine("L'auto di Jordan dopo 10 litri di benzina riempiti, ora ha: " + autoDiBryan.GetLitriNelSerbatoio() + " litri");

autoDiBryan.SetColore("gialla");

Console.WriteLine("L'auto di Bryan è di colore: " + autoDiBryan.GetColore());

Auto autoDiAlessio = new Auto("Mercedes", "Classe C", "rossa", 60, 10);

Auto autoDiGabriele = new Auto("Opel", "Meriva", 50);
autoDiGabriele.FaiLitriBenzina(10, "premium");


autoDiBryan.SetLitriMaxSerbatoioBenzina(100);
Console.WriteLine("La marca dell'auto di Bryan è: " + autoDiBryan.GetMarca());
Auto autoDiGiovanni = new Auto("Citroen", "DS3", "nero", 10000000, 10);



AutoProperties autoDiDavud = new AutoProperties("Ferrari", "250 GTO", 100);
Console.WriteLine("Di che marca è l'auto di Davud? " + autoDiDavud.Marca);



