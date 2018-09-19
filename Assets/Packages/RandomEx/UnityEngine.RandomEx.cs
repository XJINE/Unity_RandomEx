using System.Collections.Generic;

namespace UnityEngine
{
    public static class RandomEx
    {
        #region Class

        private class RandomExBase : UnityEngine.RandomAbstract 
        {
            public override float Value()
            {
                return Random.value;
            }
        }

        #endregion Class

        #region Field

        private static readonly RandomExBase Entity;

        #endregion Field

        #region Constructor

        static RandomEx()
        {
            RandomEx.Entity = new RandomExBase();
        }

        #endregion Constructor

        #region Method

        #region Delegation System.RandomAbstract

        public static int Index(IList<float> rates)
        {
            return RandomEx.Entity.Index(rates);
        }

        public static int Sign()
        {
            return RandomEx.Entity.Sign();
        }

        public static int Range(int min, int max)
        {
            return RandomEx.Entity.Range(min, max);
        }

        public static float Range(float min, float max)
        {
            return RandomEx.Entity.Range(min, max);
        }

        public static void OnUnitCircle(out float x, out float y)
        {
            RandomEx.Entity.OnUnitCircle(out x, out y);
        }

        public static void InsideUnitCircle(out float x, out float y)
        {
            RandomEx.Entity.InsideUnitCircle(out x, out y);
        }

        public static void OnUnitSphere(out float x, out float y, out float z)
        {
            RandomEx.Entity.OnUnitSphere(out x, out y, out z);
        }

        public static void InsideUnitSphere(out float x, out float y, out float z)
        {
            RandomEx.Entity.InsideUnitSphere(out x, out y, out z);
        }

        #endregion Delegation System.RandomAbstract

        #region Delegation UnityEngine.RandomAbstract

        public static Vector2 OnUnitCircle()
        {
            return RandomEx.Entity.OnUnitCircle();
        }

        public static Vector2 InsideUnitCircle()
        {
            return RandomEx.Entity.InsideUnitCircle();
        }

        public static Vector3 OnUnitSphere()
        {
            return RandomEx.Entity.OnUnitSphere();
        }

        public static Vector3 InsideUnitSphere()
        {
            return RandomEx.Entity.InsideUnitSphere();
        }

        public static Color ColorHSV()
        {
            return RandomEx.Entity.ColorHSV();
        }

        public static Color ColorHSV(float hueMin, float hueMax,
                                     float satMin, float satMax,
                                     float valMin, float valMax,
                                     float alphaMin, float alphaMax)
        {
            return RandomEx.Entity.ColorHSV(hueMin, hueMax,
                                            satMin, satMax,
                                            valMin, valMax,
                                            alphaMin, alphaMax);
        }

        #endregion Delegation UnityEngine.RandomAbstract

        #endregion Method
    }
}