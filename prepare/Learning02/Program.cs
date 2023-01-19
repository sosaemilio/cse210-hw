using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Nexusbox";
        job1._jobTitle = "Project Manager";
        job1._startYear = 2021;
        job1._endYear =2022;

        Job job2 = new Job();

        job2._company = "iWorker";
        job2._jobTitle = "Virtual Assitant";
        job2._startYear = 2020;
        job2._endYear = 2021;

        job1.DisplayJobTitle();

        Resume myResume = new Resume();

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.displayResume();


    }
}