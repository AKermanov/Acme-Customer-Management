using System;

namespace ACM.BusinessLogic
{
   public abstract class EntityBase
    {
        public enum EntityStateOption
        {
            Active = 0,
            Deleted = 1,
        }
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid => Validate();

        public abstract bool Validate();
    }
}
