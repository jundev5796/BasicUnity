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
            // rigidbody: ����ȿ���� �߰��� �߷��� �����մϴ�.
            // addforce: ������ ���� ������Ʈ�� ���� �ݴϴ�.
            // ForceMode.Impulse: ���������� ���� ���ϴ� �ɼ�.
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
