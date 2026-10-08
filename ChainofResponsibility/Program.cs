using ChainofResponsibility;

EndHandler end = new EndHandler();

CardHandler card = new CardHandler(end);

PhoneHandler phone = new PhoneHandler(card);

string massege = "Телефон: 89123456789, карта: 1234567812345678";

string result = phone.Handle(massege);

Console.WriteLine(result);
