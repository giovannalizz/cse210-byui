public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by guiding you through slow breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        AskForDuration();

        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            elapsedTime += 3;

            if (elapsedTime >= Duration) break;

            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            elapsedTime += 3;
        }

        DisplayEndingMessage();
    }
}
