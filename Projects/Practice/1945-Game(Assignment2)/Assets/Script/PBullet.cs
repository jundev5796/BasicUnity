using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 4.0f;
    public float dropChance = 0.3f;
    // ���ݷ�
    // ����Ʈ
    public GameObject effect;
    public GameObject item;

    void Update()
    {
        // �̻��� ���ʹ������� �����̱�
        // ���� ���� * ���ǵ� * Ÿ��
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }

    // ȭ������� �������
    private void OnBecameInvisible()
    {
        // �ڱ� �ڽ� �����
        Destroy(gameObject);
    }

    // �浹ó��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            // ����Ʈ����
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            // 1�ʵڿ� �����
            Destroy(go, 1);

            if (Random.value < dropChance)
                Instantiate(item, collision.transform.position, Quaternion.identity);

            // ���� ����
            Destroy(collision.gameObject);

            // �̻��� ����
            Destroy(gameObject);
        }
    }
}
