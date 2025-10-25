using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.IDevice
{

    class Light : IDevice
    {
        private bool isOn;
        private int brightness;
        // Constructor to initialize default state
        public Light()
        {
            isOn = false;
            brightness = 0; // Default brightness
        }
        // Methods to implement IDevice interface
        public void TurnOn()
        {
            isOn = true;
            brightness = 100; // Set brightness to maximum when turned on
        }
        // Method to turn off the light bulb
        public void TurnOff()
        {
            isOn = false;
            brightness = 0; // Set brightness to zero when turned off
        }
        // Method to show the current status of the light bulb
        public void ShowStatus()
        {
            Console.WriteLine($"LightBulb is currently {(isOn ? "ON" : "OFF")} ,Brightness: {brightness}%.");
        }
    }
