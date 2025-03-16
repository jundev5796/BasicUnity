using UnityEngine;

public class PBullet : MonoBehaviour
{
    public float Speed = 4.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
