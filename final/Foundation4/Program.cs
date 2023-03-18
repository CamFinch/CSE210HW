using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> acvitivies = new List<Activity>();

        //string date, int time, int distance

        Running r1 = new Running("March 10, 2023", 45, 3);
        acvitivies.Add(r1);
        
        //string date, int time, int speed

        Cycling c1 = new Cycling("April 9, 2023", 60, 10);
        acvitivies.Add(c1);

        //string date, int time, int laps

        Swimming s1 = new Swimming("April 18, 2023", 30, 35);
        acvitivies.Add(s1);

        foreach(Activity act in acvitivies){
            string dates = act.GetDate();
            int times = act.GetTime();
            string sum = act.GetSummary();
            Console.WriteLine($"{dates} Running ({times} Minutes) {sum}");
        }
    }
}