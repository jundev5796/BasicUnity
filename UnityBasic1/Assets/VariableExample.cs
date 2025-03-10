using UnityEngine;

public class VariableExample : MonoBehaviour
{
    // 1. variable declare
    public int playerScore = 0;
    public float speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameOver = false;

    void Start()
    {
        // variable output
        Debug.Log("Player Name: " + playerName);
        Debug.Log("Player Score: " + playerScore);
        Debug.Log("Speed: " + speed);
        Debug.Log("Is Game Over?: " + isGameOver);
    }
}
