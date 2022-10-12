﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    //IEntity implement eden class bir veritabanı tablosudur
    public interface IEntity
    {
    }
    public interface IEntity<out TKey> : IEntity where TKey : IEquatable<TKey>
    {
        public TKey Id { get; }
        DateTime CreatedAt { get; set; }
    }
}
