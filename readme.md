# Sitecore.Support.147407

Sitecore XP may sometimes throw the `Tracker.Current is not initialized` error after MongoDB C#\.NET Drive fails connect to a MongoDB server.

An example of the exception and its stack trace is:

```
ERROR Application error.
Exception: System.InvalidOperationException
Message: Tracker.Current is not initialized
Source: Sitecore.Analytics
   at Sitecore.Analytics.Pipelines.StartAnalytics.StartTracking.Process(PipelineArgs args)
   at (Object , Object[] )
   at Sitecore.Pipelines.CorePipeline.Run(PipelineArgs args)
   at Sitecore.Analytics.Pipelines.StartAnalytics.StartAnalyticsPipeline.Run()
   at Sitecore.Mvc.Analytics.Pipelines.MvcEvents.RequestBegin.StartTracking.Process(RequestBeginArgs args)
   at (Object , Object[] )
   at Sitecore.Pipelines.CorePipeline.Run(PipelineArgs args)
   at Sitecore.Mvc.Pipelines.PipelineService.RunPipeline[TArgs](String pipelineName, TArgs args)
   at Sitecore.Mvc.Routing.RouteHttpHandler.BeginProcessRequest(HttpContext context, AsyncCallback cb, Object extraData)
   at System.Web.HttpApplication.CallHandlerExecutionStep.System.Web.HttpApplication.IExecutionStep.Execute()
   at System.Web.HttpApplication.ExecuteStep(IExecutionStep step, Boolean& completedSynchronously)
```

## License  
This patch is licensed under the [Sitecore Corporation A/S License for GitHub](https://github.com/sitecoresupport/Sitecore.Support.147407/blob/master/LICENSE).  

## Download  
Downloads are available via [GitHub Releases](https://github.com/sitecoresupport/Sitecore.Support.147407/releases).  

[![Github All Releases](https://img.shields.io/github/downloads/SitecoreSupport/Sitecore.Support.147407/total.svg)](https://github.com/SitecoreSupport/Sitecore.Support.147407/releases)
