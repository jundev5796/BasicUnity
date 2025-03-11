using System.Collections;
using UnityEngine;

public class CoroutineStudy : MonoBehaviour
{
    // C# ����Ƽ �ڷ�ƾ(Coroutine) ����
    // �ڷ�ƾ�� �Ϲ����� �Լ��� �޸� ������ ����ٰ� �ٽ� �̾ ������ �� �ִ� ����̾�.
    // �̸� �̿��ϸ� ���� �ð� �� ����ǰų�, Ư�� ������ ��ٸ��� ���� ����� ���� ������ �� �־�!

    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        Debug.Log("�ڷ�ƾ ����!");
        yield return new WaitForSeconds(2f); // 2�� delay
        Debug.Log("2�� �� ����");
        
    }
}
