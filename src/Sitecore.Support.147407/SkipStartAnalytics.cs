using Sitecore.Analytics;
using Sitecore.Diagnostics;
using Sitecore.Pipelines;

namespace Sitecore.Support.Analytics.Pipelines.StartAnalytics
{
    public class TrackerChecker
    {
        public void Process(PipelineArgs args)
        {           
            if (Tracker.Current == null)
            {
                Log.Warn("Sitecore.Support.147407: aborting StartAnalytics pipeline since Tracker.Current is not initialized.", this);
                args.AbortPipeline();
            }            
        }
    }
}