using UnityEngine;

public class LoopExample : MonoBehaviour
{
    void Start()
    {
        // for loop: 1-10 output
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log("Count: " + i);
        }

        // while loop
        int counter = 0;
        while (counter < 5)
        {
            Debug.Log("While Count: " + counter);
            counter++;
        }

    }
}
