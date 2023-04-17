/*
Create un programma che chieda come input all’utente 3 numeri da 1 a 10.
Usate il metodo Next dell’oggetto Random per estrarre un numero casuale da 1 a 10.
A questo punto comunicate all’utente se il numero casualmente estratto compare tra uno dei 3 numeri inseriti dall’utente.
In caso affermativo comunicare l’utente che ha vinto la lotteria, in caso negativo comunicategli che ha perso.

BONUS:

Ripetere questo gioco finché l’utente non vince contro il PC.
*/


Random randomGenerator = new Random();
int randomNumber = (randomGenerator.Next(10)) + 1;


int[] userNumbers = new int[3];

for (int i = 0; i < userNumbers.Length; i++)
{
    Console.WriteLine("Inserisci il " + (i + 1) + "° numero da 1 a 10");
    int userNumber = int.Parse(Console.ReadLine());

    while (userNumber < 1 || userNumber > 10)
    {
        Console.WriteLine("Inserisci un numero valido");
        userNumber = int.Parse(Console.ReadLine());
    }

    userNumbers[i] = userNumber;
}



for (int i = 0; i < 1; i++)
{
    if (randomNumber == userNumbers[i])
    {
        Console.WriteLine("");
        Console.WriteLine("Il numero generato dal computer è: " + randomNumber);
        Console.WriteLine("Congratulazioni, hai vinto!");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Il numero generato dal computer è: " + randomNumber);
        Console.WriteLine("Mi spiace, hai perso!");
    }
}


