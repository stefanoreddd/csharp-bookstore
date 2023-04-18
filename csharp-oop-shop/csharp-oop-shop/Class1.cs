using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
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

        private int prezzo;
        public int PrezzoProdotto { get { return this.prezzo; } set { this.prezzo = value; } }

    }


    // STATI

    


}
