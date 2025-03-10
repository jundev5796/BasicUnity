using UnityEngine;

public class FunctionExample : MonoBehaviour
{
    // Function
    void SayHello()
    {
        Debug.Log("Hello, Unity");
    }

    int AddNumbers(int a, int b)
    {
        return a + b;
    }

    void Start()
    {
        SayHello();
        int total = AddNumbers(3, 5);
        Debug.Log($"Total: {total}");
    }

    void Update()
    {
             
    }
}
