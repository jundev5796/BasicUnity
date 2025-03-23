using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    Animator anim;

    public GameObject[] bullet;
    public Transform pos;

    public int power = 0;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        if (Input.GetAxis("Horizontal") <= -0.5f)
            anim.SetBool("Left", true);
        else
            anim.SetBool("Left", false);

        if (Input.GetAxis("Horizontal") >= 0.5f)
            anim.SetBool("Right", true);
        else
            anim.SetBool("Right", false);

        if (Input.GetAxis("Vertical") >= 0.5f)
            anim.SetBool("Up", true);
        else
            anim.SetBool("Up", false);

        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(bullet[power], pos.position, Quaternion.identity);

        transform.Translate(moveX, moveY, 0);

        //캐릭터의 월드 좌표를 뷰포트 좌표계로 변환해준다.
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        viewPos.x = Mathf.Clamp01(viewPos.x); //x값을 0이상, 1이하로 제한한다.
        viewPos.y = Mathf.Clamp01(viewPos.y); //y값을 0이상, 1이하로 제한한다.
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);//다시월드좌표로 변환
        transform.position = worldPos; //좌표를 적용한다.
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            power += 1;

            if (power >= 3)
                power = 3;

            Destroy(collision.gameObject);
        }
    }
}
