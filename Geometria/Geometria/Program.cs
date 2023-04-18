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



rettangoloUser.displayInfoRettangolo();
rettangolo2.displayInfoRettangolo();
rettangolo3.displayInfoRettangolo();
rettangolo4.displayInfoRettangolo();