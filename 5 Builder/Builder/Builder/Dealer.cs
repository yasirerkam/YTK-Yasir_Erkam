using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    internal class Dealer
    {
        private ICarBuilder carBuilder;

        public Dealer(ICarBuilder carBuilder)
        {
            this.carBuilder = carBuilder;
        }

        public Car GetCar()
        {
            return carBuilder.GetCar();
        }

        public void ProduceCar()
        {
            carBuilder.BuildAllWheelDrive();
            carBuilder.BuildBlindSpotMonitor();
            carBuilder.BuildTouchscreen();
            carBuilder.BuildWirelessSmartphoneCharger();
        }
    }
}