using System;
using System.Linq;
using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
        System.Console.WriteLine("Insira 10 números separados por espaço: ");
        string input = Console.ReadLine();
        List<int> numeros = input.Split(' ').Select(Int32.Parse).ToList();


        if(numeros.Count != 10){
        System.Console.WriteLine("Input inválido: quantidade de números inseridos diferente de 10.");
        return;
        }

        if(numeros.Count != numeros.Distinct().Count())
        {
        System.Console.WriteLine("Input inválido: número repetido encontrado.");
        return;
        }

        int sum=numeros[0];
        int maior=numeros[0];
        int menor=numeros[0];
        List<int> acima_de_10 = new List<int>();
        List<int> acima_de_50 = new List<int>();

        for(int i=1; i<10; i++){
        if(numeros[i] > maior){
        maior = numeros[i];
        }

        if(numeros[i] < menor){
        menor = numeros[i];
        }

        sum+=numeros[i];

        if(numeros[i] > 10){
        acima_de_10.Add(numeros[i]);
        }

        if(numeros[i] > 50){
        acima_de_50.Add(numeros[i]);
        }
        }


        System.Console.WriteLine("Maior número: {0}", maior);
        System.Console.WriteLine("Menor número: {0}", menor);
        System.Console.WriteLine("Média aritmética: {0}", sum/10);
        System.Console.WriteLine("Quantidade de números acima de 10: {0}", acima_de_10.Count);
        foreach (int numero in acima_de_10)
                {
        Console.Write(numero);
        Console.Write(" ");
                }
        Console.Write("\n");
        System.Console.WriteLine("Quantidade de números acima de 50: {0}", acima_de_50.Count);
        foreach (int numero in acima_de_50)
                {
        Console.Write(numero);
        Console.Write(" ");
                }
    }
}
