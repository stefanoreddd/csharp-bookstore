using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    // CLASSE
    public class Rettangolo
    {
        // ATTRIBUTI

        public int baseRettangolo;
        public int altezzaRettangolo;


        // COSTRUTTORE
        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        // METODI

        public int calcolaArea()
        {
            int areaRettangolo = baseRettangolo * altezzaRettangolo;
            return areaRettangolo;
        }


        public int calcolaPerimetro()
        {
            int perimetroRettangolo = (baseRettangolo + altezzaRettangolo) * 2;
            return perimetroRettangolo;
        }

    }
}


