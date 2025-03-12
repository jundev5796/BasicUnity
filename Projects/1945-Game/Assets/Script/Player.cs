using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        float moveX = moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float moveY = moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

        transform.Translate(moveX, moveY, 0);
    }
}
