using UnityEngine;

public class Monster : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float delay = 1f;
    public Transform ms1;
    public Transform ms2;
    public GameObject bullet;

    void Start()
    {
        Invoke("CreateBullet", delay);
    }

    void CreateBullet()
    {
        Instantiate(bullet, ms1.position, Quaternion.identity);
        Instantiate(bullet, ms2.position, Quaternion.identity);

        Invoke("CreateBullet", delay);
    }

    void Update()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
