using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudieHulp.Models
{
    public class UserPost
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
    }
}
