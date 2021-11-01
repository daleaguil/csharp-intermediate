using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach (IActivity activity in workflow.Activities)
            {
                activity.Execute();
            }
        }
    }
}
