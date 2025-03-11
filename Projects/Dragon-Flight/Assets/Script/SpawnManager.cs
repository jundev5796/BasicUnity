using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //���Ͱ�������� 
    public GameObject enemy_small;
    public GameObject enemy_normal_01;
    public GameObject enemy_normal_02;
    public GameObject boss;

    private bool bossSpawned = false;

    //���� �����ϴ� �Լ�
    void SpawnEnemy()
    {
        float randomX1 = Random.Range(-2f, 2f); //���� ��Ÿ�� x��ǥ�� �������� �����ϱ�

        if (enemy_small)
            //���� �����Ѵ�. randomX������ x��
            Instantiate(enemy_small, new Vector3(randomX1, transform.position.y, 0f), Quaternion.identity);
    }

    void SpawnEnemy2()
    {
        float randomX2 = Random.Range(-2f, 2f);

        if (enemy_normal_01)
            Instantiate(enemy_normal_01, new Vector3(randomX2, transform.position.y, 0f), Quaternion.identity);
    }

    void SpawnEnemy3()
    {
        float randomX2 = Random.Range(-2f, 2f);

        if (enemy_normal_02)
            Instantiate(enemy_normal_02, new Vector3(randomX2, transform.position.y, 0f), Quaternion.identity);
    }

    void SpawnBoss()
    {
        if (!bossSpawned)
        {
            Instantiate(boss, new Vector3(0, transform.position.y, 0f), Quaternion.identity);
            bossSpawned = true;
        }
    }

    void Start()
    {
        //SpawnEnemy  1  0.5f 
        InvokeRepeating("SpawnEnemy", 4, 0.5f);
        Invoke("CancelSpawn", 20f);
        InvokeRepeating("SpawnEnemy2", 23, 0.5f);
        Invoke("CancelSpawn2", 43f);
        InvokeRepeating("SpawnEnemy3", 46, 0.5f);
        Invoke("CancelSpawn3", 64f);
        Invoke("SpawnBoss", 68f);
    }


    public void CancelSpawn()
    {
        CancelInvoke("SpawnEnemy");
    }

    public void CancelSpawn2()
    {
        CancelInvoke("SpawnEnemy2");
    }

    public void CancelSpawn3()
    {
        CancelInvoke("SpawnEnemy3");
    }
}
