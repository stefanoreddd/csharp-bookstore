using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LeMieAuto
{
    public class Auto
    {
        // ATTRIBUTI / CARATTESTICHE
        public int annoDiImmatricolazione;
        public string colore;
        public string marca;
        public string modello;
        public float prezzo;
        public int capienzaMaxSerbatoio;

        // STATI
        public bool accesa;
        public int litriBenzinaNelSerbatoio;

        // COSTRUTTORE
        public Auto(string marca, string modello, string colore, float prezzo, int annoDiImmatricolazione, int capienzaDelSerbatoio, int litriDiBenzinaInizale)
        {
            this.marca = marca;
            this.modello = modello;
            this.colore = colore;
            this.prezzo = prezzo;
            this.annoDiImmatricolazione = annoDiImmatricolazione;
            this.capienzaMaxSerbatoio = capienzaDelSerbatoio;

            this.accesa = false;
            this.litriBenzinaNelSerbatoio = litriDiBenzinaInizale;
        }

        // METODI
        public void Accenditi()
        {
            accesa = true;
            Console.WriteLine("WROOMMM!");
        }

        public void Spegniti()
        {
            accesa = false;
            Console.WriteLine("----- zzzzzz ----");
        }

        public void VerniciaAuto(string colore)
        {
            this.colore = colore;
        }

        public float DammiPrezzoScontato20()
        {
            float prezzoScontato = 0.8f * prezzo;
            return prezzoScontato;
        }

        public void FaiIlPieno()
        {
            litriBenzinaNelSerbatoio = capienzaMaxSerbatoio;
        }


        public void FaiLitriBenzina(int litri)
        {
            if (litriBenzinaNelSerbatoio + litri <= capienzaMaxSerbatoio)
            {
                litriBenzinaNelSerbatoio += litri;
            } else
            {
                Console.WriteLine("Mi dispiace hai raggiunto la capienza massima");
                litriBenzinaNelSerbatoio = capienzaMaxSerbatoio;
            }
        }
        /* 
        // Questo metodo non serve che usi il "this" perchè non c'è ambiguità tra 
        // il nome del parametro richiesto e il nome dell'attributo a cui ci si vuole riferire
        
        public void verniciaAuto(string coloreVerniciatura)
        {
            colore = coloreVerniciatura;
        }

        */

    }
}
