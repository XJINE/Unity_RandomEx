namespace UnityEngine 
{
    public static class RandomBase 
    {
        #region Method

        public static Vector2 OnUnitCircle(System.RandomBase.RandomValueFunction randomValueFunction)
        {
            float x, y;
            System.RandomBase.OnUnitCircle(randomValueFunction, out x, out y);
            return new Vector2(x, y);
        }

        public static Vector2 InsideUnitCircle(System.RandomBase.RandomValueFunction randomValueFunction)
        {
            float x, y;
            System.RandomBase.InsideUnitCircle(randomValueFunction, out x, out y);
            return new Vector2(x, y);
        }

        public static Vector3 OnUnitSphere(System.RandomBase.RandomValueFunction randomValueFunction)
        {
            float x, y, z;
            System.RandomBase.OnUnitSphere(randomValueFunction, out x, out y, out z);
            return new Vector3(x, y, z);
        }

        public static Vector3 InsideUnitSphere(System.RandomBase.RandomValueFunction randomValueFunction)
        {
            float x, y, z;
            System.RandomBase.InsideUnitSphere(randomValueFunction, out x, out y, out z);
            return new Vector3(x, y, z);
        }

        public static Color ColorHSV(System.RandomBase.RandomValueFunction randomValueFunction)
        {
            return ColorHSV(randomValueFunction,
                            0, 1,
                            0, 1,
                            0, 1,
                            1, 1);
        }

        public static Color ColorHSV(System.RandomBase.RandomValueFunction randomValueFunction,
                                     float hueMin, float hueMax,
                                     float satMin, float satMax,
                                     float valMin, float valMax,
                                     float alphaMin, float alphaMax)
        {
            return new Color(System.RandomBase.Range(randomValueFunction, hueMin, hueMax),
                             System.RandomBase.Range(randomValueFunction, satMin, satMax),
                             System.RandomBase.Range(randomValueFunction, valMin, valMax),
                             System.RandomBase.Range(randomValueFunction, alphaMin, alphaMax));
        }

        #endregion Method
    }
}