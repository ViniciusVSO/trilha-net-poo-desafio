using DesafioPOO.Models;

Console.WriteLine("Samartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei:"11223344", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Samartphone Iphone:");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei:"44332211", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");