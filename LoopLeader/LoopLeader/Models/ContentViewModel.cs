using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoopLeader.Domain.Entities;

namespace LoopLeader.Models
{
    public class ContentViewModel
    {
        public string ContentID { get; set; }
        public List<Content> ContentList { get; set; }
    }
}