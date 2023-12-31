// Models/Content.cs

using System;

namespace WritingSpace.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}