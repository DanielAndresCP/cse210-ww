using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Zenitx";
        job1._jobTitle = "Chief Executive Officer";
        job1._startYear = 2000;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Antumalal";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 1980;
        job2._endYear = 2000;

        Resume resume1 = new Resume();
        resume1._name = "José Concha";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}