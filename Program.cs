using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone: ");
Smartphone iphone = new Iphone(numero: "7894", modelo: "Modelo 2", imei: "22222", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");