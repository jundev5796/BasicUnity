using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // �̱���
    // ��𿡼��� ���� �Ҽ� �ֵ��� static(����)���� �ڱ��ڽ��� �����ؼ� �̱����̶�� ������������ ����غ���.
    public static GameManager instance;
    public Text scoreText; // ������ ǥ���ϴ� Text��ü�� �����Ϳ��� �޾ƿɴϴ�.

    int score = 0; // ������ �����մϴ�.

    private void Awake()
    {
        if (instance == null) // �������� �ڽ��� üũ�մϴ�. null����
        {
            instance = this; // �ڱ��ڽ��� �����Ѵ�.
        }
    }

    void Start()
    {
        
    }

    public void AddScore(int num)
    {
        score += num; // ������ �����ݴϴ�.
        scoreText.text = $"Score : {score}"; // �ؽ�Ʈ�� �ݿ��մϴ�.
    }

    
}
