using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Criando uma instância de Nokia
Console.WriteLine("Testando o Nokia:");
Nokia meuNokia = new Nokia("123456789", "Nokia 3310", "111111111111111", 64);
meuNokia.Ligar();
meuNokia.ReceberLigacao();
meuNokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");
Console.WriteLine("---------------------------------------");
Console.WriteLine("\n");

//Criando uma instância de iPhone
Console.WriteLine("Testando o iPhone:");
Iphone meuIphone = new Iphone("987654321", "iPhone 12", "777777777777777", 128);
meuIphone.Ligar();
meuIphone.ReceberLigacao();
meuIphone.InstalarAplicativo("Facebook");


