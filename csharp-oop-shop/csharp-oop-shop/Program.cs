using Shop;

Prodotto prodottoUser = new Prodotto(0, "Prodotto 1", "Prodotto dello Shop predefinito 1", 22, 58);

Console.WriteLine("----- INFORMAZIONI PRODOTTO -----");
prodottoUser.GeneraCodice();
Console.WriteLine("Nome Prodotto: " + prodottoUser.GetNomeProdotto());
prodottoUser.NomeEsteso();
Console.WriteLine("Descrizione: " + prodottoUser.GetDescrizioneProdotto());
Console.WriteLine("Prezzo: " + prodottoUser.GetPrezzoProdotto() + " euro");
Console.WriteLine("Iva: " + prodottoUser.GetIvaProdotto() + "%");
Console.WriteLine("Prezzo (con IVA): " + prodottoUser.PrezzoConIva() + " euro");
Console.WriteLine("---------------------------------");