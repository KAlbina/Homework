using Homework4;

Car car = new Car("BMW", "X5", "123ABC", 2025);
car.GetInfo(); 
car.StartEngine();
car.Accelerate(50);
car.Brake(20); 
car.Refuel(30);
car.GetInfo();
car.Brake(30);
car.StopEngine();
car.GetInfo();

