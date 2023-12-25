using DesafioPOO.Models;

Console.WriteLine("TESTE SMARTPHONE NOKIA: ");
Smartphone nokia = new Nokia(numero: "11 12345-6789", modelo:"ModeloBarato", imei:"0000000001", memoria:124);
nokia.Ligar();
nokia.InstalarAplicativo("Calculadora");

Console.WriteLine("TESTE SMARTPHONE IPHONE: ");

Smartphone iphone = new Iphone(numero:"21 98765-4321", modelo:"ModeloCaro", imei:"000000002", memoria:32);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");