using UnityEngine;

public class XorshiftSample : MonoBehaviour
{
    Xorshift xorshift;

    protected virtual void Start()
    {
        this.xorshift = new Xorshift(0);
    }

    protected virtual void Update()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube.transform.position = this.xorshift.OnUnitSphere();
        cube.transform.localScale *= this.xorshift.Value();

        GameObject.Destroy(cube, this.xorshift.Range(0, 1.5f));
    }
}