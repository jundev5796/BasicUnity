using UnityEngine;

public class Item : MonoBehaviour
{
    public float itemVelocity = 20f;
    Rigidbody2D rig = null;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector2(itemVelocity, itemVelocity));
    }

    void Update()
    {
        
    }
}
