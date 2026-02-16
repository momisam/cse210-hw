using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("16 Feb 2026", 30, 3.0));
        activities.Add(new Cycling("16 Feb 2026", 45, 12.0));
        activities.Add(new Swimming("16 Feb 2026", 40, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
