using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    void Update()
    {
        playerControl();
    }

    public void playerControl()
    {
        float movementX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(movementX, 0, 0);
    }
}
