using Sitecore.Analytics;
using Sitecore.Diagnostics;
using Sitecore.Pipelines;

namespace Sitecore.Support.Analytics.Pipelines.StartAnalytics
{
    public class TrackerChecker : Sitecore.Analytics.Pipelines.StartAnalytics.CreateTracker
    {
        public override void Process(PipelineArgs args)
        {           
            if (Tracker.Current == null)
            {
                Log.Info("Sitecore.Support.147407: aborting StartAnalytics pipeline since Tracker.Current is not initialized.", this);
                args.AbortPipeline(); //abort pipeline

            }            
        }
    }
}