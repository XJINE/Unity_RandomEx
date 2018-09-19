using System.Collections.Generic;
using UnityEngine;

public class RandomExSample : MonoBehaviour
{
    public List<PrimitiveType> primitiveTypes;

    public List<float> primitiveRates;

    private KeyCode generateKey = KeyCode.Return;

    private List<int> generateCount;

    protected void Start ()
    {
        this.generateCount = new List<int>();

        for (int i = 0; i < this.primitiveRates.Count; i++)
        {
            this.generateCount.Add(0);
        }
    }

    protected void Update ()
    {
        if (!Input.GetKeyDown(this.generateKey))
        {
            return;
        }

        int index = RandomEx.Index(this.primitiveRates);

        GameObject newObject = GameObject.CreatePrimitive(this.primitiveTypes[index]);

        GameObject.Destroy(newObject, RandomEx.Range(0.2f, 0.5f));

        this.generateCount[index] += 1;
    }

    protected void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 10, 200, 200));

        GUILayout.Label("Press Return to Generate Object.");

        for (int i = 0; i < this.primitiveRates.Count; i++)
        {
            GUILayout.Label(" - Rate : " + this.primitiveRates[i] + " Count [" + this.generateCount[i] + "]");
        }

        GUILayout.EndArea();
    }
}