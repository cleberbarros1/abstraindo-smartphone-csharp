using Models;

Console.WriteLine("Smartphone do tipo Nokia:");
Smartphone nokia = new Nokia(numero: "123", modelo: "M1", imei: "1", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n-------------------\n");

Console.WriteLine("Smartphone do tipo Iphone:");
Smartphone iphone = new Nokia(numero: "456", modelo: "M2", imei: "2", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");