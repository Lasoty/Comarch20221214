using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchCwiczenia
{
    internal class Car : VehicleBase
    {
        //Zmienne prywatne
        private int stanPaliwa;


        public float Pojemnosc;

        private string hash;

        //Właściwośći (Properties)
        public int LiczbaMiejsc { get; set; }

        //Konstruktor
        public Car()
        {
            hash = this.GetHashCode().ToString();
            ShowInfo();
        }

        //Metoda
        public void Zatankuj(int iloscPaliwa)
        {
            stanPaliwa += iloscPaliwa;
        }

        public override void ShowFullInfo()
        {
            Console.WriteLine($"{Marka} {Model} {Pojemnosc}");
        }
    }

    class Bus : Car
    {
        public int IloscOsi { get; set; }

        public override void ShowFullInfo()
        {
            Console.WriteLine($"{Marka} {Model} {IloscOsi}");
        }

        public void TestBus()
        {

        }
    }

    abstract class VehicleBase : IVehicle
    {

        public string Marka { get; set; }
        
        private string model;
        public string Model
        {
            get
            {
                Console.WriteLine("Pobieranie Model: " + model);
                return model;
            }
            set
            {
                Console.WriteLine("Zapisanie Model: " + value);
                model = value;
            }
        }

        //Zmienne publiczne / pola klasy


        protected void ShowInfo()
        {
            Console.WriteLine($"{Marka} {Model}");
        }

        public abstract void ShowFullInfo();

        public void TestMetodaZInterfejsu(string testText)
        {
            Console.WriteLine("Test metoda z interfejsu.");
        }
    }

    interface IVehicle
    {
        string Marka { get; set; }
        string Model { get; set; }

        void TestMetodaZInterfejsu(string testText);
    }
}
