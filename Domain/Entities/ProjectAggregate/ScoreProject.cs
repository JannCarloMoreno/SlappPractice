using Domain.Entities.ScoreAggregate;

namespace Domain.Entities.ProjectAggregate
{
    public class ScoreProject : BaseEntity
    {
        #region Properties
        public int UserEvaluatorId { get; set; }
        public int UserEvaluatedId { get; set; }
        public int ScoreItemId { get; set; }
        public int Score { get; set; }
        public UserProject UserEvaluator { get; set; }
        public UserProject UserEvaluated { get; set; }
        public ScoreItem ScoreItem { get; set; }
        #endregion
    }
}
