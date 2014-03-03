using System.Collections.Generic;

namespace Litmus.Apis.Previews.Models
{
    public class CodeAnalysisPotentialProblems
    {
        public List<string> ApiIds { get; set; }
        public int LineNumber { get; set; }
        public int Severity { get; set; }
        public string Description { get; set; }
    }
}
