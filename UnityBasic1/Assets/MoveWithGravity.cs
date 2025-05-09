using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{
    private Rigidbody rb;

    public float jumpForce = 5.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // space key for jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // rigidbody: 물리효과를 추가해 중력을 적용합니다.
            // addforce: 점프를 위해 오브젝트에 힘을 줍니다.
            // ForceMode.Impulse: 순간적으로 힘을 가하는 옵션.
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
