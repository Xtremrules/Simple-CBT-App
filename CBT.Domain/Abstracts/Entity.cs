﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CBT.Domain.Abstracts
{
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T ID { get; set; }
    }
}