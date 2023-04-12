Console.Write("Qual è il titolo del libro?");
string bookName = Console.ReadLine();


Console.Write("Qual è l'autore?");
string author = Console.ReadLine();


Console.Write("Qual è il suo ISBN-10?");
string ISBN10 = Console.ReadLine();


Console.Write("Qual è il suo ISBN-13?");
string ISBN13 = Console.ReadLine();


Console.Write("Qual è il numero delle pagine del libro?");
string pageNumberString = Console.ReadLine();
int pageNumber = int.Parse(pageNumberString);


Console.Write("Qual è il peso del libro?");
string bookWeigthString = Console.ReadLine();
int bookWeigth = int.Parse(bookWeigthString);


Console.Write("Qual è l'altezza del libro?");
string bookHeigthString = Console.ReadLine();
float bookHeigth = float.Parse(bookHeigthString);


Console.Write("Qual è la larghezza del libro?");
string bookWidthString = Console.ReadLine();
float bookWidth = float.Parse(bookWidthString);


Console.Write("Qual è la profondità del libro?");
string bookDepthString = Console.ReadLine();
float bookDepth = float.Parse(bookDepthString);


Console.Write("Qual è la valutazione media del libro?");
string bookRatingString = Console.ReadLine();
int bookRating = int.Parse(bookRatingString);


Console.Write("Qual è il numero delle recensioni?");
string bookValuesString = Console.ReadLine();
int bookValues = int.Parse(bookValuesString);


Console.Write("Il libro è disponibile in versione Kindle?");
string kindleCheck = Console.ReadLine();


Console.Write("Il libro è disponibile con copertina flessibile?");
string flexCheck = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");




Console.WriteLine("------ INFORMAZIONI LIBRO -----");
Console.WriteLine("Titolo: " + bookName);
Console.WriteLine("Autore: " + author);
Console.WriteLine("ISBN-10: " + ISBN10);
Console.WriteLine("ISBN-13: " + ISBN13);
Console.WriteLine("Numero pagine: " + pageNumber);
Console.WriteLine("Peso libro: " + bookWeigth + " g");
Console.WriteLine("Dimensioni: " + bookHeigth + " x " + bookWidth + " x " + bookDepth + " cm ");
Console.WriteLine("Valutazione: " + bookRating + " stelle ");
Console.WriteLine("Numero recensioni: " + bookValues);
Console.WriteLine("Disponibile in versione Kindle: " + kindleCheck);
Console.WriteLine("Disponibile con copertina flessibile: " + flexCheck);
Console.WriteLine("-------------------------------");






