using Domain.Entities.ProjectAggregate;
using System.Collections.Generic;

namespace Domain.Entities.ScoreAggregate
{
    public class ScoreItem : BaseEntity
    {
        #region Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<ScoreProject> ScoreProjects { get; set; }
        #endregion
    }
}
