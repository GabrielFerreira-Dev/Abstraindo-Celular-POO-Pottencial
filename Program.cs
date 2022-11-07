using DesafioPOO.Models;

System.Console.WriteLine("Celular Nokia: ");
Smartphone nokia = new Nokia(numero: "(00)12345-6789", modelo: "Modelo 1", imei: "11111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

System.Console.WriteLine("Celular Iphone: ");
Smartphone iphone = new Iphone(numero: "(99)87654-3210", modelo: "Modelo 2", imei: "2222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");