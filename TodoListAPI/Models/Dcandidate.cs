using System;
using System.Collections.Generic;

namespace TodoListAPI.Models
{
    public partial class Dcandidate
    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public string Level { get; set; } = null!;
    }
}
