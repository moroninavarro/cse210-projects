using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the ExerciseTracking Project.");

        List<Activity> activity = new List<Activity>();

        Running running = new Running("03 Nov 2022 Running", 30, 3.3);
        activity.Add(running);

        Bicycles bicycles = new Bicycles("04 Nov 2022 Cycling", 30, 5.8, 9.7);
        activity.Add(bicycles);

        Swimming swimming = new Swimming("05 Nov 2022 Swimming", 30, 65, 3.5);
        activity.Add(swimming);

        foreach (Activity activity1 in activity)
        {
            string activities = activity1.GetSummary();

            Console.WriteLine();
            Console.WriteLine($"{activities}");
        }
    }
}