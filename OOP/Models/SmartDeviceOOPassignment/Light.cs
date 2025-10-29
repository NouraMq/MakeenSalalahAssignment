using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.SmartDevice
{

    public class Light : IDevice
    {
        private bool isOn;           // هل الضوء يعمل؟
        private int brightness;      // مستوى الإضاءة

        public Light()
        {
            isOn = false;
            brightness = 0;
        }

        public void TurnOn()
        {
            isOn = true;
            brightness = 100;
            Console.WriteLine("Light is ON, Brightness 100%");
        }
        public void TurnOff()
        {
            isOn = false;
            brightness = 0;
            Console.WriteLine("Light is OFF");
        }
        public void ShowStatus()
        {
            Console.WriteLine($"Light status: {(isOn ? "ON" : "OFF")}, Brightness: {brightness}%");
        }
    }
}