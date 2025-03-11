using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 0.45f;
    public GameObject explosion;


    void Start()
    {
        Singleton.Instance.PrintMessage();
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

            // �������
            Destroy(collision.gameObject);

            // �Ѿ� ����� �ڱ��ڽ�
            Destroy(gameObject);
        }
    }
}
