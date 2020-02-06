using Domain.Entities.StateAggregate;
using System;

namespace Domain.Entities.ProjectAggregate
{
    public class StateProject : BaseEntity
    {
        #region Properties
        public int ProjectId { get; set; }
        public int StateId { get; set; }
        public DateTime Date { get; set; }
        public Project Project { get; set; }
        public State State { get; set; }
        #endregion
    }
}
