using UnityEngine;
public class ConditionExample : MonoBehaviour
{
    public int health = 100;
    void Update()
    {
        health -= 1; // decrease health
        Debug.Log("Health: " + health);
        
        // conditional
        if (health <= 0)
        {
            Debug.Log("Game Over!");
        }
    }
}

