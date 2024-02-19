using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia meuNokia = new Nokia("987654321", "Nokia 3310", "987654321098765", 16);
meuNokia.Ligar();
meuNokia.ReceberLigacao();
meuNokia.BaixarAplicativo("Snake", 5);
meuNokia.EnviarSMS();
meuNokia.ChecarMemoria();
meuNokia.InstalarAplicativo("Twitter");

Iphone meuIphone = new Iphone("123456789", "iPhone 12", "123456789012345", 64);
meuIphone.Ligar();
meuIphone.ReceberLigacao();
meuIphone.BaixarAplicativo("WhatsApp", 50);
meuIphone.EnviarSMS();
meuIphone.ChecarMemoria();
meuIphone.InstalarAplicativo("Facebook");


Lenovo meuLenovo = new Lenovo("111222333", "111222333444555");
meuLenovo.Ligar();
meuLenovo.ReceberLigacao();
meuLenovo.BaixarAplicativo("LenovoApp", 10);
meuLenovo.EnviarSMS();
meuLenovo.ChecarMemoria();
meuLenovo.InstalarAplicativo("WhatsApp");

Samsung meuSamsung = new Samsung("999888777", "999888777666555");
meuSamsung.Ligar();
meuSamsung.ReceberLigacao();
meuSamsung.BaixarAplicativo("SamsungApp", 20);
meuSamsung.EnviarSMS();
meuSamsung.ChecarMemoria();
meuSamsung.InstalarAplicativo("Facebook");