using System.Collections.Generic;
using UnityEngine;

public static class RandomEx
{
    #region Field

    private static readonly float RADIAN_MIN = 0;
    private static readonly float RADIAN_MAX = 6.283185307179586f;

    // NOTE:
    // ValueFunc must return 0 ~ 1 range value.

    public static System.Func<float> ValueFunc = delegate () { return Random.value; };

    #endregion Field

    #region Property

    public static float Value { get { return RandomEx.ValueFunc(); } }

    public static float Radian { get { return Range(RandomEx.RADIAN_MIN, RandomEx.RADIAN_MAX); } }

    public static int Sign { get { return Range(0, 2) == 0 ? -1 : 1; } }

    #endregion Property

    #region Method

    // NOTE:
    // Range function returns min ~ max range value.
    // If argument type is int, the result excludes max value.
    // If argument type is float, the result includes max value.

    public static int Index(IList<float> rates)
    {
        int index = 0;
        float seedValue = Value;

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

    public static int Range(int min, int max)
    {
        return (int)(min + (max - min + 1) * Value);
    }

    public static float Range(float min, float max)
    {
        return min + (max - min) * Value;
    }

    public static float Range(Vector2 range)
    {
        return Range(range.x, range.y);
    }

    public static Vector2 Range(Vector2 min, Vector2 max)
    {
        return new Vector2(Range(min.x, max.x), Range(min.y, max.y));
    }

    public static Vector2Int Range(Vector2Int min, Vector2Int max)
    {
        return new Vector2Int(Range(min.x, max.x), Range(min.y, max.y));
    }

    public static Vector3 Range(Vector3 min, Vector3 max)
    {
        return new Vector3(Range(min.x, max.x), Range(min.y, max.y), Range(min.z, max.z));
    }

    public static Vector3Int Range(Vector3Int min, Vector3Int max)
    {
        return new Vector3Int(Range(min.x, max.x), Range(min.y, max.y), Range(min.z, max.z));
    }

    public static Vector4 Range(Vector4 min, Vector4 max)
    {
        return new Vector4(Range(min.x, max.x), Range(min.y, max.y), Range(min.z, max.z), Range(min.w, max.w));
    }

    public static Vector2 Range(Rect rect)
    {
        return Range(rect.min, rect.max);
    }

    public static Vector3 Range(Bounds bounds)
    {
        return Range(bounds.min, bounds.max);
    }

    public static void OnUnitCircle(out float x, out float y)
    {
        float angle = Radian;

        x = Mathf.Cos(angle);
        y = Mathf.Sin(angle);
    }

    public static Vector2 OnUnitCircle()
    {
        OnUnitCircle(out float x, out float y);

        return new Vector2(x, y);
    }

    public static void InsideUnitCircle(out float x, out float y)
    {
        float angle = Radian;
        float radius = Value;

        x = Mathf.Cos(angle) * radius;
        y = Mathf.Sin(angle) * radius;
    }

    public static Vector2 InsideUnitCircle()
    {
        InsideUnitCircle(out float x, out float y);

        return new Vector2(x, y);
    }

    public static void OnUnitSphere(out float x, out float y, out float z)
    {
        float angle1 = Radian;
        float angle2 = Radian;

        x = Mathf.Sin(angle1) * Mathf.Cos(angle2);
        y = Mathf.Sin(angle1) * Mathf.Sin(angle2);
        z = Mathf.Cos(angle1);
    }

    public static Vector3 OnUnitSphere()
    {
        OnUnitSphere(out float x, out float y, out float z);

        return new Vector3(x, y, z);
    }

    public static void InsideUnitSphere(out float x, out float y, out float z)
    {
        OnUnitSphere(out x, out y, out z);

        float radius = Value;

        x *= radius;
        y *= radius;
        z *= radius;
    }

    public static Vector3 InsideUnitSphere()
    {
        InsideUnitSphere(out float x, out float y, out float z);

        return new Vector3(x, y, z);
    }

    #endregion Method
}