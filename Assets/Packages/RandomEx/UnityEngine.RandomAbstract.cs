namespace UnityEngine 
{
    public abstract class RandomAbstract : System.RandomAbstract
    {
        #region Method

        public Vector2 OnUnitCircle()
        {
            return UnityEngine.RandomBase.OnUnitCircle(base.randomValueFunction);
        }

        public Vector2 InsideUnitCircle()
        {
            return UnityEngine.RandomBase.InsideUnitCircle(base.randomValueFunction);
        }

        public Vector3 OnUnitSphere()
        {
            return UnityEngine.RandomBase.OnUnitSphere(base.randomValueFunction);
        }

        public Vector3 InsideUnitSphere()
        {
            return UnityEngine.RandomBase.InsideUnitSphere(base.randomValueFunction);
        }

        public Color ColorHSV()
        {
            return UnityEngine.RandomBase.ColorHSV(base.randomValueFunction);
        }

        public Color ColorHSV(float hueMin, float hueMax,
                              float satMin, float satMax,
                              float valMin, float valMax,
                              float alphaMin, float alphaMax)
        {
            return UnityEngine.RandomBase.ColorHSV(base.randomValueFunction,
                                                   hueMin, hueMax,
                                                   satMin, satMax,
                                                   valMin, valMax,
                                                   alphaMin, alphaMax);
        }

        #endregion Method
    }
}