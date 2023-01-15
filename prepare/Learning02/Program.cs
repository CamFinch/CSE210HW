using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Resume resume1 = new Resume();
        job1._jobTitle = "Teacher";
        job1._company = "BYUI";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Doctor";
        job2._company = "Hospital";
        job2._startYear = 2019;
        job2._endYear = 2023;

        resume1._name = "Cameron Finch";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
} 