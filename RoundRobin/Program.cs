using System;

public class GFG
{

    static void findWaitingTime(int[] processos,
             int n, int[] bt, int[] wt, int quantum)
    {


        int[] rem_bt = new int[n];

        for (int i = 0; i < n; i++)
            rem_bt[i] = bt[i];

        int t = 0;


        while (true)
        {
            bool done = true;


            for (int i = 0; i < n; i++)
            {

                if (rem_bt[i] > 0)
                {


                    done = false;

                    if (rem_bt[i] > quantum)
                    {

                        t += quantum;


                        rem_bt[i] -= quantum;
                    }


                    else
                    {


                        t = t + rem_bt[i];


                        wt[i] = t - bt[i];


                        rem_bt[i] = 0;
                    }
                }
            }


            if (done == true)
                break;
        }
    }


    static void findTurnAroundTime(int[] processes,
               int n, int[] bt, int[] wt, int[] tat)
    {

        for (int i = 0; i < n; i++)
            tat[i] = bt[i] + wt[i];
    }


    static void findavgTime(int[] processos, int n,
                             int[] bt, int quantum)
    {
        int[] wt = new int[n];
        int[] tat = new int[n];
        int total_wt = 0, total_tat = 0;


        findWaitingTime(processos, n, bt, wt, quantum);


        findTurnAroundTime(processos, n, bt, wt, tat);


        Console.WriteLine("Processos " + " Tempo de Burst" +
                    " Tempo de espera " + " Tempo de Turn Round");


        for (int i = 0; i < n; i++)
        {
            total_wt = total_wt + wt[i];
            total_tat = total_tat + tat[i];
            Console.WriteLine(" " + (i + 1) + "\t\t" + bt[i]
                         + "\t " + wt[i] + "\t\t " + tat[i]);
        }

        Console.WriteLine("Tempo médio de espera = " +
                        (float)total_wt / (float)n);
        Console.Write("Tempo médio de Turn Round = " +
                        (float)total_tat / (float)n);
    }


    public static void Main()
    {

        int[] processos = { 1, 2, 3 };
        int n = processos.Length;


        int[] burst_time = { 10, 5, 8 };

        // Tempo quantum
        int quantum = 2;
        findavgTime(processos, n, burst_time, quantum);
    }
}