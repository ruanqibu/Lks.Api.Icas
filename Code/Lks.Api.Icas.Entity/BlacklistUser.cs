// <auto-generated>
using Lks.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Lks.Api.Icas.Entity
{

    /// <summary>
    /// BlacklistUser
    /// </summary>
    [Serializable]
    public class BlacklistUser
    {
        public int Id { get; set; } // Id (Primary key)
        public int UserId { get; set; } // UserId
        public int BuserId { get; set; } // BuserId
        public UserType UserType { get; set; } // UserType
        public Status Status { get; set; } // Status
    }

}
// </auto-generated>
