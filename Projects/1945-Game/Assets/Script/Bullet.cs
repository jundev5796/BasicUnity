using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 4.0f;
    // ���ݷ�
    // ����Ʈ

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
}
