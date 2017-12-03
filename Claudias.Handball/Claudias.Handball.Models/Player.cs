using System;

namespace Claudias.Handball.Models
{
    public class Player
    {
        #region Properties
        public Guid PlayerId
        { get; set; }

        public string PlayerName
        { get; set; }

        public int Goals
        { get; set; }

        public DateTime BirthDay
        { get; set; }
        #endregion Properties
    }
}
