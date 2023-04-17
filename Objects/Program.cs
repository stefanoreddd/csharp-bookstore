// See https://aka.ms/new-console-template for more information
using LeMieAuto;

Console.WriteLine("Hello, World!");

Auto autoDiBryan = new Auto("Audi", "A3", "nera", 20000f, 2018, 50, 3);
Console.WriteLine("L'auto di Bryan è: " + autoDiBryan.accesa);

autoDiBryan.Accenditi();

Auto autoDiJordan = new Auto("BMW", "Serie 3", "blu", 25000f, 2020, 60, 5);

Console.WriteLine("L'auto di Bryan è: " + autoDiBryan.accesa);
Console.WriteLine("L'auto di Jordan è: " + autoDiJordan.accesa);

Console.WriteLine("Il prezzo scontato del 20% dell'auto di Jordan è: " + autoDiJordan.DammiPrezzoScontato20());


Console.WriteLine("I litri di benzina contenuti prima del pieno erano: " + autoDiBryan.litriBenzinaNelSerbatoio + " litri");
autoDiBryan.FaiIlPieno();
Console.WriteLine("I litri di benzina contenuti dopo il pieno sono: " + autoDiBryan.litriBenzinaNelSerbatoio + " litri");

autoDiJordan.FaiLitriBenzina(10);
Console.WriteLine("L'auto di Jordan dopo 10 litri di benzina riempiti, ora ha: " + autoDiJordan.litriBenzinaNelSerbatoio + " litri");

// DEFINISCO LA MIA AUTO
