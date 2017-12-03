using System;

namespace Claudias.Handball.Models
{
    public class Photo
    {
        #region Properties
        public Guid PhotoId
        { get; set; }

        public Byte[] PhotoVarbinary
        { get; set; }
        #endregion Properties
    }
}
