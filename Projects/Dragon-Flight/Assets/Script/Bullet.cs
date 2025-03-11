using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 0.45f;
    public GameObject explosion;
    public float bossHP = 10;


    void Start()
    {
        
    }


    void Update()
    {
        //Y�� �̵�
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }


    private void OnBecameInvisible()
    {
        //�̻����� ȭ������� ��������
        //�̻��� ������
        Destroy(gameObject);
    }


    // 2D�浹 Ʈ�����̺�Ʈ
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // �̻��ϰ� ���� �ε�����
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // ���� ����Ʈ ����
            Instantiate(explosion, transform.position, Quaternion.identity);

            // ��������
            SoundManager.instance.SoundDie(); // �� ���� ����

            // �����÷��ֱ�
            GameManager.instance.AddScore(10);

            // �������
            Destroy(collision.gameObject);

            // �Ѿ� ����� �ڱ��ڽ�
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy_Normal"))
        {
            // ���� ����Ʈ ����
            Instantiate(explosion, transform.position, Quaternion.identity);

            // ��������
            SoundManager.instance.SoundDie(); // �� ���� ����

            // �����÷��ֱ�
            GameManager.instance.AddScore(30);

            // �������
            Destroy(collision.gameObject);

            // �Ѿ� ����� �ڱ��ڽ�
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Boss"))
        {
            // Get the Boss component and reduce HP
            Boss boss = collision.gameObject.GetComponent<Boss>();

            if (boss != null)
            {
                boss.TakeDamage(1); // Reduce HP by 1
            }

            // Show explosion effect
            Instantiate(explosion, transform.position, Quaternion.identity);

            // Play sound effect
            SoundManager.instance.SoundDie();

            //// Add score
            //GameManager.instance.AddScore(100);

            // Destroy the bullet
            Destroy(gameObject);
        }
    }
}
