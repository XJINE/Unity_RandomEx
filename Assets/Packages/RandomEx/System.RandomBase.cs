using System.Collections.Generic;

namespace System 
{
    public static class RandomBase
    {
        #region Delegate

        public delegate float RandomValueFunction();

        #endregion Delegate

        #region Field

        public static readonly float RADIAN_MIN = 0;
        public static readonly float RADIAN_MAX = 6.283185307179586f;

        #endregion Field

        #region Method

        public static int Index(RandomValueFunction randomValueFunction, IList<float> rates)
        {
            int index = 0;
            float seedValue = randomValueFunction();

            for (index = 0; index < rates.Count; index++)
            {
                seedValue -= rates[index];

                if (seedValue <= 0)
                {
                    break;
                }
            }

            return index;
        }

        public static int Sign(RandomValueFunction randomValueFunction)
        {
            return Range(randomValueFunction, 0, 2) == 0 ? -1 : 1;
        }

        // NOTE:
        // Return min ~ max range value.
        // If argument type is int, the result excludes max value.
        // If argument type is float, the result includes max value.

        public static int Range(RandomValueFunction randomValueFunction, int min, int max)
        {
            return (int)(min + (max - min + 1) * randomValueFunction());
        }

        public static float Range(RandomValueFunction randomValueFunction, float min, float max)
        {
            return min + (max - min) * randomValueFunction();
        }

        public static void OnUnitCircle(RandomValueFunction randomValueFunction, out float x, out float y)
        {
            float angle = Range(randomValueFunction, RandomBase.RADIAN_MIN, RandomBase.RADIAN_MAX);

            x = (float)Math.Cos(angle);
            y = (float)Math.Sin(angle);
        }

        public static void InsideUnitCircle(RandomValueFunction randomValueFunction, out float x, out float y)
        {
            float angle = Range(randomValueFunction, RandomBase.RADIAN_MIN, RandomBase.RADIAN_MAX);
            float radius = randomValueFunction();

            x = (float)Math.Cos(angle) * radius;
            y = (float)Math.Sin(angle) * radius;
        }

        public static void OnUnitSphere(RandomValueFunction randomValueFunction, out float x, out float y, out float z)
        {
            float angle1 = Range(randomValueFunction, RandomBase.RADIAN_MIN, RandomBase.RADIAN_MAX);
            float angle2 = Range(randomValueFunction, RandomBase.RADIAN_MIN, RandomBase.RADIAN_MAX);

            x = (float)(Math.Sin(angle1) * Math.Cos(angle2));
            y = (float)(Math.Sin(angle1) * Math.Sin(angle2));
            z = (float)(Math.Cos(angle1));
        }

        public static void InsideUnitSphere(RandomValueFunction randomValueFunction, out float x, out float y, out float z)
        {
            OnUnitSphere(randomValueFunction, out x, out y, out z);

            float radius = randomValueFunction();

            x *= radius;
            y *= radius;
            z *= radius;
        }

        #endregion Method
    }
}