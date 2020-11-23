using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            if (activity == null)
                throw new InvalidOperationException("Please, provide a valid activity");
            
            _activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            if (activity == null)
                throw new InvalidOperationException("Please, provide a valid activity");

            _activities.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }

    }
}
