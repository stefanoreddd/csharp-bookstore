string nomeLibro = "Le nuove barzellette su Totti";
string author = "Francesco Totti";
string ISBN10 = "8804524820";
string ISBN13 = "978-8804524823";
int pageNumber = 108;
int bookWeigth = 150;
float bookHeigth = 18.5f;
float bookWidth = 11.5f;
float bookDepth = 1.5f;
int bookRating = 5;
int bookValues = 9;
bool kindleCheck = false;
bool flexCheck = true;




Console.WriteLine("------ INFORMAZIONI LIBRO -----");
Console.WriteLine("Titolo: " + nomeLibro);
Console.WriteLine("Autore: " + author);
Console.WriteLine("ISBN-10: " + ISBN10);
Console.WriteLine("ISBN-13: " + ISBN13);
Console.WriteLine("Numero pagine: " + pageNumber);
Console.WriteLine("Peso libro: " + bookWeigth + " g");
Console.WriteLine("Dimensioni: " + bookHeigth + " x " + bookWidth + " x " + bookDepth + " cm ");
Console.WriteLine("Valutazione: " + bookRating + " stelle ");
Console.WriteLine("Numero recensioni: " + bookValues);



if (kindleCheck == true)
{
    Console.WriteLine("Disponibile in versione Kindle: Sì");
}
else
{
    Console.WriteLine("Disponibile in versione Kindle: No");
};



if (flexCheck == true)
{
    Console.WriteLine("Disponibile con copertina flessibile: Sì");
}
else
{
    Console.WriteLine("Disponibile con copertina flessibile: No");
};


Console.WriteLine("-------------------------------");









