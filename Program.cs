using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"11999999999", modelo: "Nokia 3310", imei: "1234567890", memoria: "32GB");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone(numero:"11988888888", modelo: "Iphone 14", imei: "0987654321", memoria: "128GB");
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();
