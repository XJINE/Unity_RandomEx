using System;

namespace UnityEngine
{
    public class Xorshift : UnityEngine.RandomAbstract
    {
        #region Field

        protected XorshiftBase xorshiftBase;

        #endregion Field

        #region Constructor

        public Xorshift()
            : this(Guid.NewGuid().GetHashCode())
        {
        }

        public Xorshift(int seed)
            : this((uint)seed)
        {
        }

        public Xorshift(uint seed)
        {
            this.xorshiftBase = new XorshiftBase(seed);
        }

        #endregion Constructor

        #region Method

        public override float Value()
        {
            return this.xorshiftBase.Value();
        }

        #endregion Method
    }
}