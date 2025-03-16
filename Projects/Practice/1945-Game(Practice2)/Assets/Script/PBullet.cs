using UnityEngine;

public class PBullet : MonoBehaviour
{
    public float Speed = 4.0f;
    public int Attack = 10;
    public GameObject effect;

    void Update()
    {
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            // ����Ʈ����
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            // 1�ʵڿ� �����
            Destroy(go, 1);

            // ���� ����
            collision.gameObject.GetComponent<Monster>().Damage(1);

            // �̻��� ����
            Destroy(gameObject);
        }
    }
}
