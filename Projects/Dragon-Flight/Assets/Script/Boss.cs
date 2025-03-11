using UnityEngine;

public class Boss : MonoBehaviour
{
    public float moveSpeed = 1.3f;
    public int bossHP = 10; // Boss HP stored in Boss itself

    void Update()
    {
        // Move the boss down
        float distanceY = moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, 0);
    }

    public void TakeDamage(int damage)
    {
        bossHP -= damage;

        if (bossHP <= 0)
        {
            Destroy(gameObject); // Destroy boss when HP reaches 0

            GameManager.instance.AddScore(100);
        }
    }
}

