using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 0.45f;


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
}
