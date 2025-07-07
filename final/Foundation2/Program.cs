using System;

namespace Foundation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job();
            job1.SetJobDetails("Microsoft", "Software Engineer", 3);
            job1.Display();
        }
    }
}
