using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Activity r = new Running("03 Nov 2022", 30, 3.0);
        Activity c = new Cycling("03 Nov 2022", 45, 12.0);
        Activity s = new Swimming("03 Nov 2022", 25, 40);

        List<Activity> activities = new List<Activity>() { r, c, s };

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
