/*
 * Consegna:
Nel progetto csharp-geometria seguite i seguenti passi:

1. Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo.
Aggiungere un opportuno costruttore con parametri.
Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.

2. Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori di base e di altezza con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato, stampate a video il perimetro e l’area del rettangolo che avete costruito.

3. Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo cambiati) e provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:

 —— Rettangolo ——
base: 20 cm
altezza: 10 cm
Perimetro: 60 cm
Area: 200 cm2


BONUS:

Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni, ossia tanti “—” (due trattini) orizzontali quanto è grande la sua base e tanti ‘|’ verticali quanto e grande la sua altezza.
*/

using Geometria;
using Microsoft.VisualBasic;

Console.WriteLine("Inserisci la base del rettangolo");
string baseRettangoloString = Console.ReadLine();
int baseRettangolo = int.Parse(baseRettangoloString);

Console.WriteLine("Inserisci l'altezza del rettangolo");
string altezzaRettangoloString = Console.ReadLine();
int altezzaRettangolo = int.Parse(altezzaRettangoloString);

Rettangolo rettangoloUser = new Rettangolo(baseRettangolo, altezzaRettangolo);

Rettangolo rettangolo2 = new Rettangolo(20, 10);

Rettangolo rettangolo3 = new Rettangolo(30, 20);

Rettangolo rettangolo4 = new Rettangolo(40, 30);

rettangoloUser.calcolaPerimetro();
rettangoloUser.calcolaArea();

rettangolo2.calcolaPerimetro();
rettangolo2.calcolaArea();

rettangolo3.calcolaPerimetro();
rettangolo3.calcolaArea();

rettangolo4.calcolaPerimetro();
rettangolo4.calcolaArea();


Console.WriteLine("----- INFORMAZIONI RETTANGOLO UTENTE -----");
Console.WriteLine("Base: " + rettangoloUser.baseRettangolo + " cm");
Console.WriteLine("Altezza: " + rettangoloUser.altezzaRettangolo + " cm");
Console.WriteLine("Perimetro: " + rettangoloUser.calcolaPerimetro() + " cm");
Console.WriteLine("Area: " + rettangoloUser.calcolaArea() + " cm²");
Console.WriteLine("------------------------------------------");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("----- INFORMAZIONI RETTANGOLO 2 -----");
Console.WriteLine("Base: " + rettangolo2.baseRettangolo + " cm");
Console.WriteLine("Altezza: " + rettangolo2.altezzaRettangolo + " cm");
Console.WriteLine("Perimetro: " + rettangolo2.calcolaPerimetro() + " cm");
Console.WriteLine("Area: " + rettangolo2.calcolaArea() + " cm²");
Console.WriteLine("-------------------------------------");
Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("----- INFORMAZIONI RETTANGOLO 3 -----");
Console.WriteLine("Base: " + rettangolo3.baseRettangolo + " cm");
Console.WriteLine("Altezza: " + rettangolo3.altezzaRettangolo + " cm");
Console.WriteLine("Perimetro: " + rettangolo3.calcolaPerimetro() + " cm");
Console.WriteLine("Area: " + rettangolo3.calcolaArea() + " cm²");
Console.WriteLine("-------------------------------------");
Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("----- INFORMAZIONI RETTANGOLO 4 -----");
Console.WriteLine("Base: " + rettangolo4.baseRettangolo + " cm");
Console.WriteLine("Altezza: " + rettangolo4.altezzaRettangolo + " cm");
Console.WriteLine("Perimetro: " + rettangolo4.calcolaPerimetro() + " cm");
Console.WriteLine("Area: " + rettangolo4.calcolaArea() + " cm²");
Console.WriteLine("-------------------------------------");
Console.WriteLine("");
Console.WriteLine("");










