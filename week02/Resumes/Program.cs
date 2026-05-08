using System;

/*

*/

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();
        resume._name = "Daniel Fackrell";

        Job job1 = new Job();
        job1._company = "Vasion";
        job1._jobTitle = "Senior Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2025;
        resume._jobs.Add(job1);

        Job job2 = new Job();
        job2._company = "PerfectSearch";
        job2._jobTitle = "Lead Software Engineer";
        job2._startYear = 2019;
        job2._endYear = 2020;
        resume._jobs.Add(job2);
        
        resume.Display();
    }
}