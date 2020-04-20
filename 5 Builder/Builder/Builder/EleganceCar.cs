using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    internal class EleganceCar : ICarBuilder
    {
        private Car car = new Car();

        public void BuildAllWheelDrive()
        {
            car.SetAllWheelDrive(AllWheelDrive.Included);
        }

        public void BuildBlindSpotMonitor()
        {
            car.SetBlindSpotMonitor(BlindSpotMonitor.Included);
        }

        public void BuildTouchscreen()
        {
            car.SetTouchscreen(Touchscreen.Included);
        }

        public void BuildWirelessSmartphoneCharger()
        {
            car.SetWirelessSmartphoneCharger(WirelessSmartphoneCharger.Included);
        }

        public Car GetCar()
        {
            return car;
        }
    }
}