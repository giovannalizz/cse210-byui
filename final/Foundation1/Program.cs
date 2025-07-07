using System;

namespace Foundation1
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video();
            video1.Title = "Understanding Abstraction";
            video1.Author = "Giovanna";
            video1.Length = 300;

            video1.DisplayInfo(); // We don’t need to know how it prints internally
        }
    }
}
