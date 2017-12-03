using System;

namespace Claudias.Handball.Models
{
    public class User
    {
        #region Properties
        public Guid UserId
        { get; set; }

        public string UserName
        { get; set; }

        public string Password
        { get; set; }

        public string UserType
        { get; set; }
        #endregion Properties
    }
}
