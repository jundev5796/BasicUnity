using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 0.45f;


    void Start()
    {

    }


    void Update()
    {
        //Y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }


    private void OnBecameInvisible()
    {
        //미사일이 화면밖으로 나갔으면
        //미사일 지우자
        Destroy(gameObject);
    }
}
