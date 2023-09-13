using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company ="E-Sprockets";
        job1._startYear = 2002;
        job1._endYear = 2010;


        Job job2 = new Job();
        job2._jobTitle = "Janitor";
        job2._company = "Cows'n'Co";
        job2._startYear = 2010;
        job2._endYear = 2015;

        //job1.Display();
        //job2.Display();
        
        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Console.WriteLine(myResume._jobs[0]._company);
        myResume._name = "Franklyn Alexander";
        myResume.Display();

    }
}