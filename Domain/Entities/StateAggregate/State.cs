using Domain.Entities.ProjectAggregate;
using System.Collections.Generic;

namespace Domain.Entities.StateAggregate
{
    public class State : BaseEntity
    {
        #region Propiedades
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<StateProject> StateProjects { get; set; }
        #endregion
    }
}
