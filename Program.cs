using System;
using System.Collections.Generic;
using System.Reflection;

public class QueueExemplo
{
    public static void Main(String[] args)
    {
        Queue<int> q = new Queue<int>();

        // Adiciona elementos {0, 1, 2, 3, 4} no queue
        for (int i = 0; i < 5; i++)
            q.Enqueue(i);

        Console.Write("Elementos do queue-");
        foreach (int s in q)
            Console.Write(s + " ");


        int remove = q.Dequeue();
        Console.Write("\nremove elemento-" + remove + "\n");
        foreach (int s in q)
            Console.Write(s + " ");

        // para ver a cabeça do queue
        int cabeça = q.Peek();
        Console.Write("\ncabeça do queue-" + cabeça);


        // implementação.
        int tamanho = q.Count;
        Console.WriteLine("\ntamanho do queue-" + tamanho);
        Queue<string> strQ = new Queue<string>();
        strQ.Enqueue("o");
        strQ.Enqueue("l");
        strQ.Enqueue("l");
        strQ.Enqueue("l");
        strQ.Enqueue("á");

        Console.WriteLine("Total elementos: {0}", strQ.Count); //prints 5

        while (strQ.Count > 0)
            Console.WriteLine(strQ.Dequeue()); //prints ollá

        Console.WriteLine("Total elementos: {0}", strQ.Count); //prints 0

       

        Console.WriteLine("Tecle enter para fechar");
                Console.ReadLine();



            }
}
