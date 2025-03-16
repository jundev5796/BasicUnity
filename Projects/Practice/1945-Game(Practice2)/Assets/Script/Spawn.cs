using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float ss = -2;
    public float es = 2;
    public float startTime = 1;
    public float endTime = 10;
    public GameObject monster;

    bool swi = true;

    void Start()
    {
        StartCoroutine("RandomSpawn");
        Invoke("Stop", endTime);
    }

    IEnumerator RandomSpawn()
    {
        while (swi)
        {
            yield return new WaitForSeconds(startTime);

            float x = Random.Range(ss, es);

            Vector2 r = new Vector2(x, transform.position.y);

            Instantiate(monster, r, Quaternion.identity);
        }
    }

    void Stop()
    {
        swi = false;
        StopCoroutine("RandomSpawn");
    }
}
