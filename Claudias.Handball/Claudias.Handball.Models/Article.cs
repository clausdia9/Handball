using System;

namespace Claudias.Handball.Models
{
    public class Article
    {
        #region Properties
        public Guid ArticleId
        { get; set; }

        public string Title
        { get; set; }

        public string Author
        { get; set; }

        public string Description
        { get; set; }
        #endregion Properties
    }
}

