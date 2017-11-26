using System;
using System.Collections.Generic;
using System.Text;

namespace UMT360.Handball.Models
{
    class NextEvent
    {
        public Guid EventId
        { get; set; }

        public string EventName
        { get; set; }

        public string Location
        { get; set; }

        public DateTime Date
        { get; set; }
    }
}
