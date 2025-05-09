using UnityEngine;

public class Monster : MonoBehaviour
{
    public float Speed = 3.0f;
    public float Delay = 1f;
    public Transform ms1;
    public Transform ms2;
    public GameObject bullet;

    void Start()
    {
        // 한번함수호출
        Invoke("CreateBullet", Delay);
    }

    void CreateBullet()
    {
        Instantiate(bullet, ms1.position, Quaternion.identity);
        Instantiate(bullet, ms2.position, Quaternion.identity);

        // 재귀호출
        Invoke("CreateBullet", Delay);
    }
    
    void Update()
    {
        // 아래 방향으로 움직여라
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    //
}
