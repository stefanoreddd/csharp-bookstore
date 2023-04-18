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

        public void displayInfoRettangolo()
        {
            Console.WriteLine("----- INFORMAZIONI RETTANGOLO -----");
            Console.WriteLine("Base: " + baseRettangolo + " cm");
            Console.WriteLine("Altezza: " + altezzaRettangolo + " cm");
            Console.WriteLine("Perimetro: " + calcolaPerimetro() + " cm");
            Console.WriteLine("Area: " + calcolaArea() + " cm²");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
            drawRettangolo();
            Console.WriteLine("");
        }

        public void drawRettangolo()
        {
            string orizzontale = "--";
            string verticale = "|";

            

            for (int i = 0; i < baseRettangolo - 1; i++)
            {
                Console.Write(orizzontale);
            }

            Console.WriteLine(orizzontale);

            for (int i = 0; i < altezzaRettangolo; i++)
            {
                Console.Write(verticale);
                
                for (int j = 0; j < baseRettangolo - 1; j++)
                {
                    Console.Write("  ");
                }

                Console.WriteLine(verticale);
            }

            

            for (int i = 0; i < baseRettangolo - 1; i++)
            {
                Console.Write(orizzontale);
            }

            Console.WriteLine(orizzontale);
        }
    }
}


