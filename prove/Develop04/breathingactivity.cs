using System;


public class BreathingActivity : Activity
{
    //attributes to hold breathing text
    private string _breathIn;
    private string _breathOut;


    public BreathingActivity(string breathIn, string breathOut, string name, string description, int duration) : base(name, description, duration)
    {
        _breathIn = breathIn;
        _breathOut = breathOut;
    }


    //for breath in message
    public string GetBreathInMessage()
    {
        return ($"{_breathIn}");
    }


    //for breath out message
    public string GetBreathOutMessage()
    {
        return ($"\n{_breathOut}");
    }


    //displays the methods above
    public void DisplayBreathMessage()
    {
        Console.Write($"{GetBreathInMessage()}");
        PausingCountdown();


        Console.Write($"{GetBreathOutMessage()}");
        PausingCountdown();
        Console.WriteLine("\n");
    }


    //run the activity and it´s called by program class
    public void RunBreathingActivity()
    {
        DateTime StartTime = DateTime.Now;
        DateTime Endtime = StartTime.AddSeconds(_activityDuration);
        while (DateTime.Now < Endtime)
            DisplayBreathMessage();
    }
}