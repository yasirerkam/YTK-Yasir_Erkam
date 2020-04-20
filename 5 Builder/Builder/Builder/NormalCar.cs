using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    internal class NormalCar : ICarBuilder
    {
        private Car car = new Car();

        public void BuildAllWheelDrive()
        {
            car.SetAllWheelDrive(AllWheelDrive.NotIncluded);
        }

        public void BuildBlindSpotMonitor()
        {
            car.SetBlindSpotMonitor(BlindSpotMonitor.NotIncluded);
        }

        public void BuildTouchscreen()
        {
            car.SetTouchscreen(Touchscreen.NotIncluded);
        }

        public void BuildWirelessSmartphoneCharger()
        {
            car.SetWirelessSmartphoneCharger(WirelessSmartphoneCharger.NotIncluded);
        }

        public Car GetCar()
        {
            return car;
        }
    }
}