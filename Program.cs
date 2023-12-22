using DesafioPOO.Models;

Nokia n1 = new Nokia("555-555", "C6", "i12345663123", 32);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Facebook");

Console.WriteLine("----------------------------------------");

Iphone i1 = new Iphone("333-333", "11", "c123453m12354", 128);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagram");