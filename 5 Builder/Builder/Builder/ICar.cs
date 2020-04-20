using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    internal enum BlindSpotMonitor
    {
        Included, NotIncluded
    }

    internal enum Touchscreen
    {
        Included, NotIncluded
    }

    internal enum AllWheelDrive
    {
        Included, NotIncluded
    }

    internal enum WirelessSmartphoneCharger
    {
        Included, NotIncluded
    }

    internal interface ICar
    {
        void SetBlindSpotMonitor(BlindSpotMonitor blindSpotMonitor);

        void SetTouchscreen(Touchscreen touchscreen);

        void SetAllWheelDrive(AllWheelDrive allWheelDrive);

        void SetWirelessSmartphoneCharger(WirelessSmartphoneCharger wirelessSmartphoneCharger);
    }
}