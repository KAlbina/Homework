using EncapsulationHomework5;

Human human = new Human("настя", 10, 50);
Cat cat = new Cat("котик", 8, 30);
Drone drone = new Drone("дроннннн", 100, 80);

Console.WriteLine(human.Name);
Console.WriteLine(human.LegsCount);
Console.WriteLine(human.HasBrain);

Console.WriteLine();

Console.WriteLine(cat.Name);
Console.WriteLine(cat.LegsCount);
Console.WriteLine(cat.HasBrain);

Console.WriteLine();

Console.WriteLine(drone.Name);
Console.WriteLine(drone.Speed);
Console.WriteLine(drone.HasBattery);