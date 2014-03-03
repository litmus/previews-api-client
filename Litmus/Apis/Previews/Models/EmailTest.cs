using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Litmus.Apis.Previews.Models
{
    /// <summary>
    /// Summary description for EmailTest
    /// </summary>
    public class EmailTest
    {
        public List<TestingApplication> TestingApplications { get; set; }
        public string State { get; set; }
        public string InboxGuid { get; set; }
        public int Id { get; set; }
        public string Source { get; set; }
        public string Subject { get; set; }
        public string Html { get; set; }
        public string ZipFile { get; set; }
        public TestType TestType { get; set; }
        public bool Sandbox { get; set; }
        public string UserGuid { get; set; }
        public bool Error { get; set; }
        public string ErrorMessage { get; set; }
    }
}