using UnityEngine;

public class Monster : MonoBehaviour
{
    public float Speed = 3.0f;
    public float Delay = 1f;
    // public Transform ms1;
    // public Transform ms2;
    // public GameObject bullet;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        // �Ʒ� �������� ��������
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
