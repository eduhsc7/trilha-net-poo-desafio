using DesafioPOO.Models;

// IPHONE
Iphone iphone = new Iphone("(11)9897-65674", "X", "3478546654655" , 256);
Console.WriteLine("Você adquiriu o seu Iphone!");
iphone.MostrarCaracteristicas();
iphone.InstalarAplicativo("Facebook");
iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine("=================================================");

// NOKIA
Console.WriteLine("Você adquiriu o seu Nokia!");
Nokia nokia = new Nokia("(11)95487-9856", "G11", "88854365874582", 128);
nokia.MostrarCaracteristicas();
nokia.InstalarAplicativo("Twitter");
nokia.Ligar();
nokia.ReceberLigacao();


