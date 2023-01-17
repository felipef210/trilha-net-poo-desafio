//Nome: Felipe Miranda

using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234", modeloCelular: "lumia", imeiCelular: "11111", memoriaCelular: 64);
Console.WriteLine($"Número: {nokia.Numero}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "5678", modeloCelular: "Iphone X", imeiCelular: "22222", memoriaCelular: 256);
Console.WriteLine($"Número: {iphone.Numero}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");