using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Animator anim;

    //private Vector2 minBounds;
    //private Vector2 maxBounds;

    void Start()
    {
        anim = GetComponent<Animator>();

        //Camera cam = Camera.main;
        //Vector3 bottomLeft = cam.ViewportToWorldPoint(new Vector3(0, 0, 0));
        //Vector3 topRight = cam.ViewportToWorldPoint(new Vector3(1, 1, 0));

        //minBounds = new Vector2(bottomLeft.x, bottomLeft.y);
        //maxBounds = new Vector2(topRight.x, topRight.y);
    }

    void Update()
    {
        float moveX = moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float moveY = moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

        // -1   0   1
        if (Input.GetAxis("Horizontal") <= -0.5f)
            anim.SetBool("left", true);
        else
            anim.SetBool("left", false);

        if (Input.GetAxis("Horizontal") >= 0.5f)
            anim.SetBool("right", true);
        else
            anim.SetBool("right", false);

        if (Input.GetAxis("Vertical") >= 0.5f)
            anim.SetBool("up", true);
        else
            anim.SetBool("up", false);

            //Vector3 newPosition = transform.position + new Vector3(moveX, moveY, 0);

            //// 경계를 벗어나지 않도록 위치 제한
            //newPosition.x = Mathf.Clamp(newPosition.x, minBounds.x, maxBounds.x);
            //newPosition.y = Mathf.Clamp(newPosition.y, minBounds.y, maxBounds.y);

            transform.Translate(moveX, moveY, 0);
    }
}
