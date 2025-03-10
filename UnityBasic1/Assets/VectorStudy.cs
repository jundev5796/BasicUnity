using UnityEngine;

public class VectorStudy : MonoBehaviour
{
    // public Vector2 v2 = new Vector2(10, 10);
    // public Vector3 v3 = new Vector3(1, 1, 1);

    void Start()
    {
        Vector3 a = new Vector3(1, 0, 0);
        Vector3 b = new Vector3(2, 0, 0);

        Vector3 c = a + b;

        Debug.Log("Vector" + c);
    }

    void Update()
    {
        
    }
}
