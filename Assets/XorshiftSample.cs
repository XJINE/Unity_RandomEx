using UnityEngine;

public class XorshiftSample : MonoBehaviour
{
    private Xorshift xorshift;

    protected virtual void Start()
    {
        this.xorshift = new Xorshift(0);

        RandomEx.ValueFunc = this.xorshift.Value;
    }

    protected virtual void Update()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube.transform.position = RandomEx.OnUnitSphere() * 5;
        cube.transform.localScale *= RandomEx.Value;

        GameObject.Destroy(cube, RandomEx.Range(0, 1.5f));
    }
}