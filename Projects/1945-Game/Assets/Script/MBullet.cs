using UnityEngine;

public class MBullet : MonoBehaviour
{
    public float Speed = 3f;

    public GameObject effect;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // ����Ʈ����
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1);

            // �÷��̾� �����

            // �̻��������
            Destroy(gameObject);
        }
    }
}
