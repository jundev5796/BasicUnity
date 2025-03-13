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
            // 이펙트생성
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1);

            // 플레이어 지우기

            // 미사일지우기
            Destroy(gameObject);
        }
    }
}
