using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Litmus.Apis.Previews.Models
{
    /// <summary>
    /// Summary description for TestingApplication
    /// </summary>
    public class TestingApplication
    {
        public string State { get; set; }
        public string WindowImageContentBlocking { get; set; }
        public string FullpageImageThumb { get; set; }
        public bool BusinessOrPopular { get; set; }
        public string WindowImageThumbNoContentBlocking { get; set; }
        public bool Completed { get; set; }
        public string FullpageImage { get; set; }
        public bool FoundInSpam { get; set; }
        public bool SupportsSpamScoring { get; set; }
        public int Status { get; set; }
        public string WindowImageNoContentBlocking { get; set; }
        public string PlatformName { get; set; }
        public int AverageTimeToProcess { get; set; }
        public List<SpamHeader> SpamHeaders { get; set; }
        public string WindowImageThumb { get; set; }
        public string RenderedHtmlUrl { get; set; }
        public string PlatformLongName { get; set; }
        public string FullpageImageThumbContentBlocking { get; set; }
        public string WindowImage { get; set; }
        public string FullpageImageContentBlocking { get; set; }
        public bool SupportsContentBlocking { get; set; }
        public string ApplicationName { get; set; }
        public string FullpageImageThumbNoContentBlocking { get; set; }
        public double SpamScore { get; set; }
        public bool DesktopClient { get; set; }
        public string WindowImageThumbContentBlocking { get; set; }
        public int Id { get; set; }
        public ResultType ResultType { get; set; }
        public string FullpageImageNoContentBlocking { get; set; }
        public string ApplicationLongName { get; set; }
    }
}