using Sitecore.Analytics;
using Sitecore.Diagnostics;
using Sitecore.Pipelines;
using System;

namespace Sitecore.Support.Analytics.Pipelines.StartAnalytics
{
    public class CreateTracker : Sitecore.Analytics.Pipelines.StartAnalytics.CreateTracker
    {
        public override void Process(PipelineArgs args)
        {
            try
            {
                base.Process(args);
            }
            catch (Exception ex)
            {
                Log.Error("Sitecore.Support.147407: Cannot create tracker.", ex, typeof(CreateTracker));
                args.AbortPipeline();
            }
        }
    }
}