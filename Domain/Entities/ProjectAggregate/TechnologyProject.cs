using Domain.Entities.TechnologyAggregate;

namespace Domain.Entities.ProjectAggregate
{
    public class TechnologyProject : BaseEntity
    {
        #region Properties
        public int TechnologyId { get; set; }
        public int ProjectId { get; set; }
        public Technology Technology { get; set; }
        public Project Project { get; set; }
        #endregion
    }
}
