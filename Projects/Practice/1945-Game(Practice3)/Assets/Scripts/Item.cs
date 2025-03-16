using UnityEngine;

public class Item : MonoBehaviour
{
    public float Speed = 20f;
    Rigidbody2D rig = null;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector2(Speed, Speed));
    }

    void Update()
    {

    }
}
