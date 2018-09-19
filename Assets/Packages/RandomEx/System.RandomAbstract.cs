using System.Collections.Generic;

namespace System
{
    public abstract class RandomAbstract
    {
        #region Field

        protected readonly System.RandomBase.RandomValueFunction randomValueFunction;

        #endregion Field

        #region Constructor

        public RandomAbstract()
        {
            this.randomValueFunction = Value;
        }

        #endregion Constructor

        #region Method

        public abstract float Value();

        public int Index(IList<float> rates)
        {
            return System.RandomBase.Index(this.randomValueFunction, rates);
        }

        public int Sign()
        {
            return System.RandomBase.Sign(this.randomValueFunction);
        }

        public int Range(int min, int max)
        {
            return System.RandomBase.Range(this.randomValueFunction, min, max);
        }

        public float Range(float min, float max)
        {
            return System.RandomBase.Range(this.randomValueFunction, min, max);
        }

        public void OnUnitCircle(out float x, out float y)
        {
            System.RandomBase.OnUnitCircle(this.randomValueFunction, out x, out y);
        }

        public void InsideUnitCircle(out float x, out float y)
        {
            System.RandomBase.InsideUnitCircle(this.randomValueFunction, out x, out y);
        }

        public void OnUnitSphere(out float x, out float y, out float z)
        {
            System.RandomBase.OnUnitSphere(this.randomValueFunction, out x, out y, out z);
        }

        public void InsideUnitSphere(out float x, out float y, out float z)
        {
            System.RandomBase.InsideUnitSphere(this.randomValueFunction, out x, out y, out z);
        }

        #endregion Method
    }
}