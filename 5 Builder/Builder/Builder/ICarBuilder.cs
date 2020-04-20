using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    internal interface ICarBuilder
    {
        void BuildBlindSpotMonitor();

        void BuildTouchscreen();

        void BuildAllWheelDrive();

        void BuildWirelessSmartphoneCharger();

        Car GetCar();
    }
}