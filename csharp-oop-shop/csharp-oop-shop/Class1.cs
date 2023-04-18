using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Prodotto
    {

        // PROPRIETA'

        private int codice;
        public int CodiceProdotto { get { return this.codice; } }

        private string nome;
        public string NomeProdotto { get { return this.nome; } set { this.nome = value; } }

        private string descrizione;
        public string DescrizioneProdotto { get { return this.descrizione; } set { this.descrizione = value; } }

        private int iva;
        public int IvaProdotto { get { return this.iva; } set { this.iva = value; } }

        private double prezzo;
        public double PrezzoProdotto { get { return this.prezzo; } set { this.prezzo = value; } }

        private double prezzoIva;
        public double PrezzoProdottoConIva { get { return this.prezzoIva; } }



        // COSTRUTTORE

        public Prodotto(int codice, string nome, string descrizione, int iva, double prezzo)
        {
            this.codice = codice;

            this.nome = nome;
            this.descrizione = descrizione;
            this.iva = iva;
            this.prezzo = prezzo;

        }

        // GETTERS

        public int GetCodiceProdotto()
        {
            return this.codice;
        }

        public string GetNomeProdotto()
        {
            return this.nome;
        }

        public string GetDescrizioneProdotto()
        {
            return this.descrizione;
        }

        public int GetIvaProdotto()
        {
            return this.iva;
        }

        public double GetPrezzoProdotto()
        {
            return (double)this.prezzo;
        }




        // SETTERS

        public string SetNomeProdotto()
        {
            return this.nome;
        }

        public string SetDescrizioneProdotto()
        {
            return this.descrizione;
        }

        public int SetIvaProdotto()
        {
            return this.iva;
        }

        public double SetPrezzoProdotto()
        {
            return (double)this.prezzo;
        }



        // METODI

        public int GeneraCodice()
        {
            Random rnd = new Random(8);
            int num = rnd.Next();
            codice = num;
            Console.WriteLine("Codice Prodotto: " + codice);
            return codice;
        }


        public double PrezzoConIva()
        {
            double prezzoIva = prezzo * 1.22;
            return prezzoIva;
        }

        public void NomeEsteso()
        {
            Console.WriteLine("Nome Esteso: " + this.codice + ", " + this.nome);
        }

    }
}
