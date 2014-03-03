using System.Collections.Generic;

namespace Litmus.Apis.Previews.Models
{
    /// <summary>
    /// Summary description for PageTest
    /// </summary>
    public class PageTest
    {    
        public List<TestingApplication> TestingApplications { get; set; }
        public string State { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public TestType TestType { get; set; }
        public bool Sandbox { get; set; }
        public string UserGuid { get; set; }
        public bool Error { get; set; }
        public string ErrorMessage { get; set; }
    }
}