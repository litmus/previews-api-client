using System.Collections.Generic;

namespace Litmus.Apis.Previews.Models
{
    public class CodeAnalysisTest
    {
        public List<CodeAnalysisPotentialProblems> CompatibilityProblems { get; set; }
        public int CompatibilityRulesCount { get; set; }
        public List<CodeAnalysisHtmlValidation> HtmlProblems { get; set; }
    }
}
