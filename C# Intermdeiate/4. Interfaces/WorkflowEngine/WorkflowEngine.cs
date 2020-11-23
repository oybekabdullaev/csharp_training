using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    public class WorkflowEngine {

        public void Run(IWorkflow workflow)
        {
            foreach (IActivity activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}
