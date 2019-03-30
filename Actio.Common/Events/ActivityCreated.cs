using System;

namespace Actio.Common.Events
{
    public class ActivityCreated : IEvent
    {
        public Guid UserId { get; }

        public Guid Id { get; }

        public string Category { get; }

        public string Name { get; }

        public string Description { get; }

        public DateTime Created { get; }

        protected ActivityCreated()
        {

        }

        public ActivityCreated(Guid id, Guid userId, string name, string category, string description, DateTime created)
        {
            UserId = userId;
            Name = name;
            Category = category;
            Description = description;
            Created = created;
        }
    }
}