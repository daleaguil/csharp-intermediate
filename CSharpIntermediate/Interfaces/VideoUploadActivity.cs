using System;

namespace CSharpIntermediate
{
    public class VideoUploadActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video uploaded to cloud storage...");
        }
    }
}
