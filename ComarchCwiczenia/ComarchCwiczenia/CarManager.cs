using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchCwiczenia
{
    internal class CarManager
    {

        public void CwiczeniaNaObiektach()
        {
            Car samochod = new Car();
            samochod.Marka = "Audi";
            samochod.Model = "A6 C6";
            samochod.LiczbaMiejsc = 5;
            samochod.Pojemnosc = 3.2f;
            samochod.Zatankuj(40);

            JakasMetoda(samochod);

            Car sam2 = ZmienMarke(samochod);

        }

        private Car ZmienMarke(Car sam)
        {
            Car car = new Car();
            car.Marka = "VW";
            car.Model = sam.Model;
            car.LiczbaMiejsc = sam.LiczbaMiejsc;
            car.Pojemnosc = sam.Pojemnosc;

            return car;
        }

        private void JakasMetoda(Car sam)
        {
            sam.Marka = "VW";
        }
    }
}
