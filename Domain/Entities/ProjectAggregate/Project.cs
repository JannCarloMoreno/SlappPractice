using System;
using System.Collections.Generic;

namespace Domain.Entities.ProjectAggregate
{
    public class Project : BaseEntity
    {
        #region Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime BeginDate { get; set; }
        public IEnumerable<UserProject> UserProjects { get; set; }
        public IEnumerable<TechnologyProject> TechnologiesProject { get; set; }
#nullable enable
        public DateTime? EndDate { get; set; } 
        #endregion
    }
}
