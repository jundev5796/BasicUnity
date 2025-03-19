using Unity.Cinemachine;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake instance;
    // Impulse Source ������Ʈ ����
    private CinemachineImpulseSource impulseSource;

    void Awake()
    {
        CameraShake.instance.SetImpulseSource(gameObject.GetComponent<CinemachineImpulseSource>());
        CameraShake.instance.cameraShakeShow();
    }

    public void SetImpulseSource(CinemachineImpulseSource source)
    {
        impulseSource = source;
    }

    // ī�޶���ũ ����
    public void cameraShakeShow()
    {
        if (impulseSource != null)
        {
            // �⺻ �������� ���޽� ����
            impulseSource.GenerateImpulse();
        }
    }
}
