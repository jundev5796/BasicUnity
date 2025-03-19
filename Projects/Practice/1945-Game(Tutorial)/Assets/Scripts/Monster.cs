using UnityEngine;

public class Monster : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float delay = 1f;

    void Start()
    {
        
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
