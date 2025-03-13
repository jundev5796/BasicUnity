using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float ss = -2; //���� ���� x�� ó��
    public float es = 2;  //���� ���� x�� ��
    public float StartTime = 1; //����
    public float SpawnStop = 10; //���������½ð�
    public GameObject monster;

    bool swi = true;

    void Start()
    {
        StartCoroutine("RandomSpawn");
        Invoke("Stop", SpawnStop);
    }

    //�ڷ�ƾ���� �����ϰ� �����ϱ�
    IEnumerator RandomSpawn()
    {
        while (swi)
        {
            //1�ʸ���
            yield return new WaitForSeconds(StartTime);
            //x�� ����
            float x = Random.Range(ss, es);
            //x���� ���� y���� �ڱ��ڽŰ�
            Vector2 r = new Vector2(x, transform.position.y);
            //���� ����
            Instantiate(monster, r, Quaternion.identity);
        }
    }

    void Stop()
    {
        swi = false;
        //�ι�° ���� �ڷ�ƾ

    }
}
