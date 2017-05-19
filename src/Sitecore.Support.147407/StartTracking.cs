namespace Sitecore.Support.Mvc.Analytics.Pipelines.MvcEvents.RequestBegin
{
  using Sitecore;
  using Sitecore.Analytics;
  using Sitecore.Analytics.Tracking;
  using Sitecore.Diagnostics;
  using Sitecore.Mvc.Pipelines.Request.RequestBegin;
  using Sitecore.Sites;
  using Sitecore.Xdb.Configuration;
  using System;

  public class StartTracking : RequestBeginProcessor
  {
    public override void Process(RequestBeginArgs args)
    {
      Assert.ArgumentNotNull(args, "args");
      if (XdbSettings.Tracking.Enabled)
      {
        SiteContext site = Context.Site;
        if (site != null)
        {
          TrackingSiteContext context2 = new TrackingSiteContext(site.SiteInfo);
          if (context2.EnableTracking)
          {
            try
            {
              Tracker.StartTracking();
              bool isActive = Tracker.IsActive;
            }
            catch (Exception ex)
            {
              Log.Error("Sitecore.Support.147407: Cannot start tracking.", ex, typeof(Tracker));
            }
          }
        }
      }
    }
  }
}
