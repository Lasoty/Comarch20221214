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
            //Referencje();

            //Dziedziczenie();

            Interfejsy();
        }

        private void Interfejsy()
        {
            Bus bus = new Bus();
            MetodaCoChceInterfejs(bus);
        }

        void MetodaCoChceInterfejs(IVehicle vehicle)
        {
            vehicle.TestMetodaZInterfejsu("Test");
            vehicle.Marka = "Test";
        }

        #region Dziedziczenie i polimorfizm

        private void Dziedziczenie()
        {
            Car car = new Car();
            car.Pojemnosc = 2;
            car.Marka = "Car";

            Bus bus = new Bus();
            bus.IloscOsi = 4;
            bus.Marka = "Bus";

            car.ShowFullInfo();
            bus.ShowFullInfo();

            Car car1 = new Bus()
            {
                IloscOsi = 3,
                Marka = "Bus in Car",
            };


            car1.ShowFullInfo();

            Bus bus1 = (Bus)car1;

            TestForVehicle(car);
            TestForVehicle(bus);
            TestForVehicle(car1);

            VehicleBase baseV = new Car();
        }

        public void TestForVehicle(VehicleBase vehicle)
        {
            vehicle.ShowFullInfo();
        }
        
        #endregion

        #region Referencje


        private void Referencje()
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

        #endregion
    }
}
