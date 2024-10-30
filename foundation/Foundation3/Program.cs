using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();

        Running running = new Running(40, 5);
        activitiesList.Add(running);
        Cycling cycling = new Cycling(30, 10);
        activitiesList.Add(cycling);
        Swimming swimming = new Swimming(68, 25);
        activitiesList.Add(swimming);


        foreach (Activity activity in activitiesList)
        {
            activity.DisplaySummary();
        }
    }
}