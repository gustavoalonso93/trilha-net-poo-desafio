using DesafioPOO.Models;
﻿using System;

// TODO: Realizar os testes com as classes Nokia e Iphone


        Smartphone cel1 = new Nokia("101010", "modelo1", "1111111-1", 64);
        cel1.Ligar();
        cel1.InstalarAplicativo("Instagram");

        Console.WriteLine("\n-----------------------\n");

        Smartphone cel2 = new Iphone(numero: "1212122", modelo: "X22", imei: "31313-1", memoria: 128);
        cel2.Ligar();
        cel2.InstalarAplicativo("iPhone");
