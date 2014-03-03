using System.Collections.Generic;

namespace Litmus.Apis.Previews.Models
{
    /// <summary>
    /// Summary description for CodeAnalysisTestByTestingApplication
    /// </summary>
    public class CodeAnalysisTestByTestingApplications
    {
        /// <summary>
        /// Html to analyze
        /// </summary>
        public string Html { get; set; }

        /// <summary>
        /// Applications to analyze against
        /// </summary>
        public List<string> TestingApplications;
    }
}