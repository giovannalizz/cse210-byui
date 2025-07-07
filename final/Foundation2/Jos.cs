namespace Foundation2
{
    public class Job
    {
        private string _company;
        private string _position;
        private int _years;

        public void SetJobDetails(string company, string position, int years)
        {
            _company = company;
            _position = position;
            _years = years;
        }

        public void Display()
        {
            Console.WriteLine($"{_position} at {_company} for {_years} years");
        }
    }
}
