﻿using prmToolkit.NotificationPattern;

namespace Project.Domain.Entities.Base
{
    public abstract class EntityBase : Notifiable
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }
        public virtual Guid Id { get; set; }
    }
}
