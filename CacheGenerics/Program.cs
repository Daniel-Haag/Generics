using CacheGenerics;
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        var cache = new Cache<int>();

        cache.Adicionar("chave1", 42, TimeSpan.FromSeconds(5));

        Console.WriteLine($"Valor antes da expiração: {cache.Obter("chave1")}");

        Thread.Sleep(6000); 

        Console.WriteLine($"Valor após expiração: {cache.Obter("chave1")}"); 
    }
}
