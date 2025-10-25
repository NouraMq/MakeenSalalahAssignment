using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.IDevice
{
    internal class Controller
    {
        public void OperatelDevice(IDevice device)
        {
            // Use the IDevice methods to operate the device
            device.TurnOn();
            device.ShowStatus();
            device.TurnOff();
            device.ShowStatus();
        }
}
