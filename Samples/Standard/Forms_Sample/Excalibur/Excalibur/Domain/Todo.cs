﻿using Excalibur.Shared.Storage;

namespace Excalibur.Domain
{
    public class Todo : StorageDomain<int>
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}
