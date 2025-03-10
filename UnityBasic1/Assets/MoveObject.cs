using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // test
    public float speed = 5.0f; // move speed

    void Update()
    {
        //// move with key press
        //float move = Input.GetAxis("Horizontal");

        //// direction * speed * time.deltatime
        //transform.Translate(Vector3.right * move * speed * Time.deltaTime);

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        transform.position += move * speed * Time.deltaTime;
    }
}
