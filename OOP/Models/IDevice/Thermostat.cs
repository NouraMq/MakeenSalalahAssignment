using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.OOP.Models.IDevice
{
    class Thermostat : IDevice
    {
        // Fields to represent the state of the Thermostat
        private bool isOn;
    private double currentTemperature;
    public Thermostat()
    {
      
        isOn = false;
        currentTemperature = 22.0; 
    }
 
    public void TurnOn()
    {
        // Set the thermostat to on state
        isOn = true;
        currentTemperature = 24.0; // Set to default temperature when turned on
    }
    // Method to turn off the thermostat
    public void TurnOff()
    {
        isOn = false;
    }
   
    public void ShowStatus()
    {
        Console.WriteLine($"Thermostat is currently {(isOn ? "ON" : "OFF")}, Current Temperature: {currentTemperature}°C.");
    }
}
