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
        //Y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }


    private void OnBecameInvisible()
    {
        //미사일이 화면밖으로 나갔으면
        //미사일 지우자
        Destroy(gameObject);
    }


    // 2D충돌 트리거이벤트
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 미사일과 적이 부딪혔다
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // 폭발 이펙트 생성
            Instantiate(explosion, transform.position, Quaternion.identity);

            // 죽음사운드
            SoundManager.instance.SoundDie(); // 적 죽음 사운드

            // 점수올려주기
            GameManager.instance.AddScore(10);

            // 적지우기
            Destroy(collision.gameObject);

            // 총알 지우기 자기자신
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy_Normal"))
        {
            // 폭발 이펙트 생성
            Instantiate(explosion, transform.position, Quaternion.identity);

            // 죽음사운드
            SoundManager.instance.SoundDie(); // 적 죽음 사운드

            // 점수올려주기
            GameManager.instance.AddScore(30);

            // 적지우기
            Destroy(collision.gameObject);

            // 총알 지우기 자기자신
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
