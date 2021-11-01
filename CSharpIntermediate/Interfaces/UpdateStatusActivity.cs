using System;

namespace CSharpIntermediate
{
    public class UpdateStatusActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Status of the video processing has been updated in the database...");
        }
    }
}
