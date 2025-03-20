using UnityEngine;

public class PBullet : MonoBehaviour
{
    public float bulletSpeed = 4.0f;
    public int Attack = 10;
    //public GameObject effect;


    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            collision.gameObject.GetComponent<Monster>().Damage(Attack);

            Destroy(gameObject);
        }
    }
}
