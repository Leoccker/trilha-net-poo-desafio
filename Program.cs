using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

    Console.WriteLine("Smartphone Iphone:");
    var iphone = new Iphone("123456789", "Iphone 12", "128GB", "IMEI123456789");
    iphone.Ligar();
    iphone.InstalarAplicativo("WhatsApp");

    Console.WriteLine("\n");

    Console.WriteLine("Smartphone Nokia:");
    var nokia = new Nokia("987654321", "Nokia 3310", "32MB", "IMEI987654321");
    nokia.Ligar();
    nokia.InstalarAplicativo("Orkut");
