using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Junior Software Developer";
        job1._company = "Adobe";
        job1._startYear = "2023";
        job1._endYear = "2025";

        Job job2 = new Job();
        job2._jobTitle = "Senior Software Developer";
        job2._company = "Adobe";
        job2._startYear = "2025";
        job2._endYear = "Present";

        //job1.Display();
        //job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Luis Brasil";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}