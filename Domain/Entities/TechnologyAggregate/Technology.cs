using Domain.Entities.ProjectAggregate;
using System.Collections.Generic;

namespace Domain.Entities.TechnologyAggregate
{
    public class Technology : BaseEntity
    {
        #region Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Logo { get; set; }
        public IEnumerable<TechnologyProject> TechnologyProjects { get; set; }
        #endregion
    }
}
