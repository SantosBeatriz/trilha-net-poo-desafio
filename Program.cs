using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "111111", memoria: 40);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iPhone = new Iphone(numero: "6789", modelo: "Modelo 2", imei: "1222222", memoria: 30);
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Whatsapp");