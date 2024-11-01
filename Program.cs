﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "AF0352", imei: "1111111111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");



Console.WriteLine("\n");


Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero:"45214", modelo:"Modelo 2", imei:"2222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WildRift");