namespace Foundation1
{
    public class Video
    {
        public string Title;
        public string Author;
        public int Length;

        public void DisplayInfo()
        {
            Console.WriteLine($"{Title} by {Author} - {Length} seconds");
        }
    }
}
