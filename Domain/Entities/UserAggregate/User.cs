using Domain.Entities.ProjectAggregate;
using System;
using System.Collections.Generic;

namespace Domain.Entities.UserAggregate
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public IEnumerable<UserProject> UserProjects { get; set; }
    }
}
