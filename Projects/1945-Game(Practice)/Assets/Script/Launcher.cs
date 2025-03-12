using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;

    void Start()
    {
        InvokeRepeating("Shoot", 0.5f, 0.2f);
    }

    void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }

    void Update()
    {
        
    }
}
