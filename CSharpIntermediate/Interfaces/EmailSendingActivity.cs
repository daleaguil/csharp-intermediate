using System;

namespace CSharpIntermediate
{
    public class EmailSendingActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Email sent...");
        }
    }
}
