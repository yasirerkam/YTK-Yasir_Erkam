using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    internal class Car : ICar
    {
        private AllWheelDrive allWheelDrive;
        private BlindSpotMonitor blindSpotMonitor;
        private Touchscreen touchscreen;
        private WirelessSmartphoneCharger wirelessSmartphoneCharger;

        public void SetAllWheelDrive(AllWheelDrive allWheelDrive)
        {
            this.allWheelDrive = allWheelDrive;
        }

        public void SetBlindSpotMonitor(BlindSpotMonitor blindSpotMonitor)
        {
            this.blindSpotMonitor = blindSpotMonitor;
        }

        public void SetTouchscreen(Touchscreen touchscreen)
        {
            this.touchscreen = touchscreen;
        }

        public void SetWirelessSmartphoneCharger(WirelessSmartphoneCharger wirelessSmartphoneCharger)
        {
            this.wirelessSmartphoneCharger = wirelessSmartphoneCharger;
        }
    }
}