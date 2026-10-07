using PolimorfismHomework7;

DeliveryService deliveryService = new DeliveryService();
//подтипов
CourierDelivery courier = new CourierDelivery();
decimal price = deliveryService.CalculatePrise(courier, 10);
Console.WriteLine(price);

DroneDelivery drone = new DroneDelivery();
decimal dronePrice = deliveryService.CalculatePrise(drone, 10);
Console.WriteLine(dronePrice);


//динамический 
DeliveryBase delivery = new DroneDelivery();
Console.WriteLine(delivery.GetDeliveryInfo());


//статический
DiscountService discountService = new DiscountService();
discountService.ApplyDiscount("SALE");
discountService.ApplyDiscount(10);
discountService.ApplyDiscount(100m);


