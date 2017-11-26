using System;
using System.Collections.Generic;
using System.Text;

namespace UMT360.Handball.Models
{
    class Player
    {
        public Guid PlayerId
        { get; set; }

        public string PlayerName
        { get; set; }

        public int Goals
        { get; set; }

        public DateTime BirthDay
        { get; set; }
    }
}
