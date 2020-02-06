using System;

namespace Domain.Entities
{
    public class BaseEntity
    {
        #region Properties
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Enabled { get; set; }
        #nullable enable
        public DateTime? UpdtatedAt { get; set; }
        #endregion
    }
}
