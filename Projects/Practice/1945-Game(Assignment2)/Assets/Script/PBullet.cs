using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 4.0f;
    public float dropChance = 0.3f;
    // 공격력
    // 이텍트
    public GameObject effect;
    public GameObject item;

    void Update()
    {
        // 미사일 위쪽방향으로 움직이기
        // 위의 방향 * 스피드 * 타임
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }

    // 화면밖으로 나갈경우
    private void OnBecameInvisible()
    {
        // 자기 자신 지우기
        Destroy(gameObject);
    }

    // 충돌처리
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            // 이펙트생성
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            // 1초뒤에 지우기
            Destroy(go, 1);

            if (Random.value < dropChance)
                Instantiate(item, collision.transform.position, Quaternion.identity);

            // 몬스터 삭제
            Destroy(collision.gameObject);

            // 미사일 삭제
            Destroy(gameObject);
        }
    }
}
