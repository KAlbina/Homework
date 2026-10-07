using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    public class Car
    {
        public string Vin { get; }
      
        public string Brand { get; init; }
        public double Speed { get; private set; }
  
        public double Fuel { get; private set; }

        public string Model { get; init; }
  
        public int Year { get; }
     
        public bool EngineOnOff { get; private set; }
     
        public Car(string brand, string model, string vin, int year)
        {
            Brand = brand;
            Model = model;
            Vin = vin;
            Year = year;
        }
        public void StartEngine()
        {
            EngineOnOff = true;
        }
        public void StopEngine()
        {
            if (Speed > 0)
                throw new InvalidOperationException("Нельзя выключить двигатель во время движения");

            EngineOnOff = false;
        }
        public void Accelerate(double amount)
        {
            if (!EngineOnOff)
            {
                throw new InvalidOperationException("Нельзя увеличить скорость при выключенном двигателе");
            }

            if (amount <= 0)
            {
                throw new ArgumentException("Увеличение скорости должно быть больше нуля");
            }
            if (Speed +  amount > 300)
            {
                throw new ArgumentException("Скорость не может быть больше 300 км/ч");
            }
            Speed += amount;
        }
        public void Brake(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Уменьшение скорости должно быть больше нуля");
            }
            if (Speed - amount < 0)
            {
                throw new ArgumentException("Скорость не может быть меньше 0 км/ч");
            }

            Speed -= amount;
        }
        public void Refuel(double amount)
        {
            if (amount <= 0)
            { 
                throw new ArgumentException("Количество топлива должно быть больше нуля"); 
            }
            if (Fuel + amount > 100)
            {
                throw new ArgumentException("Топливо не может превышать 100 литров");
            }

            Fuel += amount;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Марка: {Brand}, Модель: {Model}, VIN: {Vin}, Год: {Year}, " +
                $"Скорость: {Speed} км/ч, Топливо: {Fuel} л, " +
                $"Двигатель: {(EngineOnOff ? "включен" : "выключен")}");
        }


    }
}
