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
        private int annoDiImmatricolazione;
        private string colore;
        private string marca;
        private string modello;
        private float prezzo;
        private int capienzaMaxSerbatoio;

        // STATI
        private bool accesa;
        private int litriBenzinaNelSerbatoio;
        private string tipoDiBenzinaContenuta;

        // COSTRUTTORE
        public Auto(string marca, string modello, int capienzaDelSerbatoio, string colore = "ignoto", int annoDiImmatricolazione = 0, int litriDiBenzinaInizale = 1, float prezzo = 0f)
        {
            this.marca = marca;
            this.modello = modello;
            this.colore = colore;
            this.prezzo = prezzo;
            this.annoDiImmatricolazione = annoDiImmatricolazione;
            SetLitriMaxSerbatoioBenzina(capienzaDelSerbatoio);

            this.accesa = false;
            this.litriBenzinaNelSerbatoio = litriDiBenzinaInizale;
        }

        public Auto(string marca, string modello, string colore, int capienzaDelSerbatoio, int litriDiBenzinaInizale)
        {
            this.marca = marca;
            this.modello = modello;
            this.colore = colore;
            SetLitriMaxSerbatoioBenzina(capienzaDelSerbatoio);

            this.accesa = false;
            this.litriBenzinaNelSerbatoio = litriDiBenzinaInizale;
        }


        public Auto(string marca, string modello, string colore, float prezzo, int annoDiImmatricolazione, int capienzaDelSerbatoio, int litriDiBenzinaInizale)
        {
            this.marca = marca;
            this.modello = modello;
            this.colore = colore;
            this.prezzo = prezzo;
            this.annoDiImmatricolazione = annoDiImmatricolazione;
            SetLitriMaxSerbatoioBenzina(capienzaDelSerbatoio);

            this.accesa = false;
            this.litriBenzinaNelSerbatoio = litriDiBenzinaInizale;
        }


        // GETTERS
        public int GetLitriNelSerbatoio()
        {
            return this.litriBenzinaNelSerbatoio;
        }

        public string GetColore()
        {
            return this.colore;
        }

        public bool GetAccesa()
        {
            return this.accesa;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public string GetModello()
        {
            return this.modello;
        }

        // SETTERS

        public void SetLitriMaxSerbatoioBenzina(int maxCapienza)
        {
            if (maxCapienza > 150 )
            {
                this.capienzaMaxSerbatoio = 150;
                
            } else if(maxCapienza < 0)
            {
                this.capienzaMaxSerbatoio = 0;
            } else {
                this.capienzaMaxSerbatoio = maxCapienza;
            }
        }

        public void SetColore(string colore)
        {
            this.colore = colore;
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

        public float DammiPrezzoScontato(int sconto)
        {
            float prezzoScontato = (float)sconto * prezzo;
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
            }
            else
            {
                Console.WriteLine("Mi dispiace hai raggiunto la capienza massima");
                litriBenzinaNelSerbatoio = capienzaMaxSerbatoio;
            }

            this.tipoDiBenzinaContenuta = "normale";
        }


        public void FaiLitriBenzina(int litri, string tipoDiBenzina)
        {
            if (litriBenzinaNelSerbatoio + litri <= capienzaMaxSerbatoio)
            {
                litriBenzinaNelSerbatoio += litri;
            } else
            {
                Console.WriteLine("Mi dispiace hai raggiunto la capienza massima");
                litriBenzinaNelSerbatoio = capienzaMaxSerbatoio;
            }

            this.tipoDiBenzinaContenuta = tipoDiBenzina;
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
