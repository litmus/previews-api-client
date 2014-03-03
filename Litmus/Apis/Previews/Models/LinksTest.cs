using System.Collections.Generic;

namespace Litmus.Apis.Previews.Models
{
    /// <summary>
    /// Summary description for LinksTest
    /// </summary>
    public class LinksTest
    {

        public int Id { get; set; }
        public List<Link> Links { get; set; }
        public string SourceUrl { get; set; }
        public string ImageUrl { get; set; }
        public string State { get; set; }
        public bool Error { get; set; }
        public string ErrorMessage { get; set; }
    }
}
