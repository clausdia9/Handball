using System;

namespace UMT360.Handball.Models
{
    public class Article
    {
        public Guid ArticleId
        { get; set; }

        public string Title
        { get; set; }

        public string Author
        { get; set; }

        public string Description
        { get; set; }
    }
}
