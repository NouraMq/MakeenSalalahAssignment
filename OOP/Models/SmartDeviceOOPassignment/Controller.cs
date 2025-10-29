using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.SmartDevice
{
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void ShowStatus();
    }

    internal class Controller
    {

        public void OperateDevice(IDevice device)
        {
            device.TurnOn();
            device.ShowStatus();
            device.TurnOff();
            device.ShowStatus();
        }
    
}
}
