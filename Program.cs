using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "11 98747-8562", modelo: "Iphone 15 Pro", imei: "458967123014", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("Nokia:");
Smartphone nokia = new Iphone(numero: "11 98646-8963", modelo: "G11 Plus", imei: "14523678912", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
