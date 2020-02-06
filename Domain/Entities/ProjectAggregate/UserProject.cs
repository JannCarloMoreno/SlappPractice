using Domain.Entities.UserAggregate;
using System;
using System.Collections.Generic;

namespace Domain.Entities.ProjectAggregate
{
    public class UserProject : BaseEntity
    {
        #region Properties
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public User User { get; set; }
        public Project Project { get; set; }
        public IEnumerable<ScoreProject> OwnScores { get; set; }
        public IEnumerable<ScoreProject> ScoresEmitted { get; set; }

#nullable enable
        public DateTime? EndDate { get; set; }
        
        #endregion
    }
} 
