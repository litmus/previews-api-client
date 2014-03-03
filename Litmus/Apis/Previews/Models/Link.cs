using System.Collections.Generic;

namespace Litmus.Apis.Previews.Models
{
    public class Link
    {
        public string Url { get; set; }
        public bool IsValid { get; set; }
        public string Exception { get; set; }
        public bool IsBlacklisted { get; set; }
        public bool HasGoogleAnalytics { get; set; }
        public bool HasClickTracking { get; set; }
        public string PageTitle { get; set; }
        public int TopLeftX { get; set; }
        public int TopLeftY { get; set; }
        public Dictionary<string, string> GoogleAnalyticsParameters { get; set; }
        public string ThumbnailUri { get; set; }
    }
}
