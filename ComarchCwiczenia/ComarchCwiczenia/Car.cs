using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchCwiczenia
{
    internal class Car
    {
        //Zmienne prywatne
        private int stanPaliwa;

        //Zmienne publiczne / pola klasy
        public string Marka;
        public string Model;
        public float Pojemnosc;

        private string hash;

        //Właściwośći (Properties)
        public int LiczbaMiejsc { get; set; }

        //Konstruktor
        public Car()
        {
            hash = this.GetHashCode().ToString();
        }

        //Metoda
        public void Zatankuj(int iloscPaliwa)
        {
            stanPaliwa += iloscPaliwa;
        }
    }
}
