using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    public class Car
    {
        private string _brand;
        private string _model;
        private string _vin;
        private int _year;
        private double _speed;
        private double _fuel;
        private bool _engineOnOff;
        public string Vin
        {
            get
            {
                return _vin;
            }
        }
        public string Brand
        {
            get
            {
                return _brand;
            }
            init
            {
                _brand = value;
            }
        }
        public double Speed
        {
            get
            {
                return _speed;
            }
            private set 
            {
                if (value< 0 || value > 300)
                {
                    throw new ArgumentException("Скорость может быть о 0 до 300 км/ч");
                }
                _speed = value;
            }
        }
        public double Fuel
        {
            get
            {
                return _fuel;
            }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Топливо должно быть о 0 до 100 литров");
                }
                _fuel = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            init
            {
                _model = value;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
        }
        public bool EngineOnOff
        {
            get
            {
                return _engineOnOff;
            }
        }
        public Car(string brand, string model, string vin, int year)
        {
            _brand=brand;
            _model=model;
            _vin=vin;
            _year=year;
        }
        public void StartEngine()
        {
            _engineOnOff = true;
        }
        public void StopEngine()
        {
            if (_speed > 0)
                throw new InvalidOperationException("Нельзя выключить двигатель во время движения");

            _engineOnOff = false;
        }
        public void Accelerate(double amount)
        {
            if (!_engineOnOff)
            {
                throw new InvalidOperationException("Нельзя увеличить скорость при выключенном двигателе");
            }

            if (amount <= 0)
            {
                throw new ArgumentException("Увеличение скорости должно быть больше нуля");
            }
            Speed += amount;
        }
        public void Brake(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Уменьшение скорости должно быть больше нуля");
            }
            Speed -= amount;
        }
        public void Refuel(double amount)
        {
            if (amount <= 0)
            { 
                throw new ArgumentException("Количество топлива должно быть больше нуля"); 
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
