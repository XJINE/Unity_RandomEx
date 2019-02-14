// NOTE:
// https://www.jstatsoft.org/article/view/v008i14
// This is implement of xor128 case.
// There is a little biased in a small number of trials.

using System;

public class Xorshift
{
    #region Field

    protected const uint SEED_X = 123456789u;
    protected const uint SEED_Y = 362436069u;
    protected const uint SEED_Z = 521288629u;
    protected const uint SEED_W = 88675123u;

    private uint x, y, z, w;

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
        x = Xorshift.SEED_X;
        y = Xorshift.SEED_Y;
        z = Xorshift.SEED_Z;
        w = seed;
    }

    #endregion Constructor

    #region Method

    public uint ValueNative()
    {
        // NOTE:
        // Return 0 ~ 2^32-1 value.

        uint t = x ^ (x << 11);

        x = y;
        y = z;
        z = w;
        w = (w ^ (w >> 19)) ^ (t ^ (t >> 8));

        return w;
    }

    public float Value()
    {
        // NOTE:
        // Return 0 ~ 1 value.

        return (ValueNative() / (float)(uint.MaxValue));
    }

    #endregion Method
}