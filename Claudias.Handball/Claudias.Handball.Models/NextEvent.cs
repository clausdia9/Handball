using System;

namespace Claudias.Handball.Models
{
    public class NextEvent
    {
        #region Properties
        public Guid EventId
        { get; set; }

        public string EventName
        { get; set; }

        public string Location
        { get; set; }

        public DateTime Date
        { get; set; }
        #endregion Properties
    }
}
