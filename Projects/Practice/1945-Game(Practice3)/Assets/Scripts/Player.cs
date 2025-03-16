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

        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        viewPos.x = Mathf.Clamp01(viewPos.x); //x���� 0�̻�, 1���Ϸ� �����Ѵ�.
        viewPos.y = Mathf.Clamp01(viewPos.y); //y���� 0�̻�, 1���Ϸ� �����Ѵ�.
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);//�ٽÿ�����ǥ�� ��ȯ
        transform.position = worldPos; //��ǥ�� �����Ѵ�.
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
