using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Litmus.Apis.Previews.Models
{

    /// <summary>
    /// Summary description for SpamHeader
    /// </summary>
    public class SpamHeader
    {
        public string Key { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}