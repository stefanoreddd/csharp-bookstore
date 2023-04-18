using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMieAuto
{
    public class AutoProperties
    {

        // ATTRIBUTI con PROPERTIES

        private int annoDiImmatricolazione;
        public int AnnoDiImmatricolazione { get { return this.annoDiImmatricolazione; } }

        private string colore;
        public string Colore { get { return this.colore; } set { this.colore = value; } }

        private string marca;
        public string Marca { get { return this.colore; } }

        private string modello;
        public string Modello { get { return this.modello; } }

        private float prezzo;
        public float Prezzo { get { return this.prezzo; } set { this.prezzo = value; } }

        private int capienzaMaxSerbatoio;
        public int CapienzaMaxSerbatoio
        {
            get
            {
                return this.capienzaMaxSerbatoio;
            }
            set
            {
                if (value > 150)
                {
                    this.capienzaMaxSerbatoio = 150;

                }
                else if (value < 0)
                {
                    this.capienzaMaxSerbatoio = 0;
                }
                else
                {
                    this.capienzaMaxSerbatoio = value;
                }
            }
        }

        // STATI
        private bool accesa;
        public bool Accesa { get { return this.accesa; } }

        private int litriBenzinaNelSerbatoio;
        public int LitriBenzinaNelSerbatoio { get { return this.litriBenzinaNelSerbatoio;  } }

        private string tipoDiBenzinaContenuta;
        public string TipoDiBenzinaContenuta { get { return this.tipoDiBenzinaContenuta; } }


        // COSTRUTTORE
        public AutoProperties(string marca, string modello, int capienzaDelSerbatoio, string colore = "ignoto", int annoDiImmatricolazione = 0, int litriDiBenzinaInizale = 1, float prezzo = 0f)
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




        public void Accenditi()
        {
            this.accesa = true;
            Console.WriteLine("WROOMMM!");
        }

        public void Spegniti()
        {
            this.accesa = false;
            Console.WriteLine("----- zzzzzz ----");
        }

        public float DammiPrezzoScontato(int sconto)
        {
            float prezzoScontato = (float)sconto * Prezzo;
            return prezzoScontato;
        }

        public void FaiIlPieno()
        {
            this.litriBenzinaNelSerbatoio = capienzaMaxSerbatoio;
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
            }
            else
            {
                Console.WriteLine("Mi dispiace hai raggiunto la capienza massima");
                litriBenzinaNelSerbatoio = capienzaMaxSerbatoio;
            }

            this.tipoDiBenzinaContenuta = tipoDiBenzina;
        }



    }
}
