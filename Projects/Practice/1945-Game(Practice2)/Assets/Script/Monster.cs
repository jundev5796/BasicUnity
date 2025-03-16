using UnityEngine;

public class Monster : MonoBehaviour
{
    public float Speed = 3.0f;
    public float Delay = 1f;
    public Transform ms1;
    public Transform ms2;
    public GameObject bullet;
    public GameObject Item;

    void Start()
    {
        Invoke("CreateBullet", Delay);
    }

    void Update()
    {
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
    }

    void CreateBullet()
    {
        Instantiate(bullet, ms1.position, Quaternion.identity);
        Instantiate(bullet, ms2.position, Quaternion.identity);

        // ¿Á±Õ»£√‚
        Invoke("CreateBullet", Delay);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
