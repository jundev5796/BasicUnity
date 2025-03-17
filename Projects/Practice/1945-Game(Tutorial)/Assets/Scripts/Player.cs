using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        if (Input.GetAxis("Horizontal") <= -0.5f)
            anim.SetBool("Left", true);
        else
            anim.SetBool("Left", false);

        if (Input.GetAxis("Horizontal") >= 0.5f)
            anim.SetBool("Right", true);
        else
            anim.SetBool("Right", false);

        if (Input.GetAxis("Vertical") >= 0.5f)
            anim.SetBool("Up", true);
        else
            anim.SetBool("Up", false);

        transform.Translate(moveX, moveY, 0);
    }
}
