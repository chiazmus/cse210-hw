using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "Andrew Burnah";

        // I wish I actually had these jobs...
        // Someday.
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Senior Software Engineer";
        job2._startYear = 2023;
        job2._endYear = 2024;

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();

    }
}