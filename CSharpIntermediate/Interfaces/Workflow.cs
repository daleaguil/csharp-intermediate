using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Workflow
    {
        public IList<IActivity> Activities { get; set; }
        public Workflow()
        {
            Activities = new List<IActivity>();
        }
    }
}
