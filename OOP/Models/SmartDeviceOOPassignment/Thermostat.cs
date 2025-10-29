using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.SmartDevice
{
   
        public class Thermostat : IDevice
        {
            private bool isOn;
            private int currentTemp;

            public Thermostat()
            {
                isOn = false;
                currentTemp = 22; 
            }

            public void TurnOn()
            {
                isOn = true;
                Console.WriteLine("Thermostat is ON");
            }
            public void TurnOff()
            {
                isOn = false;
                Console.WriteLine("Thermostat is OFF");
            }
            public void ShowStatus()
            {
                Console.WriteLine($"Thermostat status: {(isOn ? "ON" : "OFF")}, Temp: {currentTemp}C");
            }
        }
    }

