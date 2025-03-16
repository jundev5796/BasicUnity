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
            // 이펙트생성
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            // 1초뒤에 지우기
            Destroy(go, 1);

            // 몬스터 삭제
            collision.gameObject.GetComponent<Monster>().Damage(1);

            // 미사일 삭제
            Destroy(gameObject);
        }
    }
}
