using System;

namespace CSharpIntermediate
{
    public class Stopwatch
    {
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        public bool IsStarted { get; set; }

        public void StartTime(DateTime time)
        {
            if (IsStarted)
                throw new InvalidOperationException("Cannot start twice in a row.");

            Start = time;
            IsStarted = true;
        }

        public void StopTime(DateTime time)
        {
            Stop = time;
            IsStarted = false;

            var duration = Stop - Start;

            Console.WriteLine("Hours: " + duration.Hours + " Minutes: " + duration.Minutes + " Seconds: " + duration.Seconds);
        }
    }
}
